using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace YoungHero
{
    public partial class ModifySaveFile : Form
    {
        dynamic saveJson;
        NpcList npcList;
        int TempNpcID;

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
            npcList = new NpcList();

            this.MoneyTextBox.Text = saveJson.m_iMoney;
            this.AttributePointsTextBox.Text = saveJson.m_iAttributePoints;

            UpdateNpcListBox();
        }

        private void UpdateNpcListBox()
        {
            NpcListBox.Items.Clear();

            foreach (dynamic npc in saveJson.m_NpcList)
            {
                if (checkBox1.Checked)
                {
                    if (npc.NpcType == 1)
                    {
                        int npcID = npc.iNpcID.ToObject<Int32>();

                        InitNpcListBox(npcID);
                    }
                }
                else
                {
                    int npcID = npc.iNpcID.ToObject<Int32>();

                    InitNpcListBox(npcID);
                }
            }
        }

        private void InitNpcListBox(int SrcId)
        {
            if (npcList.IsPresent(SrcId))
            {
                NpcListBox.Items.Add($"{npcList.ReturnName(SrcId)}");
            }
            else
            {
                NpcListBox.Items.Add($"{SrcId}");
            }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNpcListBox();
        }

        private void NpcListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectNpc = NpcListBox.SelectedItem.ToString();
            int IdResult = npcList.ReturnId(selectNpc);

            if(IdResult == 0)
            {
                try
                {
                    IdResult = Int32.Parse(selectNpc);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }

            foreach (dynamic npc in saveJson.m_NpcList)
            {
                TempNpcID = npc.iNpcID.ToObject<Int32>();

                if (IdResult == TempNpcID)
                {
                    HpTextBox.Text = npc.iMaxHp;
                    SpTextBox.Text = npc.iMaxSp;
                    StrTextBox.Text = npc.iStr;
                    ConTextBox.Text = npc.iCon;
                    IntTextBox.Text = npc.iInt;
                    DexTextBox.Text = npc.iDex;
                    MaxStrTextBox.Text = npc.iMaxStr;
                    MaxConTextBox.Text = npc.iMaxCon;
                    MaxIntTextBox.Text = npc.iMaxInt;
                    MaxDexTextBox.Text = npc.iMaxDex;
                }
            }
        }

        private void MoneyTextBox_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("Leave", "MoneyTextBox_Leave");
            //MessageBox.Show(sender.Equals, "MoneyTextBox_Leave");
            //MessageBox.Show(e., "MoneyTextBox_Leave");
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString(), "TextBox_KeyPress");
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
