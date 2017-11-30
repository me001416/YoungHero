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
        String FileName;
        //dynamic saveJson;

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
            StringBuilder sb = new StringBuilder();
            string sep = "\t";
            string[] splitContent = SrcStr.Split(sep.ToCharArray());

            foreach(var str in splitContent)
            {
                sb.Append(str);
            }

            MessageBox.Show(sb.ToString(), "FormatDataFile");

            for (var i = 0; i < SrcStr.Length; i++)
            {
                char ch = SrcStr[i];
                
                if(char.IsControl(ch))
                {
                    continue;
                }

                sb.Append(ch);
            }

            //MessageBox.Show(sb.ToString(), "FormatDataFile");

            return;
        }
    }
}
