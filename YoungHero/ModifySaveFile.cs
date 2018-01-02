using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace YoungHero
{
    public partial class ModifySaveFile : Form
    {
        dynamic saveJson;
        NpcJson gNpcJson;
        NeigongJson gNeigongJson;
        int CurrentNpcID;
        bool gComboBoxFlag;

        #region 建構函數
        public ModifySaveFile()
        {
            InitializeComponent();
        }

        public ModifySaveFile(ref dynamic saveJson)
        {            
            InitializeComponent();
            this.saveJson = saveJson;
            Initial();
        }
        #endregion

        private void Initial()
        {
            gNpcJson = new NpcJson();
            gNeigongJson = new NeigongJson();
            CurrentNpcID = 0;
            gComboBoxFlag = false;

            this.MoneyTextBox.Text = saveJson.m_iMoney;
            this.AttributePointsTextBox.Text = saveJson.m_iAttributePoints;

            UpdateNpcListBox();
        }

        #region ListBox Function
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
            if(!gNpcJson.CheckJsonDone())
            {
                MessageBox.Show("JsonDone was false", "Warning");
            }

            if (gNpcJson.IsPresent(SrcId))
            {
                NpcListBox.Items.Add($"{gNpcJson.ReturnName(SrcId)}");
            }
            else
            {
                NpcListBox.Items.Add($"{SrcId}");
            }
        }

        private void ClearComboBox()
        {
            ComboBox1.Items.Clear();
            ComboBox2.Items.Clear();
            ComboBox3.Items.Clear();
            ComboBox4.Items.Clear();
            ComboBox5.Items.Clear();
            ComboBox6.Items.Clear();

            ComboBox1.SelectedIndex = -1;
            ComboBox2.SelectedIndex = -1;
            ComboBox3.SelectedIndex = -1;
            ComboBox4.SelectedIndex = -1;
            ComboBox5.SelectedIndex = -1;
            ComboBox6.SelectedIndex = -1;
        }

        private void NpcListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectNpc = NpcListBox.SelectedItem.ToString();
            int IdResult = gNpcJson.ReturnId(selectNpc);

            if (IdResult == 0)
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

            //ClearComboBox();

            gComboBoxFlag = false;

            foreach (dynamic npc in saveJson.m_NpcList)
            {
                int TempNpcID = npc.iNpcID.ToObject<Int32>();

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

                    MoveTextBox.Text = npc.iMoveStep;

                    CriTextBox.Text = npc.iCri;
                    CounterTextBox.Text = npc.iCounter;
                    DodgeTextBox.Text = npc.iDodge;
                    DefendCriTextBox.Text = npc.iDefendCri;
                    DefendCounterTextBox.Text = npc.iDefendCounter;
                    DefendDodgeTextBox.Text = npc.iDefendDodge;

                    ClearComboBox();

                    for (int NIndex = 0; NIndex < gNeigongJson.Length; NIndex++)
                    {
                        ComboBox1.Items.Add($"{gNeigongJson.GetNameByIndex(NIndex)}");
                        ComboBox2.Items.Add($"{gNeigongJson.GetNameByIndex(NIndex)}");
                        ComboBox3.Items.Add($"{gNeigongJson.GetNameByIndex(NIndex)}");
                        ComboBox4.Items.Add($"{gNeigongJson.GetNameByIndex(NIndex)}");
                        ComboBox5.Items.Add($"{gNeigongJson.GetNameByIndex(NIndex)}");
                        ComboBox6.Items.Add($"{gNeigongJson.GetNameByIndex(NIndex)}");
                    }

                    byte NeigongIndex = 0;

                    foreach (dynamic mNeigong in npc.NeigongList)
                    {
                        string TempStr = mNeigong.iSkillID;
                        int TempNeigongIndex = gNeigongJson.GetIndexByID(TempStr);

                        switch (NeigongIndex)
                        {
                            case 0:
                                ComboBox1.SelectedIndex = TempNeigongIndex;
                                break;
                            case 1:
                                ComboBox2.SelectedIndex = TempNeigongIndex;
                                break;
                            case 2:
                                ComboBox3.SelectedIndex = TempNeigongIndex;
                                break;
                            case 3:
                                ComboBox4.SelectedIndex = TempNeigongIndex;
                                break;
                            case 4:
                                ComboBox5.SelectedIndex = TempNeigongIndex;
                                break;
                            case 5:
                                ComboBox6.SelectedIndex = TempNeigongIndex;
                                break;
                            default:
                                break;
                        }

                        NeigongIndex++;
                    }

                    CurrentNpcID = IdResult;
                }
            }

            gComboBoxFlag = true;
        }
        #endregion

        #region Button Evnet
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
        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateNpcListBox();
        }

        #region TextBox Evnet
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox_Group1_Leave(object sender, EventArgs e)
        {
            saveJson.m_iMoney = this.MoneyTextBox.Text;
            saveJson.m_iAttributePoints = this.AttributePointsTextBox.Text;
        }

        private void TextBox_Group2_Leave(object sender, EventArgs e)
        {
            int PointNpcId = 0;

            if(CurrentNpcID == 0)
            {
                return;
            }

            foreach (dynamic npc in saveJson.m_NpcList)
            {
                PointNpcId = npc.iNpcID.ToObject<Int32>();

                if (PointNpcId == CurrentNpcID)
                {
                    npc.iMaxHp = HpTextBox.Text;
                    npc.iMaxSp = SpTextBox.Text;

                    npc.iStr = StrTextBox.Text;
                    npc.iCon = ConTextBox.Text;
                    npc.iInt = IntTextBox.Text;
                    npc.iDex = DexTextBox.Text;
                    npc.iMaxStr = MaxStrTextBox.Text;
                    npc.iMaxCon = MaxConTextBox.Text;
                    npc.iMaxInt = MaxIntTextBox.Text;
                    npc.iMaxDex = MaxDexTextBox.Text;

                    npc.iMoveStep = MoveTextBox.Text;

                    npc.iCri = CriTextBox.Text;
                    npc.iCounter = CounterTextBox.Text;
                    npc.iDodge = DodgeTextBox.Text;
                    npc.iDefendCri = DefendCriTextBox.Text;
                    npc.iDefendCounter = DefendCounterTextBox.Text;
                    npc.iDefendDodge = DefendDodgeTextBox.Text;
                }
            }
        }
        #endregion

        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            if(!gComboBoxFlag)
            {
                return;
            }

            int a = ComboBox1.SelectedIndex;
            int b = ComboBox2.SelectedIndex;
            int c = ComboBox3.SelectedIndex;
            int d = ComboBox4.SelectedIndex;
            if(d == -1)
            {
                b = b - 1;
            }
            int E = ComboBox5.SelectedIndex;
            int f = ComboBox6.SelectedIndex;
        }
    }
}
