using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace YoungHero
{
    public partial class DataMaker : Form
    {
        string FileName;
        //dynamic saveJson;
        string sStr;

        public DataMaker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.InitialDirectory = Properties.Settings.Default.dataPathName;
            ofg.Multiselect = false;
            ofg.ShowDialog();
            this.FileName = ofg.FileName;
            this.textBox1.Text = ofg.FileName;

            if (string.IsNullOrEmpty(this.FileName))
            {
                return;
            }

            FileInfo fi = new FileInfo(ofg.FileName);
            Properties.Settings.Default.dataPathName = fi.DirectoryName;
            Properties.Settings.Default.Save();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.FileName))
            {
                return;
            }

            await Task.Run(() => this.FileLoad());
        }

        private void FileLoad()
        {
            StreamReader SR = new StreamReader(this.FileName, Encoding.ASCII);
            string FileStr = SR.ReadToEnd();
            //saveJson = JsonConvert.DeserializeObject(saveStr);
            FormatDataFile(FileStr);
            SR.Close();
        }

        private void FormatDataFile(string SrcStr)
        {
            DataStringList ds = new DataStringList();
            StringBuilder sb = new StringBuilder();
            char sep1 = '\n';
            char sep2 = '\t';

            for (var i = 0; i < SrcStr.Length; i++)
            {
                char ch = SrcStr[i];

                if (ch == sep1)
                {
                    ds.New();
                    continue;
                }

                if (ch == sep2)
                {
                    ds.Add(sb);
                    sb = new StringBuilder();
                    continue;
                }

                if (char.IsControl(ch))
                {
                    continue;
                }

                sb.Append(ch);
            }

            //MessageBox.Show(sb.ToString(), "FormatDataFile");

            sb = new StringBuilder();

            ds.dsList.ForEach(x =>
            {
                sb.Append(x.SbList[0]);
                sb.Append(x.SbList[1]);
            });

            //MessageBox.Show(sb.ToString(), "FormatDataFile");
            sStr = sb.ToString();

            return;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Txt File|*.txt";
            sfd.InitialDirectory = Properties.Settings.Default.dataPathName;
            sfd.ShowDialog();

            if (string.IsNullOrEmpty(sfd.FileName))
            {
                return;
            }

            if(string.IsNullOrEmpty(sStr))
            {
                return;
            }

            StreamWriter sw = new StreamWriter(sfd.FileName);

            await sw.WriteAsync(sStr);
            sw.Close();

            MessageBox.Show("存檔完成", "存檔");
            this.Close();
        }
    }

    public class DataStringList
    {
        public List<DataString> dsList { get; private set; }

        public DataStringList()
        {
            dsList = new List<DataString>();
        }

        public void Add(StringBuilder SrcSb)
        {
            if (dsList.Count == 0)
            {
                this.New();
            }

            dsList[dsList.Count - 1].Add(SrcSb);
        }

        public void Add(StringBuilder SrcSb, int SrcIndex)
        {
            dsList[SrcIndex].Add(SrcSb);
        }

        public void New()
        {
            dsList.Add(new DataString(dsList.Count - 1));
        }

        public void New(int SrcIndex)
        {
            dsList.Add(new DataString(SrcIndex));
        }
    }

    public class DataString
    {
        public List<StringBuilder> SbList { get; private set; }
        int Index;

        public DataString()
        {
            Index = 0;
            SbList = new List<StringBuilder>();
        }

        public DataString(int SrcIndex)
        {
            Index = SrcIndex;
            SbList = new List<StringBuilder>();
        }

        public void Add(StringBuilder SrcSb)
        {
            SbList.Add(SrcSb);
        }
    }
}
