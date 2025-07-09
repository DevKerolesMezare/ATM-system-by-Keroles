namespace ATMConsolApp_PresentationLayer
{
    partial class frmMainMenue
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
            this.btnTransaction = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnManagement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnTransaction);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(322, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 147);
            this.panel1.TabIndex = 0;
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.White;
            this.btnTransaction.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTransaction.FlatAppearance.BorderSize = 2;
            this.btnTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTransaction.Location = new System.Drawing.Point(45, 64);
            this.btnTransaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(196, 63);
            this.btnTransaction.TabIndex = 2;
            this.btnTransaction.Text = "Click Here";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Go To ATM Transaction Form";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnManagement);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(17, 23);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 147);
            this.panel2.TabIndex = 1;
            // 
            // btnManagement
            // 
            this.btnManagement.BackColor = System.Drawing.Color.White;
            this.btnManagement.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnManagement.FlatAppearance.BorderSize = 2;
            this.btnManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnManagement.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnManagement.Location = new System.Drawing.Point(39, 64);
            this.btnManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(196, 63);
            this.btnManagement.TabIndex = 1;
            this.btnManagement.Text = "Click Here";
            this.btnManagement.UseVisualStyleBackColor = false;
            this.btnManagement.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Go To Customer Management Form";
            // 
            // frmMainMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(630, 191);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMainMenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainMenue";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnManagement;
    }
}