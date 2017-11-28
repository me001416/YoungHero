using System;
using System.Windows.Forms;

namespace YoungHero
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadSaveFile formLSF = new LoadSaveFile();
            formLSF.Top = this.Top;
            formLSF.Left = this.Left + (this.Width / 3);
            formLSF.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
