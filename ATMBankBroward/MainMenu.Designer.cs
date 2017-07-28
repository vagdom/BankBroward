namespace ATMBankBroward
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBalanceInquiry = new System.Windows.Forms.Button();
            this.btnSavingsDeposit = new System.Windows.Forms.Button();
            this.btnSavingsWithdraw = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.pixImageRight = new System.Windows.Forms.PictureBox();
            this.pixImageLeft = new System.Windows.Forms.PictureBox();
            this.lblClientInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pixImageRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixImageLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 111);
            this.label1.TabIndex = 0;
            this.label1.Text = "\r\nBroward Bank ATM\r\n\r\nWelcome!\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBalanceInquiry
            // 
            this.btnBalanceInquiry.BackColor = System.Drawing.Color.Transparent;
            this.btnBalanceInquiry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBalanceInquiry.Location = new System.Drawing.Point(167, 188);
            this.btnBalanceInquiry.Name = "btnBalanceInquiry";
            this.btnBalanceInquiry.Size = new System.Drawing.Size(218, 52);
            this.btnBalanceInquiry.TabIndex = 1;
            this.btnBalanceInquiry.Text = "Balance Inquiry ";
            this.btnBalanceInquiry.UseVisualStyleBackColor = false;
            this.btnBalanceInquiry.Click += new System.EventHandler(this.btnBalanceInquiry_Click);
            // 
            // btnSavingsDeposit
            // 
            this.btnSavingsDeposit.Location = new System.Drawing.Point(167, 249);
            this.btnSavingsDeposit.Name = "btnSavingsDeposit";
            this.btnSavingsDeposit.Size = new System.Drawing.Size(218, 52);
            this.btnSavingsDeposit.TabIndex = 2;
            this.btnSavingsDeposit.Text = "Savings Deposit";
            this.btnSavingsDeposit.UseVisualStyleBackColor = true;
            this.btnSavingsDeposit.Click += new System.EventHandler(this.btnSavingsDeposit_Click);
            // 
            // btnSavingsWithdraw
            // 
            this.btnSavingsWithdraw.Location = new System.Drawing.Point(167, 316);
            this.btnSavingsWithdraw.Name = "btnSavingsWithdraw";
            this.btnSavingsWithdraw.Size = new System.Drawing.Size(218, 52);
            this.btnSavingsWithdraw.TabIndex = 4;
            this.btnSavingsWithdraw.Text = "Savings Withdraw";
            this.btnSavingsWithdraw.UseVisualStyleBackColor = true;
            this.btnSavingsWithdraw.Click += new System.EventHandler(this.btnSavingsWithdraw_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(167, 382);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(218, 52);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // pixImageRight
            // 
            this.pixImageRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pixImageRight.BackgroundImage")));
            this.pixImageRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pixImageRight.Location = new System.Drawing.Point(412, 188);
            this.pixImageRight.Name = "pixImageRight";
            this.pixImageRight.Size = new System.Drawing.Size(141, 246);
            this.pixImageRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pixImageRight.TabIndex = 8;
            this.pixImageRight.TabStop = false;
            // 
            // pixImageLeft
            // 
            this.pixImageLeft.BackColor = System.Drawing.Color.White;
            this.pixImageLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pixImageLeft.Image = ((System.Drawing.Image)(resources.GetObject("pixImageLeft.Image")));
            this.pixImageLeft.Location = new System.Drawing.Point(5, 188);
            this.pixImageLeft.Name = "pixImageLeft";
            this.pixImageLeft.Size = new System.Drawing.Size(141, 246);
            this.pixImageLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pixImageLeft.TabIndex = 9;
            this.pixImageLeft.TabStop = false;
            // 
            // lblClientInfo
            // 
            this.lblClientInfo.AutoSize = true;
            this.lblClientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientInfo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblClientInfo.Location = new System.Drawing.Point(13, 147);
            this.lblClientInfo.Name = "lblClientInfo";
            this.lblClientInfo.Size = new System.Drawing.Size(60, 24);
            this.lblClientInfo.TabIndex = 10;
            this.lblClientInfo.Text = "label2";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 460);
            this.Controls.Add(this.lblClientInfo);
            this.Controls.Add(this.pixImageLeft);
            this.Controls.Add(this.pixImageRight);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnSavingsWithdraw);
            this.Controls.Add(this.btnSavingsDeposit);
            this.Controls.Add(this.btnBalanceInquiry);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Broward Bank - Main Menu";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pixImageRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixImageLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBalanceInquiry;
        private System.Windows.Forms.Button btnSavingsDeposit;
        private System.Windows.Forms.Button btnSavingsWithdraw;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.PictureBox pixImageRight;
        private System.Windows.Forms.PictureBox pixImageLeft;
        private System.Windows.Forms.Label lblClientInfo;
    }
}