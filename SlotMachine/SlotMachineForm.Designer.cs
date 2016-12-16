namespace SlotMachine
{
    partial class SlotMachineForm
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
            this.SpinPictureBox = new System.Windows.Forms.PictureBox();
            this.ReelPictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReelPictureBox2 = new System.Windows.Forms.PictureBox();
            this.ReelPictureBox3 = new System.Windows.Forms.PictureBox();
            this.PowerPictureBox = new System.Windows.Forms.PictureBox();
            this.ResetPictureBox = new System.Windows.Forms.PictureBox();
            this.CurrentJackpotLabel = new System.Windows.Forms.Label();
            this.TotalCreditLabel = new System.Windows.Forms.Label();
            this.BetLabel = new System.Windows.Forms.Label();
            this.WinnerPaidLabel = new System.Windows.Forms.Label();
            this.BetButton10 = new System.Windows.Forms.Button();
            this.BetButton20 = new System.Windows.Forms.Button();
            this.BetButton30 = new System.Windows.Forms.Button();
            this.BetButton40 = new System.Windows.Forms.Button();
            this.BetButton50 = new System.Windows.Forms.Button();
            this.BetButton100 = new System.Windows.Forms.Button();
            this.BetButton1000 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SpinPictureBox
            // 
            this.SpinPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SpinPictureBox.Image = global::SlotMachine.Properties.Resources.spin;
            this.SpinPictureBox.Location = new System.Drawing.Point(584, 674);
            this.SpinPictureBox.Name = "SpinPictureBox";
            this.SpinPictureBox.Size = new System.Drawing.Size(60, 50);
            this.SpinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinPictureBox.TabIndex = 6;
            this.SpinPictureBox.TabStop = false;
            this.SpinPictureBox.Click += new System.EventHandler(this.SpinPictureBox_Click);
            // 
            // ReelPictureBox1
            // 
            this.ReelPictureBox1.Image = global::SlotMachine.Properties.Resources.blank;
            this.ReelPictureBox1.InitialImage = global::SlotMachine.Properties.Resources.blank;
            this.ReelPictureBox1.Location = new System.Drawing.Point(171, 340);
            this.ReelPictureBox1.Name = "ReelPictureBox1";
            this.ReelPictureBox1.Size = new System.Drawing.Size(112, 188);
            this.ReelPictureBox1.TabIndex = 7;
            this.ReelPictureBox1.TabStop = false;
            // 
            // ReelPictureBox2
            // 
            this.ReelPictureBox2.InitialImage = global::SlotMachine.Properties.Resources.blank;
            this.ReelPictureBox2.Location = new System.Drawing.Point(339, 340);
            this.ReelPictureBox2.Name = "ReelPictureBox2";
            this.ReelPictureBox2.Size = new System.Drawing.Size(112, 188);
            this.ReelPictureBox2.TabIndex = 8;
            this.ReelPictureBox2.TabStop = false;
            // 
            // ReelPictureBox3
            // 
            this.ReelPictureBox3.Image = global::SlotMachine.Properties.Resources.blank;
            this.ReelPictureBox3.Location = new System.Drawing.Point(509, 340);
            this.ReelPictureBox3.Name = "ReelPictureBox3";
            this.ReelPictureBox3.Size = new System.Drawing.Size(112, 188);
            this.ReelPictureBox3.TabIndex = 9;
            this.ReelPictureBox3.TabStop = false;
            // 
            // PowerPictureBox
            // 
            this.PowerPictureBox.Image = global::SlotMachine.Properties.Resources.powerbutton;
            this.PowerPictureBox.Location = new System.Drawing.Point(574, 160);
            this.PowerPictureBox.Name = "PowerPictureBox";
            this.PowerPictureBox.Size = new System.Drawing.Size(84, 77);
            this.PowerPictureBox.TabIndex = 10;
            this.PowerPictureBox.TabStop = false;
            this.PowerPictureBox.Click += new System.EventHandler(this.PowerPictureBox_Click);
            // 
            // ResetPictureBox
            // 
            this.ResetPictureBox.Image = global::SlotMachine.Properties.Resources.reset;
            this.ResetPictureBox.Location = new System.Drawing.Point(144, 160);
            this.ResetPictureBox.Name = "ResetPictureBox";
            this.ResetPictureBox.Size = new System.Drawing.Size(81, 82);
            this.ResetPictureBox.TabIndex = 11;
            this.ResetPictureBox.TabStop = false;
            this.ResetPictureBox.Click += new System.EventHandler(this.ResetPictureBox_Click);
            // 
            // CurrentJackpotLabel
            // 
            this.CurrentJackpotLabel.AutoSize = true;
            this.CurrentJackpotLabel.Location = new System.Drawing.Point(370, 250);
            this.CurrentJackpotLabel.Name = "CurrentJackpotLabel";
            this.CurrentJackpotLabel.Size = new System.Drawing.Size(0, 20);
            this.CurrentJackpotLabel.TabIndex = 12;
            // 
            // TotalCreditLabel
            // 
            this.TotalCreditLabel.AutoSize = true;
            this.TotalCreditLabel.Location = new System.Drawing.Point(202, 568);
            this.TotalCreditLabel.Name = "TotalCreditLabel";
            this.TotalCreditLabel.Size = new System.Drawing.Size(45, 20);
            this.TotalCreditLabel.TabIndex = 13;
            this.TotalCreditLabel.Text = "5000";
            // 
            // BetLabel
            // 
            this.BetLabel.AutoSize = true;
            this.BetLabel.Location = new System.Drawing.Point(370, 568);
            this.BetLabel.Name = "BetLabel";
            this.BetLabel.Size = new System.Drawing.Size(27, 20);
            this.BetLabel.TabIndex = 14;
            this.BetLabel.Text = "10";
            // 
            // WinnerPaidLabel
            // 
            this.WinnerPaidLabel.AutoSize = true;
            this.WinnerPaidLabel.Location = new System.Drawing.Point(535, 568);
            this.WinnerPaidLabel.Name = "WinnerPaidLabel";
            this.WinnerPaidLabel.Size = new System.Drawing.Size(18, 20);
            this.WinnerPaidLabel.TabIndex = 15;
            this.WinnerPaidLabel.Text = "0";
            // 
            // BetButton10
            // 
            this.BetButton10.Location = new System.Drawing.Point(161, 657);
            this.BetButton10.Name = "BetButton10";
            this.BetButton10.Size = new System.Drawing.Size(47, 32);
            this.BetButton10.TabIndex = 16;
            this.BetButton10.Text = "10";
            this.BetButton10.UseVisualStyleBackColor = true;
            this.BetButton10.Click += new System.EventHandler(this.BetButton10_Click);
            // 
            // BetButton20
            // 
            this.BetButton20.Location = new System.Drawing.Point(215, 701);
            this.BetButton20.Name = "BetButton20";
            this.BetButton20.Size = new System.Drawing.Size(47, 32);
            this.BetButton20.TabIndex = 17;
            this.BetButton20.Text = "20";
            this.BetButton20.UseVisualStyleBackColor = true;
            this.BetButton20.Click += new System.EventHandler(this.BetButton20_Click);
            // 
            // BetButton30
            // 
            this.BetButton30.Location = new System.Drawing.Point(269, 657);
            this.BetButton30.Name = "BetButton30";
            this.BetButton30.Size = new System.Drawing.Size(47, 32);
            this.BetButton30.TabIndex = 18;
            this.BetButton30.Text = "30";
            this.BetButton30.UseVisualStyleBackColor = true;
            this.BetButton30.Click += new System.EventHandler(this.BetButton30_Click);
            // 
            // BetButton40
            // 
            this.BetButton40.Location = new System.Drawing.Point(323, 701);
            this.BetButton40.Name = "BetButton40";
            this.BetButton40.Size = new System.Drawing.Size(47, 32);
            this.BetButton40.TabIndex = 19;
            this.BetButton40.Text = "40";
            this.BetButton40.UseVisualStyleBackColor = true;
            this.BetButton40.Click += new System.EventHandler(this.BetButton40_Click);
            // 
            // BetButton50
            // 
            this.BetButton50.Location = new System.Drawing.Point(374, 657);
            this.BetButton50.Name = "BetButton50";
            this.BetButton50.Size = new System.Drawing.Size(47, 32);
            this.BetButton50.TabIndex = 20;
            this.BetButton50.Text = "50";
            this.BetButton50.UseVisualStyleBackColor = true;
            this.BetButton50.Click += new System.EventHandler(this.BetButton50_Click);
            // 
            // BetButton100
            // 
            this.BetButton100.Location = new System.Drawing.Point(433, 701);
            this.BetButton100.Name = "BetButton100";
            this.BetButton100.Size = new System.Drawing.Size(47, 32);
            this.BetButton100.TabIndex = 21;
            this.BetButton100.Text = "100";
            this.BetButton100.UseVisualStyleBackColor = true;
            this.BetButton100.Click += new System.EventHandler(this.BetButton100_Click);
            // 
            // BetButton1000
            // 
            this.BetButton1000.Location = new System.Drawing.Point(492, 657);
            this.BetButton1000.Name = "BetButton1000";
            this.BetButton1000.Size = new System.Drawing.Size(61, 32);
            this.BetButton1000.TabIndex = 22;
            this.BetButton1000.Text = "1000";
            this.BetButton1000.UseVisualStyleBackColor = true;
            this.BetButton1000.Click += new System.EventHandler(this.BetButton1000_Click);
            // 
            // SlotMachineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SlotMachine.Properties.Resources.slotmachine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(794, 797);
            this.Controls.Add(this.BetButton1000);
            this.Controls.Add(this.BetButton100);
            this.Controls.Add(this.BetButton50);
            this.Controls.Add(this.BetButton40);
            this.Controls.Add(this.BetButton30);
            this.Controls.Add(this.BetButton20);
            this.Controls.Add(this.BetButton10);
            this.Controls.Add(this.WinnerPaidLabel);
            this.Controls.Add(this.BetLabel);
            this.Controls.Add(this.TotalCreditLabel);
            this.Controls.Add(this.CurrentJackpotLabel);
            this.Controls.Add(this.ResetPictureBox);
            this.Controls.Add(this.PowerPictureBox);
            this.Controls.Add(this.ReelPictureBox3);
            this.Controls.Add(this.ReelPictureBox2);
            this.Controls.Add(this.ReelPictureBox1);
            this.Controls.Add(this.SpinPictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SlotMachineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox SpinPictureBox;
        private System.Windows.Forms.PictureBox ReelPictureBox1;
        private System.Windows.Forms.PictureBox ReelPictureBox2;
        private System.Windows.Forms.PictureBox ReelPictureBox3;
        private System.Windows.Forms.PictureBox PowerPictureBox;
        private System.Windows.Forms.PictureBox ResetPictureBox;
        private System.Windows.Forms.Label CurrentJackpotLabel;
        private System.Windows.Forms.Label TotalCreditLabel;
        private System.Windows.Forms.Label BetLabel;
        private System.Windows.Forms.Label WinnerPaidLabel;
        private System.Windows.Forms.Button BetButton10;
        private System.Windows.Forms.Button BetButton20;
        private System.Windows.Forms.Button BetButton30;
        private System.Windows.Forms.Button BetButton40;
        private System.Windows.Forms.Button BetButton50;
        private System.Windows.Forms.Button BetButton100;
        private System.Windows.Forms.Button BetButton1000;
    }
}