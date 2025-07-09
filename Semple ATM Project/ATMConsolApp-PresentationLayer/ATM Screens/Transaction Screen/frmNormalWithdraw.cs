using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATMConsolApp_PresentationLayer.Transactions
{
    public partial class frmNormalWithdraw : Form
    {
        public frmNormalWithdraw()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void _WithdrawAmount()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("لم يتم تحديد مبلغ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (MessageBox.Show(("Are you sure you want to withdraw this amount? [" + textBox1.Text + "]"), "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                button1.Enabled = false;

                if (clsGlobal.CurrentClient.Withdraw(Convert.ToUInt32(textBox1.Text)))
                {
                    MessageBox.Show(("The withdraw has been successfully completed, You Amount [" + clsGlobal.CurrentClient.AccountBalance + "]"), "Success");
                    textBox1.Text = "";
                    return;
                }

                MessageBox.Show("ليس لديك رصيد كافي...", "Message");
                textBox1.Text = "";
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _WithdrawAmount();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private bool IsNumber(string input)
        {
            return double.TryParse(input, out _); // يحاول تحويل النص إلى رقم (عدد صحيح أو عشري)
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
    
           // errorProvider1.SetError(textBox1, "ادخل المبلغ..");
            if (!IsNumber(textBox1.Text)) { e.Cancel = true; }

}

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
