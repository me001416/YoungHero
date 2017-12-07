using System;
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
            Initial();
        }

        private void Initial()
        {
            SelectModeComboBox.Items.Add("Neigong");
            SelectModeComboBox.Items.Add("NPC");
            SelectModeComboBox.Items.Add("Item");
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
            FilterFileData(FileStr);
            SR.Close();
        }

        private void FilterFileData(string SrcStr)
        {
            DataStringBuilderList ds = new DataStringBuilderList();
            StringBuilder sb = new StringBuilder();
            string sep1 = "\n";
            string sep2 = "\t";
            string sep3 = "\r";
            bool IsFirstLine = true;
            byte SelectMode = 0;

            for (var i = 0; i < SrcStr.Length; i++)
            {
                string str = StringInfo.GetNextTextElement(SrcStr,i);

                if (str == sep2)
                {
                    if (!IsFirstLine)
                    {
                        ds.Add(sb);
                        sb = new StringBuilder();
                    }
                    continue;
                }

                if (str == sep1)
                {
                    IsFirstLine = false;

                    ds.Add(sb);
                    sb = new StringBuilder();

                    ds.New();

                    continue;
                }

                if(str == sep3)
                {
                    continue;
                }

                if (!IsFirstLine)
                {
                    sb.Append(str);
                }
            }

            switch (SelectModeComboBox.SelectedItem.ToString())
            {
                case "Neigong":
                    SelectMode = 1;
                    break;
                case "NPC":
                    SelectMode = 2;
                    break;
                case "Item":
                    SelectMode = 3;
                    break;
                default:
                    MessageBox.Show("請選擇使用模式", "Error");                    
                    return;
            }

            sStr = ds.FormatFileData(SelectMode);

            return;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            StringBuilder sb = new StringBuilder();

            sfd.Filter = "Txt File|*.txt";

            if (Directory.Exists(Application.StartupPath + @"\Data"))
            {
                sfd.InitialDirectory = Application.StartupPath + @"\Data";
            }
            else
            {
                sfd.InitialDirectory = Properties.Settings.Default.dataPathName;
            }

            sfd.ShowDialog();

            if (string.IsNullOrEmpty(sfd.FileName))
            {
                return;
            }

            if (string.IsNullOrEmpty(sStr))
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
}
