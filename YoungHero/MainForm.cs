#define DEBUG_ON
using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace YoungHero
{
    /// <summary>
    /// 起始視窗
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Main Constructor Function
        /// </summary>
        public MainForm()
        {
#if DEBUG_ON
            Trace.WriteLine(DateTime.Now.ToString() + " - MainForm - Entry");
#endif
            InitializeComponent();
        }

        /// <summary>
        /// 前往修改頁面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
#if DEBUG_ON
            Trace.WriteLine(DateTime.Now.ToString() + "- MainForm::button1_Click - Entry");
#endif
            LoadSaveFile formLSF = new LoadSaveFile();
            formLSF.Top = Top;
            formLSF.Left = Left + (Width / 3);
            formLSF.ShowDialog();
        }

        /// <summary>
        /// 離開
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
#if DEBUG_ON
            Trace.WriteLine("MainForm::button2_Click - Entry");
#endif
            Application.Exit();
        }

        /// <summary>
        /// 針對遊戲資料製做 Json File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
#if DEBUG_ON
            Trace.WriteLine("MainForm::button3_Click - Entry");
#endif
            DataMaker dmk = new DataMaker();
            dmk.Top = Top;
            dmk.Left = Left;
            dmk.ShowDialog();
        }
    }
}
