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
            this.ReelOnePictureBox = new System.Windows.Forms.PictureBox();
            this.ReelThreePictureBox = new System.Windows.Forms.PictureBox();
            this.ReelTwoPictureBox = new System.Windows.Forms.PictureBox();
            this.ResetPictureBox = new System.Windows.Forms.PictureBox();
            this.SlotMachinePictureBox = new System.Windows.Forms.PictureBox();
            this.TotalCreditsTextBox = new System.Windows.Forms.TextBox();
            this.WinnerPaidTextBox = new System.Windows.Forms.TextBox();
            this.BetTextBox = new System.Windows.Forms.TextBox();
            this.BetOnePictureBox = new System.Windows.Forms.PictureBox();
            this.BetHundredPictureBox = new System.Windows.Forms.PictureBox();
            this.BetTenPictureBox = new System.Windows.Forms.PictureBox();
            this.JackpotTextBox = new System.Windows.Forms.TextBox();
            this.ResetBetButton = new System.Windows.Forms.Button();
            this.ExitPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelOnePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelThreePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelTwoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlotMachinePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetOnePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetHundredPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetTenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SpinPictureBox
            // 
            this.SpinPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SpinPictureBox.Image = global::SlotMachine.Properties.Resources.spin;
            this.SpinPictureBox.Location = new System.Drawing.Point(355, 441);
            this.SpinPictureBox.Name = "SpinPictureBox";
            this.SpinPictureBox.Size = new System.Drawing.Size(60, 50);
            this.SpinPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpinPictureBox.TabIndex = 6;
            this.SpinPictureBox.TabStop = false;
            this.SpinPictureBox.Click += new System.EventHandler(this.SpinPictureBox_Click);
            // 
            // ReelOnePictureBox
            // 
            this.ReelOnePictureBox.BackColor = System.Drawing.Color.White;
            this.ReelOnePictureBox.Location = new System.Drawing.Point(60, 225);
            this.ReelOnePictureBox.Name = "ReelOnePictureBox";
            this.ReelOnePictureBox.Size = new System.Drawing.Size(83, 129);
            this.ReelOnePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReelOnePictureBox.TabIndex = 7;
            this.ReelOnePictureBox.TabStop = false;
            // 
            // ReelThreePictureBox
            // 
            this.ReelThreePictureBox.BackColor = System.Drawing.Color.White;
            this.ReelThreePictureBox.Location = new System.Drawing.Point(320, 225);
            this.ReelThreePictureBox.Name = "ReelThreePictureBox";
            this.ReelThreePictureBox.Size = new System.Drawing.Size(83, 129);
            this.ReelThreePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReelThreePictureBox.TabIndex = 8;
            this.ReelThreePictureBox.TabStop = false;
            // 
            // ReelTwoPictureBox
            // 
            this.ReelTwoPictureBox.BackColor = System.Drawing.Color.White;
            this.ReelTwoPictureBox.Location = new System.Drawing.Point(190, 225);
            this.ReelTwoPictureBox.Name = "ReelTwoPictureBox";
            this.ReelTwoPictureBox.Size = new System.Drawing.Size(83, 129);
            this.ReelTwoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReelTwoPictureBox.TabIndex = 9;
            this.ReelTwoPictureBox.TabStop = false;
            // 
            // ResetPictureBox
            // 
            this.ResetPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ResetPictureBox.Image = global::SlotMachine.Properties.Resources.reset;
            this.ResetPictureBox.Location = new System.Drawing.Point(297, 441);
            this.ResetPictureBox.Name = "ResetPictureBox";
            this.ResetPictureBox.Size = new System.Drawing.Size(60, 50);
            this.ResetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResetPictureBox.TabIndex = 10;
            this.ResetPictureBox.TabStop = false;
            this.ResetPictureBox.Click += new System.EventHandler(this.ResetPictureBox_Click);
            // 
            // SlotMachinePictureBox
            // 
            this.SlotMachinePictureBox.Image = global::SlotMachine.Properties.Resources.slotmachine;
            this.SlotMachinePictureBox.Location = new System.Drawing.Point(0, 0);
            this.SlotMachinePictureBox.Name = "SlotMachinePictureBox";
            this.SlotMachinePictureBox.Size = new System.Drawing.Size(464, 538);
            this.SlotMachinePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SlotMachinePictureBox.TabIndex = 11;
            this.SlotMachinePictureBox.TabStop = false;
            // 
            // TotalCreditsTextBox
            // 
            this.TotalCreditsTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalCreditsTextBox.Enabled = false;
            this.TotalCreditsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCreditsTextBox.ForeColor = System.Drawing.Color.Red;
            this.TotalCreditsTextBox.Location = new System.Drawing.Point(43, 380);
            this.TotalCreditsTextBox.Name = "TotalCreditsTextBox";
            this.TotalCreditsTextBox.ReadOnly = true;
            this.TotalCreditsTextBox.Size = new System.Drawing.Size(124, 22);
            this.TotalCreditsTextBox.TabIndex = 12;
            // 
            // WinnerPaidTextBox
            // 
            this.WinnerPaidTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WinnerPaidTextBox.Enabled = false;
            this.WinnerPaidTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerPaidTextBox.ForeColor = System.Drawing.Color.Red;
            this.WinnerPaidTextBox.Location = new System.Drawing.Point(291, 380);
            this.WinnerPaidTextBox.Name = "WinnerPaidTextBox";
            this.WinnerPaidTextBox.ReadOnly = true;
            this.WinnerPaidTextBox.Size = new System.Drawing.Size(124, 22);
            this.WinnerPaidTextBox.TabIndex = 13;
            // 
            // BetTextBox
            // 
            this.BetTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BetTextBox.Enabled = false;
            this.BetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetTextBox.ForeColor = System.Drawing.Color.Red;
            this.BetTextBox.Location = new System.Drawing.Point(190, 380);
            this.BetTextBox.Name = "BetTextBox";
            this.BetTextBox.ReadOnly = true;
            this.BetTextBox.Size = new System.Drawing.Size(83, 22);
            this.BetTextBox.TabIndex = 14;
            // 
            // BetOnePictureBox
            // 
            this.BetOnePictureBox.Image = global::SlotMachine.Properties.Resources.bet1;
            this.BetOnePictureBox.Location = new System.Drawing.Point(55, 441);
            this.BetOnePictureBox.Name = "BetOnePictureBox";
            this.BetOnePictureBox.Size = new System.Drawing.Size(47, 45);
            this.BetOnePictureBox.TabIndex = 15;
            this.BetOnePictureBox.TabStop = false;
            this.BetOnePictureBox.Click += new System.EventHandler(this.BetOnePictureBox_Click);
            // 
            // BetHundredPictureBox
            // 
            this.BetHundredPictureBox.Image = global::SlotMachine.Properties.Resources.bet100;
            this.BetHundredPictureBox.Location = new System.Drawing.Point(157, 441);
            this.BetHundredPictureBox.Name = "BetHundredPictureBox";
            this.BetHundredPictureBox.Size = new System.Drawing.Size(47, 45);
            this.BetHundredPictureBox.TabIndex = 16;
            this.BetHundredPictureBox.TabStop = false;
            this.BetHundredPictureBox.Click += new System.EventHandler(this.BetHundredPictureBox_Click);
            // 
            // BetTenPictureBox
            // 
            this.BetTenPictureBox.Image = global::SlotMachine.Properties.Resources.bet10;
            this.BetTenPictureBox.Location = new System.Drawing.Point(106, 441);
            this.BetTenPictureBox.Name = "BetTenPictureBox";
            this.BetTenPictureBox.Size = new System.Drawing.Size(47, 45);
            this.BetTenPictureBox.TabIndex = 17;
            this.BetTenPictureBox.TabStop = false;
            this.BetTenPictureBox.Click += new System.EventHandler(this.BetTenPictureBox_Click);
            // 
            // JackpotTextBox
            // 
            this.JackpotTextBox.Enabled = false;
            this.JackpotTextBox.Location = new System.Drawing.Point(179, 166);
            this.JackpotTextBox.Name = "JackpotTextBox";
            this.JackpotTextBox.ReadOnly = true;
            this.JackpotTextBox.Size = new System.Drawing.Size(111, 22);
            this.JackpotTextBox.TabIndex = 18;
            // 
            // ResetBetButton
            // 
            this.ResetBetButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResetBetButton.ForeColor = System.Drawing.Color.Black;
            this.ResetBetButton.Location = new System.Drawing.Point(0, 0);
            this.ResetBetButton.Name = "ResetBetButton";
            this.ResetBetButton.Size = new System.Drawing.Size(102, 27);
            this.ResetBetButton.TabIndex = 19;
            this.ResetBetButton.Text = "Reset Bet";
            this.ResetBetButton.UseVisualStyleBackColor = false;
            this.ResetBetButton.Click += new System.EventHandler(this.ResetBetButton_Click);
            // 
            // ExitPictureBox
            // 
            this.ExitPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ExitPictureBox.Image = global::SlotMachine.Properties.Resources.powerbutton;
            this.ExitPictureBox.Location = new System.Drawing.Point(239, 441);
            this.ExitPictureBox.Name = "ExitPictureBox";
            this.ExitPictureBox.Size = new System.Drawing.Size(60, 50);
            this.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitPictureBox.TabIndex = 20;
            this.ExitPictureBox.TabStop = false;
            this.ExitPictureBox.Click += new System.EventHandler(this.ExitPictureBox_Click);
            // 
            // SlotMachineForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(462, 533);
            this.Controls.Add(this.ExitPictureBox);
            this.Controls.Add(this.ResetBetButton);
            this.Controls.Add(this.JackpotTextBox);
            this.Controls.Add(this.BetTenPictureBox);
            this.Controls.Add(this.BetHundredPictureBox);
            this.Controls.Add(this.BetOnePictureBox);
            this.Controls.Add(this.BetTextBox);
            this.Controls.Add(this.WinnerPaidTextBox);
            this.Controls.Add(this.TotalCreditsTextBox);
            this.Controls.Add(this.ResetPictureBox);
            this.Controls.Add(this.ReelTwoPictureBox);
            this.Controls.Add(this.ReelThreePictureBox);
            this.Controls.Add(this.ReelOnePictureBox);
            this.Controls.Add(this.SpinPictureBox);
            this.Controls.Add(this.SlotMachinePictureBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SlotMachineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            this.Load += new System.EventHandler(this.SlotMachineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpinPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelOnePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelThreePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelTwoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResetPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlotMachinePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetOnePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetHundredPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetTenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox SpinPictureBox;
        private System.Windows.Forms.PictureBox ReelOnePictureBox;
        private System.Windows.Forms.PictureBox ReelThreePictureBox;
        private System.Windows.Forms.PictureBox ReelTwoPictureBox;
        private System.Windows.Forms.PictureBox ResetPictureBox;
        private System.Windows.Forms.PictureBox SlotMachinePictureBox;
        private System.Windows.Forms.TextBox TotalCreditsTextBox;
        private System.Windows.Forms.TextBox WinnerPaidTextBox;
        private System.Windows.Forms.TextBox BetTextBox;
        private System.Windows.Forms.PictureBox BetOnePictureBox;
        private System.Windows.Forms.PictureBox BetHundredPictureBox;
        private System.Windows.Forms.PictureBox BetTenPictureBox;
        private System.Windows.Forms.TextBox JackpotTextBox;
        private System.Windows.Forms.Button ResetBetButton;
        private System.Windows.Forms.PictureBox ExitPictureBox;
    }
}