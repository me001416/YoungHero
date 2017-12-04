﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using YoungHero.StringManager;

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
            StreamReader SR = new StreamReader(this.FileName, System.Text.Encoding.Default);
            string FileStr = SR.ReadToEnd();
            FormatDataFile(FileStr);
            SR.Close();
        }

        private void FormatDataFile(string SrcStr)
        {
            DataStringBuilderList ds = new DataStringBuilderList();
            StringBuilder sb = new StringBuilder();
            string sep1 = "\n";
            string sep2 = "\t";
            bool IsFirstLine = true;

            for (var i = 0; i < SrcStr.Length; i++)
            {
                string str = StringInfo.GetNextTextElement(SrcStr,i);

                if (str == sep1)
                {
                    IsFirstLine = false;
                    ds.New();
                    continue;
                }

                if (str == sep2)
                {                    
                    ds.Add(sb);
                    sb = new StringBuilder();
                    continue;
                }

                if (!IsFirstLine)
                {
                    sb.Append(str);
                }
            }

            //MessageBox.Show(stringBox, "FormatDataFile");

            sb = new StringBuilder();

            foreach(var x in ds.dsList)
            {
                foreach(var y in x.SbList)
                {
                    sb.Append(y);
                    sb.Append(";");
                }
            }

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
            StringBuilder sb = new StringBuilder();

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
            //await sw.WriteAsync(sb.ToString());
            sw.Close();

            MessageBox.Show("存檔完成", "存檔");
            this.Close();
        }
    }
}
