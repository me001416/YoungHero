using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace YoungHero
{
    public partial class DataMaker : Form
    {
        string FileName;
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
            string stringBox = string.Empty;
            string sep1 = "\n";
            string sep2 = "\t";

            for (var i = 0; i < SrcStr.Length; i++)
            {
                string str = StringInfo.GetNextTextElement(SrcStr,i);

                if (str == sep1)
                {
                    ds.New();
                    continue;
                }

                if (str == sep2)
                {
                    ds.Add(stringBox);
                    stringBox = string.Empty;
                    continue;
                }
                
                string.Concat(stringBox, str);
            }

            //MessageBox.Show(stringBox, "FormatDataFile");

            stringBox = string.Empty;

            ds.dsList.ForEach(x =>
            {
                x.SbList.ForEach(y =>
                {
                    string.Concat(stringBox, y);
                    string.Concat(stringBox, ",");
                });
                //string.Concat(stringBox, x.SbList[1]);
                //string.Concat(stringBox, ",");
            });

            //sb.Append(ds.dsList[3].SbList[1]);
            //sb.Append(ds.dsList[3].SbList[2]);

            MessageBox.Show(stringBox, "FormatDataFile");
            sStr = stringBox;

            return;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Txt File|*.txt";
            sfd.InitialDirectory = Properties.Settings.Default.dataPathName;
            sfd.ShowDialog();
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(sfd.FileName))
            {
                return;
            }

            StreamWriter sw = new StreamWriter(sfd.FileName);

            await sw.WriteAsync(sStr);
            //await sw.WriteAsync(sb.ToString());
            sw.Close();

            MessageBox.Show("存檔完成", "存檔");
            this.Close();
        }

        static void savebig5()
        {
            StringBuilder sb = new StringBuilder();
            string source = "⊃;nÅé&frac14;Ò⊃;Õ¤¤ªº¤@¯ë©Ê¿ù»~¡G&frac14;Ð·Ç GUI (⊃;Ï§Î¤Æ¥Î¤á¤¶­±)¡C";

            foreach (var e in Encoding.GetEncodings())
            {
                byte[] unknow = Encoding.GetEncoding(e.CodePage).GetBytes(source);
                string result = Encoding.GetEncoding(950).GetString(unknow);
                sb.AppendLine(string.Format("{0} => {1} : {2}", e.CodePage, 950, result));
            }
            File.WriteAllText("big5.txt", sb.ToString());
        }
    }

    public class DataStringList
    {
        public List<DataString> dsList { get; private set; }

        public DataStringList()
        {
            dsList = new List<DataString>();
        }

        public void Add(string SrcSb)
        {
            if (dsList.Count == 0)
            {
                this.New();
            }

            dsList[dsList.Count - 1].Add(SrcSb);
        }

        public void Add(string SrcSb, int SrcIndex)
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
        public List<string> SbList { get; private set; }
        int Index;

        public DataString()
        {
            Index = 0;
            SbList = new List<string>();
        }

        public DataString(int SrcIndex)
        {
            Index = SrcIndex;
            SbList = new List<string>();
        }

        public void Add(string SrcSb)
        {
            SbList.Add(SrcSb);
        }
    }

    public class DataStringBuilderList
    {
        public List<DataStringBuilder> dsList { get; private set; }

        public DataStringBuilderList()
        {
            dsList = new List<DataStringBuilder>();
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
            dsList.Add(new DataStringBuilder(dsList.Count - 1));
        }

        public void New(int SrcIndex)
        {
            dsList.Add(new DataStringBuilder(SrcIndex));
        }
    }

    public class DataStringBuilder
    {
        public List<StringBuilder> SbList { get; private set; }
        int Index;

        public DataStringBuilder()
        {
            Index = 0;
            SbList = new List<StringBuilder>();
        }

        public DataStringBuilder(int SrcIndex)
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
