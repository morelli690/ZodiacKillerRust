namespace ZodiacKillerRust
{
    partial class Main
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
            this.WeaponLabel = new System.Windows.Forms.Label();
            this.WeaponSelectCombo = new System.Windows.Forms.ComboBox();
            this.ToggleButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.Watermark = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Tutorial1 = new System.Windows.Forms.Label();
            this.Tutorial2 = new System.Windows.Forms.Label();
            this.QuickstartLabel = new System.Windows.Forms.Label();
            this.HotKeysLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Tutorial4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Tutorial3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WeaponLabel
            // 
            this.WeaponLabel.AutoSize = true;
            this.WeaponLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponLabel.Location = new System.Drawing.Point(15, 133);
            this.WeaponLabel.Name = "WeaponLabel";
            this.WeaponLabel.Size = new System.Drawing.Size(163, 23);
            this.WeaponLabel.TabIndex = 7;
            this.WeaponLabel.Text = "Selected Weapon:";
            // 
            // WeaponSelectCombo
            // 
            this.WeaponSelectCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.WeaponSelectCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeaponSelectCombo.ForeColor = System.Drawing.Color.White;
            this.WeaponSelectCombo.FormattingEnabled = true;
            this.WeaponSelectCombo.Items.AddRange(new object[] {
            "Assault Rifle (Basically aimbot)",
            "LR-300 (Tighter than my ass)",
            "M249 (Hits p100)",
            "Thomson (Thread the needle)",
            "MP5 (Shred like tony hawk)",
            "Custom SMG (Skrrrraaa)",
            "SAR (So good its sketchy)",
            "M92 (How to get reported 101)",
            "Python (EZ mode)",
            "M39 (Ridiculous)"});
            this.WeaponSelectCombo.Location = new System.Drawing.Point(19, 159);
            this.WeaponSelectCombo.Name = "WeaponSelectCombo";
            this.WeaponSelectCombo.Size = new System.Drawing.Size(333, 21);
            this.WeaponSelectCombo.TabIndex = 6;
            this.WeaponSelectCombo.SelectedIndexChanged += new System.EventHandler(this.WeaponSelectCombo_SelectedIndexChanged);
            // 
            // ToggleButton
            // 
            this.ToggleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ToggleButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ToggleButton.FlatAppearance.BorderSize = 3;
            this.ToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleButton.ForeColor = System.Drawing.Color.White;
            this.ToggleButton.Location = new System.Drawing.Point(19, 89);
            this.ToggleButton.Name = "ToggleButton";
            this.ToggleButton.Size = new System.Drawing.Size(333, 41);
            this.ToggleButton.TabIndex = 5;
            this.ToggleButton.Text = "Disabled";
            this.ToggleButton.UseVisualStyleBackColor = false;
            this.ToggleButton.Click += new System.EventHandler(this.ToggleButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(6, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(367, 77);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Zodiac Killer Rust";
            // 
            // Watermark
            // 
            this.Watermark.AutoSize = true;
            this.Watermark.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Watermark.Location = new System.Drawing.Point(10, 365);
            this.Watermark.Name = "Watermark";
            this.Watermark.Size = new System.Drawing.Size(282, 23);
            this.Watermark.TabIndex = 8;
            this.Watermark.Text = "Made By IceColdCanadian#4281";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.Location = new System.Drawing.Point(10, 342);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(135, 23);
            this.VersionLabel.TabIndex = 9;
            this.VersionLabel.Text = "Version 1.3.0.0";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ExitButton.FlatAppearance.BorderSize = 3;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(320, 340);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(50, 50);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Tutorial1
            // 
            this.Tutorial1.AutoSize = true;
            this.Tutorial1.Location = new System.Drawing.Point(16, 203);
            this.Tutorial1.Name = "Tutorial1";
            this.Tutorial1.Size = new System.Drawing.Size(101, 13);
            this.Tutorial1.TabIndex = 12;
            this.Tutorial1.Text = "Set sensitivity to 0.4";
            // 
            // Tutorial2
            // 
            this.Tutorial2.AutoSize = true;
            this.Tutorial2.Location = new System.Drawing.Point(16, 216);
            this.Tutorial2.Name = "Tutorial2";
            this.Tutorial2.Size = new System.Drawing.Size(83, 13);
            this.Tutorial2.TabIndex = 13;
            this.Tutorial2.Text = "Set DPI to 1250";
            // 
            // QuickstartLabel
            // 
            this.QuickstartLabel.AutoSize = true;
            this.QuickstartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuickstartLabel.Location = new System.Drawing.Point(16, 187);
            this.QuickstartLabel.Name = "QuickstartLabel";
            this.QuickstartLabel.Size = new System.Drawing.Size(77, 16);
            this.QuickstartLabel.TabIndex = 14;
            this.QuickstartLabel.Text = "Quickstart";
            // 
            // HotKeysLabel
            // 
            this.HotKeysLabel.AutoSize = true;
            this.HotKeysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotKeysLabel.Location = new System.Drawing.Point(16, 262);
            this.HotKeysLabel.Name = "HotKeysLabel";
            this.HotKeysLabel.Size = new System.Drawing.Size(195, 16);
            this.HotKeysLabel.TabIndex = 15;
            this.HotKeysLabel.Text = "HotKeys (Insert To Toggle)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "NUMPAD1: Assault Rifle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "NUMPAD2: LR-300";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "NUMPAD3: M249";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "NUMPAD4: Thomson";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "NUMPAD5: MP5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "NUMPAD6: Custom SMG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "NUMPAD7: SAR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "NUMPAD8:  M92";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "NUMPAD9:  Python";
            // 
            // Tutorial4
            // 
            this.Tutorial4.AutoSize = true;
            this.Tutorial4.Location = new System.Drawing.Point(16, 242);
            this.Tutorial4.Name = "Tutorial4";
            this.Tutorial4.Size = new System.Drawing.Size(125, 13);
            this.Tutorial4.TabIndex = 26;
            this.Tutorial4.Text = "Crouch, aim, and shoot :)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(227, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "NUMPAD0: M39";
            // 
            // Tutorial3
            // 
            this.Tutorial3.AutoSize = true;
            this.Tutorial3.Location = new System.Drawing.Point(16, 229);
            this.Tutorial3.Name = "Tutorial3";
            this.Tutorial3.Size = new System.Drawing.Size(200, 13);
            this.Tutorial3.TabIndex = 28;
            this.Tutorial3.Text = "Type in console, bind pagedown +attack";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(380, 400);
            this.Controls.Add(this.Tutorial3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Tutorial4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HotKeysLabel);
            this.Controls.Add(this.QuickstartLabel);
            this.Controls.Add(this.Tutorial2);
            this.Controls.Add(this.Tutorial1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.Watermark);
            this.Controls.Add(this.WeaponLabel);
            this.Controls.Add(this.WeaponSelectCombo);
            this.Controls.Add(this.ToggleButton);
            this.Controls.Add(this.TitleLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "ZodiacKillerRust";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label WeaponLabel;
        private System.Windows.Forms.ComboBox WeaponSelectCombo;
        private System.Windows.Forms.Button ToggleButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label Watermark;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label Tutorial1;
        private System.Windows.Forms.Label Tutorial2;
        private System.Windows.Forms.Label QuickstartLabel;
        private System.Windows.Forms.Label HotKeysLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Tutorial4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Tutorial3;
    }
}

