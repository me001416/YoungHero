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
            InitializeComponent();
#if DEBUG_ON
            Trace.WriteLine("MainForm - Entry");
#endif
        }

        /// <summary>
        /// 前往修改頁面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
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
            Application.Exit();
        }

        /// <summary>
        /// 針對遊戲資料製做 Json File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            DataMaker dmk = new DataMaker();
            dmk.Top = Top;
            dmk.Left = Left;
            dmk.ShowDialog();
        }
    }
}
