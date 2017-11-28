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
using Newtonsoft.Json.Linq;
using System.IO;

namespace YoungHero
{
    public partial class ModifySaveFile : Form
    {
        dynamic saveJson;
        JArray teamList;

        public ModifySaveFile()
        {
            InitializeComponent();
        }

        public ModifySaveFile(ref dynamic saveJson)
        {            
            InitializeComponent();
            this.saveJson = saveJson;
            this.Initial();
        }

        private void Initial()
        {
            this.MoneyTextBox.Text = saveJson.m_iMoney;
            this.AttributePointsTextBox.Text = saveJson.m_iAttributePoints;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要離開嗎?", "離開", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private async void confrimButton_Click(object sender, EventArgs e)
        {
            saveJson.m_iMoney = this.MoneyTextBox.Text;
            saveJson.m_iAttributePoints = this.AttributePointsTextBox.Text;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Save File|*.Save";
            sfd.InitialDirectory = Properties.Settings.Default.pathName;
            sfd.ShowDialog();

            if(string.IsNullOrEmpty(sfd.FileName))
            {
                return;
            }

            StreamWriter sw = new StreamWriter(sfd.FileName);

            await sw.WriteAsync(JsonConvert.SerializeObject(saveJson));
            sw.Close();

            MessageBox.Show("存檔完成", "存檔");
            this.Close();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (tabControl1.TabPages[e.TabPageIndex].Name)
            {
                case "NpcTabPage":
                    NpcListBox.Visible = true;
                    break;
                default:
                    NpcListBox.Visible = false;
                    break;
            }
        }
    }
}
