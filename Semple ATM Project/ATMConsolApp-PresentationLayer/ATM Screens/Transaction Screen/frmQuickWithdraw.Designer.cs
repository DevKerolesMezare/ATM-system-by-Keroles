namespace ATMConsolApp_PresentationLayer.Transactions
{
    partial class frmQuickWithdraw
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAmount200 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbAmount1500 = new System.Windows.Forms.RadioButton();
            this.rbAmount500 = new System.Windows.Forms.RadioButton();
            this.rbAmount2000 = new System.Windows.Forms.RadioButton();
            this.rbAmount1000 = new System.Windows.Forms.RadioButton();
            this.rbAmount5000 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(31, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 213);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(191, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "تاكيد";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quick Withdraw Screen..";
            // 
            // rbAmount200
            // 
            this.rbAmount200.AutoSize = true;
            this.rbAmount200.Location = new System.Drawing.Point(31, 13);
            this.rbAmount200.Name = "rbAmount200";
            this.rbAmount200.Size = new System.Drawing.Size(76, 33);
            this.rbAmount200.TabIndex = 1;
            this.rbAmount200.TabStop = true;
            this.rbAmount200.Tag = "200";
            this.rbAmount200.Text = "200";
            this.rbAmount200.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAmount200.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.rbAmount5000);
            this.panel2.Controls.Add(this.rbAmount1000);
            this.panel2.Controls.Add(this.rbAmount2000);
            this.panel2.Controls.Add(this.rbAmount500);
            this.panel2.Controls.Add(this.rbAmount1500);
            this.panel2.Controls.Add(this.rbAmount200);
            this.panel2.Location = new System.Drawing.Point(54, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 124);
            this.panel2.TabIndex = 4;
            // 
            // rbAmount1500
            // 
            this.rbAmount1500.AutoSize = true;
            this.rbAmount1500.Location = new System.Drawing.Point(31, 63);
            this.rbAmount1500.Name = "rbAmount1500";
            this.rbAmount1500.Size = new System.Drawing.Size(90, 33);
            this.rbAmount1500.TabIndex = 4;
            this.rbAmount1500.TabStop = true;
            this.rbAmount1500.Tag = "1500";
            this.rbAmount1500.Text = "1500";
            this.rbAmount1500.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAmount1500.UseVisualStyleBackColor = true;
            // 
            // rbAmount500
            // 
            this.rbAmount500.AutoSize = true;
            this.rbAmount500.Location = new System.Drawing.Point(154, 13);
            this.rbAmount500.Name = "rbAmount500";
            this.rbAmount500.Size = new System.Drawing.Size(76, 33);
            this.rbAmount500.TabIndex = 2;
            this.rbAmount500.TabStop = true;
            this.rbAmount500.Tag = "500";
            this.rbAmount500.Text = "500";
            this.rbAmount500.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAmount500.UseVisualStyleBackColor = true;
            // 
            // rbAmount2000
            // 
            this.rbAmount2000.AutoSize = true;
            this.rbAmount2000.Location = new System.Drawing.Point(154, 63);
            this.rbAmount2000.Name = "rbAmount2000";
            this.rbAmount2000.Size = new System.Drawing.Size(90, 33);
            this.rbAmount2000.TabIndex = 5;
            this.rbAmount2000.TabStop = true;
            this.rbAmount2000.Tag = "2000";
            this.rbAmount2000.Text = "2000";
            this.rbAmount2000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAmount2000.UseVisualStyleBackColor = true;
            // 
            // rbAmount1000
            // 
            this.rbAmount1000.AutoSize = true;
            this.rbAmount1000.Location = new System.Drawing.Point(277, 13);
            this.rbAmount1000.Name = "rbAmount1000";
            this.rbAmount1000.Size = new System.Drawing.Size(90, 33);
            this.rbAmount1000.TabIndex = 3;
            this.rbAmount1000.TabStop = true;
            this.rbAmount1000.Tag = "1000";
            this.rbAmount1000.Text = "1000";
            this.rbAmount1000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAmount1000.UseVisualStyleBackColor = true;
            // 
            // rbAmount5000
            // 
            this.rbAmount5000.AutoSize = true;
            this.rbAmount5000.Location = new System.Drawing.Point(277, 63);
            this.rbAmount5000.Name = "rbAmount5000";
            this.rbAmount5000.Size = new System.Drawing.Size(90, 33);
            this.rbAmount5000.TabIndex = 6;
            this.rbAmount5000.TabStop = true;
            this.rbAmount5000.Tag = "5000";
            this.rbAmount5000.Text = "5000";
            this.rbAmount5000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAmount5000.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ATMConsolApp_PresentationLayer.Properties.Resources.Close_32;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(532, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 32);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmQuickWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(564, 317);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmQuickWithdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuickWithdraw";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAmount200;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbAmount5000;
        private System.Windows.Forms.RadioButton rbAmount1000;
        private System.Windows.Forms.RadioButton rbAmount2000;
        private System.Windows.Forms.RadioButton rbAmount500;
        private System.Windows.Forms.RadioButton rbAmount1500;
        private System.Windows.Forms.Button button3;
    }
}