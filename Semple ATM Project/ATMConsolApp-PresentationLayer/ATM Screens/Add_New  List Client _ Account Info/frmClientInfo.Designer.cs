namespace ATMConsolApp_PresentationLayer.Transactions
{
    partial class frmClientInfo
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
            this.ctrlClientInfo1 = new ATMConsolApp_PresentationLayer.Transactions.ctrlClientInfo();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlClientInfo1
            // 
            this.ctrlClientInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlClientInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlClientInfo1.Name = "ctrlClientInfo1";
            this.ctrlClientInfo1.Size = new System.Drawing.Size(649, 522);
            this.ctrlClientInfo1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ATMConsolApp_PresentationLayer.Properties.Resources.Close_32;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(590, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 44);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlClientInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClientInfo";
            this.ResumeLayout(false);

        }

        #endregion
        private ctrlClientInfo ctrlClientInfo1;
        private System.Windows.Forms.Button button1;
    }
}