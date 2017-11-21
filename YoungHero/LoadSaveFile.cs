using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace YoungHero
{
    public partial class LoadSaveFile : Form
    {
        String saveFileName;

        public LoadSaveFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Filter = "Save File|*.Save";
            ofg.InitialDirectory = Properties.Settings.Default.pathName;
            ofg.Multiselect = false;
            ofg.ShowDialog();
            this.saveFileName = ofg.FileName;
            this.textBox1.Text = ofg.FileName;

            if(string.IsNullOrEmpty(this.saveFileName))
            {
                return;
            }

            FileInfo fi = new FileInfo(ofg.FileName);
            Properties.Settings.Default.pathName = fi.DirectoryName;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
