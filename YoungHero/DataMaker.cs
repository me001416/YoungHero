using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using YoungHero.StringManager;

namespace YoungHero
{
    /// <summary>
    /// 製作程式使用的資料
    /// </summary>
    public partial class DataMaker : Form
    {
        string FileName;
        string sStr;
        byte SelectMode;

        /// <summary>
        /// Constructor Function
        /// </summary>
        public DataMaker()
        {
            InitializeComponent();
            Initial();
        }

        /// <summary>
        /// 初始化 ComboBox
        /// </summary>
        private void Initial()
        {
            SelectModeComboBox.Items.Add("Neigong");
            SelectModeComboBox.Items.Add("NPC");
            SelectModeComboBox.Items.Add("Item");
        }

        #region Button Evnet
        /// <summary>
        /// 開啟並選擇檔案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.InitialDirectory = Properties.Settings.Default.dataPathName;
            ofg.Multiselect = false;
            ofg.ShowDialog();
            FileName = ofg.FileName;
            textBox1.Text = ofg.FileName;

            if (string.IsNullOrEmpty(FileName))
            {
                return;
            }

            FileInfo fi = new FileInfo(ofg.FileName);
            Properties.Settings.Default.dataPathName = fi.DirectoryName;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 確認輸入檔案以及選擇模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button2_Click(object sender, EventArgs e)
        {
            string SelectModeStr;

            if (string.IsNullOrEmpty(this.FileName))
            {
                return;
            }

            SelectModeStr = SelectModeComboBox.SelectedItem.ToString();

            switch (SelectModeStr)
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

            await Task.Run(() => this.FileLoad());
        }

        /// <summary>
        /// 存檔
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            StreamWriter sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.Default);

            await sw.WriteAsync(sStr);
            sw.Close();

            MessageBox.Show("存檔完成", "存檔");
            this.Close();
        }
        #endregion

        private void FileLoad()
        {
            StreamReader SR = new StreamReader(this.FileName, System.Text.Encoding.Default);
            string FileStr = SR.ReadToEnd();
            FilterFileData(FileStr);
            SR.Close();
        }

        private void FilterFileData(string SrcStr)
        {
            YoungHeroDSBL YHdsbl = new YoungHeroDSBL();
            StringBuilder sb = new StringBuilder();
            string sep1 = "\n";
            string sep2 = "\t";
            string sep3 = "\r";
            bool IsFirstLine = true;

            for (var i = 0; i < SrcStr.Length; i++)
            {
                string str = StringInfo.GetNextTextElement(SrcStr,i);

                if (str == sep2)
                {
                    if (!IsFirstLine)
                    {
                        YHdsbl.Add(sb);
                        sb = new StringBuilder();
                    }
                    continue;
                }

                if (str == sep1)
                {
                    IsFirstLine = false;

                    YHdsbl.Add(sb);
                    sb = new StringBuilder();

                    YHdsbl.New();

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

                if(i == SrcStr.Length - 1)
                {
                    sb = new StringBuilder();
                    sb.Append(str);
                    YHdsbl.Add(sb);
                }
            }

            sStr = YHdsbl.FormatFileData(SelectMode);

            return;
        }
    }
}
