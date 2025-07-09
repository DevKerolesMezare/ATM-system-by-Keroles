namespace ATMConsolApp_PresentationLayer.Transactions
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAccountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePinCodeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalWithdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quckWiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Azure;
            this.menuStrip1.Font = new System.Drawing.Font("Urdu Typesetting", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountInfoToolStripMenuItem,
            this.depositToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 72);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountInfoToolStripMenuItem
            // 
            this.accountInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem});
            this.accountInfoToolStripMenuItem.Image = global::ATMConsolApp_PresentationLayer.Properties.Resources.account_settings_64;
            this.accountInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountInfoToolStripMenuItem.Name = "accountInfoToolStripMenuItem";
            this.accountInfoToolStripMenuItem.Size = new System.Drawing.Size(296, 68);
            this.accountInfoToolStripMenuItem.Text = "Account Control";
            this.accountInfoToolStripMenuItem.Click += new System.EventHandler(this.accountInfoToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAccountDetailsToolStripMenuItem,
            this.changePinCodeToolStripMenuItem1});
            this.showToolStripMenuItem.Image = global::ATMConsolApp_PresentationLayer.Properties.Resources.Applications_64;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(300, 56);
            this.showToolStripMenuItem.Text = "AccountDetails";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // showAccountDetailsToolStripMenuItem
            // 
            this.showAccountDetailsToolStripMenuItem.Image = global::ATMConsolApp_PresentationLayer.Properties.Resources.User_32__2;
            this.showAccountDetailsToolStripMenuItem.Name = "showAccountDetailsToolStripMenuItem";
            this.showAccountDetailsToolStripMenuItem.Size = new System.Drawing.Size(366, 56);
            this.showAccountDetailsToolStripMenuItem.Text = "ShowAccountDetails";
            this.showAccountDetailsToolStripMenuItem.Click += new System.EventHandler(this.showAccountDetailsToolStripMenuItem_Click);
            // 
            // changePinCodeToolStripMenuItem1
            // 
            this.changePinCodeToolStripMenuItem1.Image = global::ATMConsolApp_PresentationLayer.Properties.Resources.Password_32;
            this.changePinCodeToolStripMenuItem1.Name = "changePinCodeToolStripMenuItem1";
            this.changePinCodeToolStripMenuItem1.Size = new System.Drawing.Size(366, 56);
            this.changePinCodeToolStripMenuItem1.Text = "Change PinCode";
            this.changePinCodeToolStripMenuItem1.Click += new System.EventHandler(this.changePinCodeToolStripMenuItem1_Click);
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withdrawToolStripMenuItem,
            this.depositToolStripMenuItem1});
            this.depositToolStripMenuItem.Image = global::ATMConsolApp_PresentationLayer.Properties.Resources.New_Application_64;
            this.depositToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(301, 68);
            this.depositToolStripMenuItem.Text = "TransactionType";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalWithdrawToolStripMenuItem,
            this.quckWiToolStripMenuItem});
            this.withdrawToolStripMenuItem.Image = global::ATMConsolApp_PresentationLayer.Properties.Resources.withdraw_icon;
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(245, 56);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            // 
            // normalWithdrawToolStripMenuItem
            // 
            this.normalWithdrawToolStripMenuItem.Name = "normalWithdrawToolStripMenuItem";
            this.normalWithdrawToolStripMenuItem.Size = new System.Drawing.Size(337, 56);
            this.normalWithdrawToolStripMenuItem.Text = "Normal Withdraw";
            this.normalWithdrawToolStripMenuItem.Click += new System.EventHandler(this.normalWithdrawToolStripMenuItem_Click);
            // 
            // quckWiToolStripMenuItem
            // 
            this.quckWiToolStripMenuItem.Name = "quckWiToolStripMenuItem";
            this.quckWiToolStripMenuItem.Size = new System.Drawing.Size(337, 56);
            this.quckWiToolStripMenuItem.Text = "Quick Withdraw";
            this.quckWiToolStripMenuItem.Click += new System.EventHandler(this.quckWiToolStripMenuItem_Click);
            // 
            // depositToolStripMenuItem1
            // 
            this.depositToolStripMenuItem1.Image = global::ATMConsolApp_PresentationLayer.Properties.Resources.deposit_icon;
            this.depositToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.depositToolStripMenuItem1.Name = "depositToolStripMenuItem1";
            this.depositToolStripMenuItem1.Size = new System.Drawing.Size(245, 56);
            this.depositToolStripMenuItem1.Text = "Deposit";
            this.depositToolStripMenuItem1.Click += new System.EventHandler(this.depositToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::ATMConsolApp_PresentationLayer.Properties.Resources.icons8_transfer_money_64;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(327, 68);
            this.toolStripMenuItem1.Text = "Currency Exchange";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitToolStripMenuItem.Image = global::ATMConsolApp_PresentationLayer.Properties.Resources.SignOut_64;
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 68);
            this.exitToolStripMenuItem.Text = "Sign Out";
            this.exitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePinCodeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showAccountDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalWithdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quckWiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}