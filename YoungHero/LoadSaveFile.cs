#define DEBUG_ON
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace YoungHero
{
    /// <summary>
    /// 檔案選擇視窗
    /// </summary>
    public partial class LoadSaveFile : Form
    {
        dynamic saveJson;
        String saveFileName;

        /// <summary>
        /// Main Constructor Function
        /// </summary>
        public LoadSaveFile()
        {
#if DEBUG_ON
            Trace.WriteLine(DateTime.Now.ToString() + " - LoadSaveFile - Entry");
#endif
            InitializeComponent();
        }

        /// <summary>
        /// 檔案瀏覽
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
#if DEBUG_ON
            Trace.WriteLine("LoadSaveFile::button1_Click - Entry");
#endif
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Filter = "Save File|*.Save";
            ofg.InitialDirectory = Properties.Settings.Default.pathName;
            ofg.Multiselect = false;
            ofg.ShowDialog();
            saveFileName = ofg.FileName;
            textBox1.Text = ofg.FileName;

            if(string.IsNullOrEmpty(saveFileName))
            {
                return;
            }

            FileInfo fi = new FileInfo(ofg.FileName);
            Properties.Settings.Default.pathName = fi.DirectoryName;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 開啟修改視窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button2_Click(object sender, EventArgs e)
        {
#if DEBUG_ON
            Trace.WriteLine("LoadSaveFile::button2_Click - Entry");
#endif
            if (string.IsNullOrEmpty(saveFileName))
            {
                return;
            }

            await Task.Run(() => SaveLoad());

            ModifySaveFile msf = new ModifySaveFile(ref saveJson);
            msf.Top = Top;
            msf.Left = Left;
            msf.ShowDialog();
        }

        /// <summary>
        /// 離開
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
#if DEBUG_ON
            Trace.WriteLine("LoadSaveFile::button3_Click - Entry");
#endif
            Close();
        }

        /// <summary>
        /// 透過 StreamReader 讀取指定檔案
        /// </summary>
        private void SaveLoad()
        {
            StreamReader saveSR = new StreamReader(saveFileName, System.Text.Encoding.Default);
            string saveStr = saveSR.ReadToEnd();
            saveJson = JsonConvert.DeserializeObject(saveStr);
            saveSR.Close();
        }
    }
}
