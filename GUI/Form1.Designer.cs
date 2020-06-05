namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.osBox = new System.Windows.Forms.GroupBox();
            this.buttonPatch = new System.Windows.Forms.Button();
            this.radioWin10 = new System.Windows.Forms.RadioButton();
            this.radioWin7 = new System.Windows.Forms.RadioButton();
            this.featureBox = new System.Windows.Forms.GroupBox();
            this.checkBoxDeathRun = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoReady = new System.Windows.Forms.CheckBox();
            this.checkBoxAntiAFK = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStartDelay = new System.Windows.Forms.ComboBox();
            this.textBoxHeadPos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxDoubleFire = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxWeapon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxShootDelay = new System.Windows.Forms.TextBox();
            this.checkBoxFarm = new System.Windows.Forms.CheckBox();
            this.checkBoxStart = new System.Windows.Forms.CheckBox();
            this.checkBoxSniper = new System.Windows.Forms.CheckBox();
            this.checkBoxDebug = new System.Windows.Forms.CheckBox();
            this.osBox.SuspendLayout();
            this.featureBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // osBox
            // 
            this.osBox.Controls.Add(this.buttonPatch);
            this.osBox.Controls.Add(this.radioWin10);
            this.osBox.Controls.Add(this.radioWin7);
            this.osBox.Location = new System.Drawing.Point(18, 17);
            this.osBox.Margin = new System.Windows.Forms.Padding(4);
            this.osBox.Name = "osBox";
            this.osBox.Padding = new System.Windows.Forms.Padding(4);
            this.osBox.Size = new System.Drawing.Size(162, 152);
            this.osBox.TabIndex = 0;
            this.osBox.TabStop = false;
            this.osBox.Text = "Select OS";
            // 
            // buttonPatch
            // 
            this.buttonPatch.Location = new System.Drawing.Point(81, 112);
            this.buttonPatch.Name = "buttonPatch";
            this.buttonPatch.Size = new System.Drawing.Size(75, 27);
            this.buttonPatch.TabIndex = 1;
            this.buttonPatch.Text = "Patch";
            this.buttonPatch.UseVisualStyleBackColor = true;
            this.buttonPatch.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // radioWin10
            // 
            this.radioWin10.AutoSize = true;
            this.radioWin10.Location = new System.Drawing.Point(7, 52);
            this.radioWin10.Name = "radioWin10";
            this.radioWin10.Size = new System.Drawing.Size(108, 22);
            this.radioWin10.TabIndex = 1;
            this.radioWin10.TabStop = true;
            this.radioWin10.Text = "Windows 10";
            this.radioWin10.UseVisualStyleBackColor = true;
            // 
            // radioWin7
            // 
            this.radioWin7.AutoSize = true;
            this.radioWin7.Location = new System.Drawing.Point(7, 24);
            this.radioWin7.Name = "radioWin7";
            this.radioWin7.Size = new System.Drawing.Size(100, 22);
            this.radioWin7.TabIndex = 0;
            this.radioWin7.TabStop = true;
            this.radioWin7.Text = "Windows 7";
            this.radioWin7.UseVisualStyleBackColor = true;
            // 
            // featureBox
            // 
            this.featureBox.Controls.Add(this.checkBoxDeathRun);
            this.featureBox.Controls.Add(this.checkBoxAutoReady);
            this.featureBox.Controls.Add(this.checkBoxAntiAFK);
            this.featureBox.Location = new System.Drawing.Point(18, 176);
            this.featureBox.Name = "featureBox";
            this.featureBox.Size = new System.Drawing.Size(162, 115);
            this.featureBox.TabIndex = 2;
            this.featureBox.TabStop = false;
            this.featureBox.Text = "Cow Features";
            // 
            // checkBoxDeathRun
            // 
            this.checkBoxDeathRun.AutoSize = true;
            this.checkBoxDeathRun.Location = new System.Drawing.Point(7, 82);
            this.checkBoxDeathRun.Name = "checkBoxDeathRun";
            this.checkBoxDeathRun.Size = new System.Drawing.Size(111, 22);
            this.checkBoxDeathRun.TabIndex = 2;
            this.checkBoxDeathRun.Text = "Run to death";
            this.checkBoxDeathRun.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoReady
            // 
            this.checkBoxAutoReady.AutoSize = true;
            this.checkBoxAutoReady.Location = new System.Drawing.Point(7, 56);
            this.checkBoxAutoReady.Name = "checkBoxAutoReady";
            this.checkBoxAutoReady.Size = new System.Drawing.Size(103, 22);
            this.checkBoxAutoReady.TabIndex = 1;
            this.checkBoxAutoReady.Text = "Auto Ready";
            this.checkBoxAutoReady.UseVisualStyleBackColor = true;
            // 
            // checkBoxAntiAFK
            // 
            this.checkBoxAntiAFK.AutoSize = true;
            this.checkBoxAntiAFK.Location = new System.Drawing.Point(7, 28);
            this.checkBoxAntiAFK.Name = "checkBoxAntiAFK";
            this.checkBoxAntiAFK.Size = new System.Drawing.Size(84, 22);
            this.checkBoxAntiAFK.TabIndex = 0;
            this.checkBoxAntiAFK.Text = "Anti-AFK";
            this.checkBoxAntiAFK.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(18, 297);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(404, 27);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxDebug);
            this.groupBox1.Controls.Add(this.checkBoxSniper);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxStartDelay);
            this.groupBox1.Controls.Add(this.textBoxHeadPos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBoxDoubleFire);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxWeapon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxShootDelay);
            this.groupBox1.Controls.Add(this.checkBoxFarm);
            this.groupBox1.Controls.Add(this.checkBoxStart);
            this.groupBox1.Location = new System.Drawing.Point(187, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 274);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Host Features";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Start Waittime:";
            // 
            // comboBoxStartDelay
            // 
            this.comboBoxStartDelay.FormattingEnabled = true;
            this.comboBoxStartDelay.Items.AddRange(new object[] {
            "10000",
            "15000",
            "20000"});
            this.comboBoxStartDelay.Location = new System.Drawing.Point(116, 78);
            this.comboBoxStartDelay.Name = "comboBoxStartDelay";
            this.comboBoxStartDelay.Size = new System.Drawing.Size(113, 26);
            this.comboBoxStartDelay.TabIndex = 13;
            this.comboBoxStartDelay.Text = "15000";
            // 
            // textBoxHeadPos
            // 
            this.textBoxHeadPos.Location = new System.Drawing.Point(140, 203);
            this.textBoxHeadPos.Name = "textBoxHeadPos";
            this.textBoxHeadPos.Size = new System.Drawing.Size(89, 24);
            this.textBoxHeadPos.TabIndex = 12;
            this.textBoxHeadPos.Text = "-15,-10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Headshot: x,y";
            // 
            // checkBoxDoubleFire
            // 
            this.checkBoxDoubleFire.AutoSize = true;
            this.checkBoxDoubleFire.Location = new System.Drawing.Point(126, 175);
            this.checkBoxDoubleFire.Name = "checkBoxDoubleFire";
            this.checkBoxDoubleFire.Size = new System.Drawing.Size(103, 22);
            this.checkBoxDoubleFire.TabIndex = 8;
            this.checkBoxDoubleFire.Text = "Double Fire";
            this.checkBoxDoubleFire.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Use Weapon: ";
            // 
            // comboBoxWeapon
            // 
            this.comboBoxWeapon.FormattingEnabled = true;
            this.comboBoxWeapon.Items.AddRange(new object[] {
            "Primary",
            "Secondary",
            "Knife"});
            this.comboBoxWeapon.Location = new System.Drawing.Point(116, 113);
            this.comboBoxWeapon.Name = "comboBoxWeapon";
            this.comboBoxWeapon.Size = new System.Drawing.Size(113, 26);
            this.comboBoxWeapon.TabIndex = 5;
            this.comboBoxWeapon.Text = "Primary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Shoot Delay (ms):";
            // 
            // textBoxShootDelay
            // 
            this.textBoxShootDelay.Location = new System.Drawing.Point(140, 145);
            this.textBoxShootDelay.Name = "textBoxShootDelay";
            this.textBoxShootDelay.Size = new System.Drawing.Size(89, 24);
            this.textBoxShootDelay.TabIndex = 3;
            this.textBoxShootDelay.Text = "6000";
            // 
            // checkBoxFarm
            // 
            this.checkBoxFarm.AutoSize = true;
            this.checkBoxFarm.Location = new System.Drawing.Point(9, 56);
            this.checkBoxFarm.Name = "checkBoxFarm";
            this.checkBoxFarm.Size = new System.Drawing.Size(105, 22);
            this.checkBoxFarm.TabIndex = 2;
            this.checkBoxFarm.Text = "Farm Cows";
            this.checkBoxFarm.UseVisualStyleBackColor = true;
            // 
            // checkBoxStart
            // 
            this.checkBoxStart.AutoSize = true;
            this.checkBoxStart.Location = new System.Drawing.Point(9, 28);
            this.checkBoxStart.Name = "checkBoxStart";
            this.checkBoxStart.Size = new System.Drawing.Size(92, 22);
            this.checkBoxStart.TabIndex = 1;
            this.checkBoxStart.Text = "Auto Start";
            this.checkBoxStart.UseVisualStyleBackColor = true;
            // 
            // checkBoxSniper
            // 
            this.checkBoxSniper.AutoSize = true;
            this.checkBoxSniper.Location = new System.Drawing.Point(9, 175);
            this.checkBoxSniper.Name = "checkBoxSniper";
            this.checkBoxSniper.Size = new System.Drawing.Size(84, 22);
            this.checkBoxSniper.TabIndex = 15;
            this.checkBoxSniper.Text = "Is Sniper";
            this.checkBoxSniper.UseVisualStyleBackColor = true;
            // 
            // checkBoxDebug
            // 
            this.checkBoxDebug.AutoSize = true;
            this.checkBoxDebug.Location = new System.Drawing.Point(9, 241);
            this.checkBoxDebug.Name = "checkBoxDebug";
            this.checkBoxDebug.Size = new System.Drawing.Size(136, 22);
            this.checkBoxDebug.TabIndex = 16;
            this.checkBoxDebug.Text = "checkBoxDebug";
            this.checkBoxDebug.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 333);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.featureBox);
            this.Controls.Add(this.osBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.osBox.ResumeLayout(false);
            this.osBox.PerformLayout();
            this.featureBox.ResumeLayout(false);
            this.featureBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox osBox;
        private System.Windows.Forms.RadioButton radioWin10;
        private System.Windows.Forms.RadioButton radioWin7;
        private System.Windows.Forms.Button buttonPatch;
        private System.Windows.Forms.GroupBox featureBox;
        private System.Windows.Forms.CheckBox checkBoxDeathRun;
        private System.Windows.Forms.CheckBox checkBoxAutoReady;
        private System.Windows.Forms.CheckBox checkBoxAntiAFK;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxFarm;
        private System.Windows.Forms.CheckBox checkBoxStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxShootDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxWeapon;
        private System.Windows.Forms.CheckBox checkBoxDoubleFire;
        private System.Windows.Forms.TextBox textBoxHeadPos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStartDelay;
        private System.Windows.Forms.CheckBox checkBoxSniper;
        private System.Windows.Forms.CheckBox checkBoxDebug;
    }
}

