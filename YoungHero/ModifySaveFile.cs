#define DEBUG_ON
using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace YoungHero
{
    /// <summary>
    /// 修改視窗
    /// </summary>
    public partial class ModifySaveFile : Form
    {
        dynamic saveJson;
        NpcJson gNpcJson;
        NeigongJson gNeigongJson;
        int CurrentNpcID;
        bool gComboBoxFlag;

        #region 早期初始化
        /// <summary>
        /// Constructor Function
        /// </summary>
        public ModifySaveFile()
        {
#if DEBUG_ON
            Trace.WriteLine(DateTime.Now.ToString() + " - ModifySaveFile() - Entry");
            Trace.WriteLine("Non param");
#endif
            InitializeComponent();
        }

        /// <summary>
        /// Main Constructor Function
        /// </summary>
        /// <param name="saveJson">From Save File.</param>
        public ModifySaveFile(ref dynamic saveJson)
        {
#if DEBUG_ON
            Trace.WriteLine(DateTime.Now.ToString() + " - ModifySaveFile(ref dynamic saveJson) - Entry");
#endif
            InitializeComponent();
            this.saveJson = saveJson;
            Initial();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void Initial()
        {
            gNpcJson = new NpcJson();
            gNeigongJson = new NeigongJson();
            CurrentNpcID = 0;
            gComboBoxFlag = false;

            MoneyTextBox.Text = saveJson.m_iMoney;
            AttributePointsTextBox.Text = saveJson.m_iAttributePoints;

            UpdateNpcListBox();
        }

        /// <summary>
        /// 選出要顯示的 NPC
        /// </summary>
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

        /// <summary>
        /// 將 NPC 陳列到 ListBox
        /// </summary>
        /// <param name="SrcId"></param>
        private void InitNpcListBox(int SrcId)
        {
            if (!gNpcJson.CheckJsonDone())
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
        #endregion

        #region ListBox Function
        /// <summary>
        /// 回傳指定 NPC 的 ID
        /// </summary>
        /// <returns></returns>
        private int GetNpcIdFromListBox()
        {
            string selectNpc = NpcListBox.SelectedItem.ToString();
            int IdResult = gNpcJson.ReturnId(selectNpc);

            if (IdResult == 0)
            {
                try
                {
                    IdResult = int.Parse(selectNpc);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }

            return IdResult;
        }

        /// <summary>
        /// 清空 ComboBox，避免 ComboBox 混亂
        /// </summary>
        private void ClearComboBox()
        {
            ComboBox1.Items.Clear();
            ComboBox1.Text = null;
            ComboBox2.Items.Clear();
            ComboBox2.Text = null;
            ComboBox3.Items.Clear();
            ComboBox3.Text = null;
            ComboBox4.Items.Clear();
            ComboBox4.Text = null;
            ComboBox5.Items.Clear();
            ComboBox5.Text = null;
            ComboBox6.Items.Clear();
            ComboBox6.Text = null;
        }

        private void FillOutTextBox(ref dynamic SrcNpc)
        {
            HpTextBox.Text = SrcNpc.iMaxHp;
            SpTextBox.Text = SrcNpc.iMaxSp;

            StrTextBox.Text = SrcNpc.iStr;
            ConTextBox.Text = SrcNpc.iCon;
            IntTextBox.Text = SrcNpc.iInt;
            DexTextBox.Text = SrcNpc.iDex;
            MaxStrTextBox.Text = SrcNpc.iMaxStr;
            MaxConTextBox.Text = SrcNpc.iMaxCon;
            MaxIntTextBox.Text = SrcNpc.iMaxInt;
            MaxDexTextBox.Text = SrcNpc.iMaxDex;

            MoveTextBox.Text = SrcNpc.iMoveStep;

            CriTextBox.Text = SrcNpc.iCri;
            CounterTextBox.Text = SrcNpc.iCounter;
            DodgeTextBox.Text = SrcNpc.iDodge;
            DefendCriTextBox.Text = SrcNpc.iDefendCri;
            DefendCounterTextBox.Text = SrcNpc.iDefendCounter;
            DefendDodgeTextBox.Text = SrcNpc.iDefendDodge;
        }

        /// <summary>
        /// 顯示選擇的 NPC 數據
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NpcListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdResult = GetNpcIdFromListBox();

            gComboBoxFlag = false;

            ClearComboBox();

            foreach (dynamic npc in saveJson.m_NpcList)
            {
                int TempNpcID = npc.iNpcID.ToObject<Int32>();

                if (IdResult == TempNpcID)
                {
                    dynamic PassNpc = npc;
                    FillOutTextBox(ref PassNpc);

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
            int TargetNpcId = 0;

            if(CurrentNpcID == 0)
            {
                return;
            }

            foreach (dynamic npc in saveJson.m_NpcList)
            {
                TargetNpcId = npc.iNpcID.ToObject<Int32>();

                if (TargetNpcId == CurrentNpcID)
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

            if (CurrentNpcID == 0)
            {
                return;
            }

            int TargetNpcId = 0;

            int ComboBox1_ID = 0;
            int ComboBox2_ID = 0;
            int ComboBox3_ID = 0;
            int ComboBox4_ID = 0;
            int ComboBox5_ID = 0;
            int ComboBox6_ID = 0;

            if(ComboBox1.SelectedIndex != -1)
            {
                ComboBox1_ID = gNeigongJson.ReturnId(ComboBox1.Text);
            }

            if (ComboBox2.SelectedIndex != -1)
            {
                ComboBox2_ID = gNeigongJson.ReturnId(ComboBox2.Text);
            }

            if (ComboBox3.SelectedIndex != -1)
            {
                ComboBox3_ID = gNeigongJson.ReturnId(ComboBox3.Text);
            }

            if (ComboBox4.SelectedIndex != -1)
            {
                ComboBox4_ID = gNeigongJson.ReturnId(ComboBox4.Text);
            }

            if (ComboBox5.SelectedIndex != -1)
            {
                ComboBox5_ID = gNeigongJson.ReturnId(ComboBox5.Text);
            }

            if (ComboBox6.SelectedIndex != -1)
            {
                ComboBox6_ID = gNeigongJson.ReturnId(ComboBox6.Text);
            }

            foreach (dynamic npc in saveJson.m_NpcList)
            {
                TargetNpcId = npc.iNpcID.ToObject<Int32>();

                if (TargetNpcId == CurrentNpcID)
                {
                    byte NeigongIndex = 0;

                    foreach (dynamic mNeigong in npc.NeigongList)
                    {
                        NeigongIndex++;

                        switch (NeigongIndex)
                        {
                            case 1:
                                if(ComboBox1_ID == 0)
                                {
                                    continue;
                                }

                                mNeigong.iSkillID = ComboBox1_ID;
                                break;
                            case 2:
                                if (ComboBox2_ID == 0)
                                {
                                    continue;
                                }

                                mNeigong.iSkillID = ComboBox2_ID;
                                break;
                            case 3:
                                if (ComboBox3_ID == 0)
                                {
                                    continue;
                                }

                                mNeigong.iSkillID = ComboBox3_ID;
                                break;
                            case 4:
                                if (ComboBox4_ID == 0)
                                {
                                    continue;
                                }

                                mNeigong.iSkillID = ComboBox4_ID;
                                break;
                            case 5:
                                if (ComboBox5_ID == 0)
                                {
                                    continue;
                                }

                                mNeigong.iSkillID = ComboBox5_ID;
                                break;
                            case 6:
                                if (ComboBox6_ID == 0)
                                {
                                    continue;
                                }

                                mNeigong.iSkillID = ComboBox6_ID;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
    }
}
