namespace YoungHero
{
    partial class ModifySaveFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.MoneyTextBox = new System.Windows.Forms.TextBox();
            this.AttributePointsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.confrimButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.s = new System.Windows.Forms.TabPage();
            this.ItemTabPage = new System.Windows.Forms.TabPage();
            this.NpcListBox = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SpTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HpTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StrTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DexTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MaxDexTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MaxIntTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MaxConTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MaxStrTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.s.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label.Location = new System.Drawing.Point(26, 24);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(40, 16);
            this.label.TabIndex = 1;
            this.label.Text = "金錢";
            // 
            // MoneyTextBox
            // 
            this.MoneyTextBox.Location = new System.Drawing.Point(84, 24);
            this.MoneyTextBox.Name = "MoneyTextBox";
            this.MoneyTextBox.Size = new System.Drawing.Size(100, 22);
            this.MoneyTextBox.TabIndex = 2;
            // 
            // AttributePointsTextBox
            // 
            this.AttributePointsTextBox.Location = new System.Drawing.Point(84, 52);
            this.AttributePointsTextBox.Name = "AttributePointsTextBox";
            this.AttributePointsTextBox.Size = new System.Drawing.Size(100, 22);
            this.AttributePointsTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(26, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "閱歷";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(719, 24);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "返回";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // confrimButton
            // 
            this.confrimButton.Location = new System.Drawing.Point(719, 79);
            this.confrimButton.Name = "confrimButton";
            this.confrimButton.Size = new System.Drawing.Size(75, 23);
            this.confrimButton.TabIndex = 6;
            this.confrimButton.Text = "確認";
            this.confrimButton.UseVisualStyleBackColor = true;
            this.confrimButton.Click += new System.EventHandler(this.confrimButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.s);
            this.tabControl1.Controls.Add(this.ItemTabPage);
            this.tabControl1.Location = new System.Drawing.Point(29, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 455);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // s
            // 
            this.s.Controls.Add(this.MaxDexTextBox);
            this.s.Controls.Add(this.label8);
            this.s.Controls.Add(this.MaxIntTextBox);
            this.s.Controls.Add(this.label9);
            this.s.Controls.Add(this.MaxConTextBox);
            this.s.Controls.Add(this.label10);
            this.s.Controls.Add(this.MaxStrTextBox);
            this.s.Controls.Add(this.label11);
            this.s.Controls.Add(this.DexTextBox);
            this.s.Controls.Add(this.label6);
            this.s.Controls.Add(this.IntTextBox);
            this.s.Controls.Add(this.label7);
            this.s.Controls.Add(this.ConTextBox);
            this.s.Controls.Add(this.label4);
            this.s.Controls.Add(this.StrTextBox);
            this.s.Controls.Add(this.label5);
            this.s.Controls.Add(this.SpTextBox);
            this.s.Controls.Add(this.checkBox1);
            this.s.Controls.Add(this.label2);
            this.s.Controls.Add(this.NpcListBox);
            this.s.Controls.Add(this.HpTextBox);
            this.s.Controls.Add(this.label3);
            this.s.Location = new System.Drawing.Point(4, 22);
            this.s.Name = "s";
            this.s.Padding = new System.Windows.Forms.Padding(3);
            this.s.Size = new System.Drawing.Size(644, 429);
            this.s.TabIndex = 0;
            this.s.Text = "NPC";
            this.s.UseVisualStyleBackColor = true;
            // 
            // ItemTabPage
            // 
            this.ItemTabPage.Location = new System.Drawing.Point(4, 22);
            this.ItemTabPage.Name = "ItemTabPage";
            this.ItemTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemTabPage.Size = new System.Drawing.Size(644, 429);
            this.ItemTabPage.TabIndex = 1;
            this.ItemTabPage.Text = "ITEM";
            this.ItemTabPage.UseVisualStyleBackColor = true;
            // 
            // NpcListBox
            // 
            this.NpcListBox.FormattingEnabled = true;
            this.NpcListBox.ItemHeight = 12;
            this.NpcListBox.Location = new System.Drawing.Point(518, 6);
            this.NpcListBox.Name = "NpcListBox";
            this.NpcListBox.Size = new System.Drawing.Size(120, 400);
            this.NpcListBox.TabIndex = 8;
            this.NpcListBox.SelectedIndexChanged += new System.EventHandler(this.NpcListBox_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "只有隊友";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SpTextBox
            // 
            this.SpTextBox.Location = new System.Drawing.Point(66, 78);
            this.SpTextBox.Name = "SpTextBox";
            this.SpTextBox.Size = new System.Drawing.Size(100, 22);
            this.SpTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "內力";
            // 
            // HpTextBox
            // 
            this.HpTextBox.Location = new System.Drawing.Point(66, 50);
            this.HpTextBox.Name = "HpTextBox";
            this.HpTextBox.Size = new System.Drawing.Size(100, 22);
            this.HpTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "體力";
            // 
            // ConTextBox
            // 
            this.ConTextBox.Location = new System.Drawing.Point(66, 131);
            this.ConTextBox.Name = "ConTextBox";
            this.ConTextBox.Size = new System.Drawing.Size(100, 22);
            this.ConTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "根骨";
            // 
            // StrTextBox
            // 
            this.StrTextBox.Location = new System.Drawing.Point(66, 103);
            this.StrTextBox.Name = "StrTextBox";
            this.StrTextBox.Size = new System.Drawing.Size(100, 22);
            this.StrTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "臂力";
            // 
            // DexTextBox
            // 
            this.DexTextBox.Location = new System.Drawing.Point(66, 187);
            this.DexTextBox.Name = "DexTextBox";
            this.DexTextBox.Size = new System.Drawing.Size(100, 22);
            this.DexTextBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(6, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "身法";
            // 
            // IntTextBox
            // 
            this.IntTextBox.Location = new System.Drawing.Point(66, 159);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.Size = new System.Drawing.Size(100, 22);
            this.IntTextBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(6, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "悟性";
            // 
            // MaxDexTextBox
            // 
            this.MaxDexTextBox.Location = new System.Drawing.Point(250, 187);
            this.MaxDexTextBox.Name = "MaxDexTextBox";
            this.MaxDexTextBox.Size = new System.Drawing.Size(100, 22);
            this.MaxDexTextBox.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(172, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "身法上限";
            // 
            // MaxIntTextBox
            // 
            this.MaxIntTextBox.Location = new System.Drawing.Point(250, 159);
            this.MaxIntTextBox.Name = "MaxIntTextBox";
            this.MaxIntTextBox.Size = new System.Drawing.Size(100, 22);
            this.MaxIntTextBox.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(172, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "悟性上限";
            // 
            // MaxConTextBox
            // 
            this.MaxConTextBox.Location = new System.Drawing.Point(250, 131);
            this.MaxConTextBox.Name = "MaxConTextBox";
            this.MaxConTextBox.Size = new System.Drawing.Size(100, 22);
            this.MaxConTextBox.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(172, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "根骨上限";
            // 
            // MaxStrTextBox
            // 
            this.MaxStrTextBox.Location = new System.Drawing.Point(250, 103);
            this.MaxStrTextBox.Name = "MaxStrTextBox";
            this.MaxStrTextBox.Size = new System.Drawing.Size(100, 22);
            this.MaxStrTextBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(172, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "臂力上限";
            // 
            // ModifySaveFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 560);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.confrimButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.AttributePointsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoneyTextBox);
            this.Controls.Add(this.label);
            this.Name = "ModifySaveFile";
            this.Text = "ModifySaveFile";
            this.tabControl1.ResumeLayout(false);
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox MoneyTextBox;
        private System.Windows.Forms.TextBox AttributePointsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button confrimButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage s;
        private System.Windows.Forms.TabPage ItemTabPage;
        private System.Windows.Forms.ListBox NpcListBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox ConTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StrTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SpTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HpTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DexTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IntTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MaxDexTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MaxIntTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MaxConTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MaxStrTextBox;
        private System.Windows.Forms.Label label11;
    }
}