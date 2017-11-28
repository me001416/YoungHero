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
            this.NpcTabPage = new System.Windows.Forms.TabPage();
            this.ItemTabPage = new System.Windows.Forms.TabPage();
            this.NpcListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.NpcTabPage.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.NpcTabPage);
            this.tabControl1.Controls.Add(this.ItemTabPage);
            this.tabControl1.Location = new System.Drawing.Point(29, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 363);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // NpcTabPage
            // 
            this.NpcTabPage.Controls.Add(this.NpcListBox);
            this.NpcTabPage.Location = new System.Drawing.Point(4, 22);
            this.NpcTabPage.Name = "NpcTabPage";
            this.NpcTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.NpcTabPage.Size = new System.Drawing.Size(644, 337);
            this.NpcTabPage.TabIndex = 0;
            this.NpcTabPage.Text = "NPC";
            this.NpcTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemTabPage
            // 
            this.ItemTabPage.Location = new System.Drawing.Point(4, 22);
            this.ItemTabPage.Name = "ItemTabPage";
            this.ItemTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemTabPage.Size = new System.Drawing.Size(644, 337);
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
            this.NpcListBox.Size = new System.Drawing.Size(120, 316);
            this.NpcListBox.TabIndex = 8;
            // 
            // ModifySaveFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 495);
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
            this.NpcTabPage.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage NpcTabPage;
        private System.Windows.Forms.TabPage ItemTabPage;
        private System.Windows.Forms.ListBox NpcListBox;
    }
}