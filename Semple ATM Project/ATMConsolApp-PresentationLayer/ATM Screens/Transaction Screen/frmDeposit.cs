using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMConsolApp_PresentationLayer.Transactions
{
    public partial class frmDeposit : Form
    {
        public frmDeposit()
        {
            InitializeComponent();
        }
     
        private void _DepositAmount()
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("لم يتم تحديد مبلغ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (MessageBox.Show(("Are you sure you want to deposit this amount? [" + textBox1.Text + "]"), "Message", MessageBoxButtons.YesNo ,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                button1.Enabled = false;
                clsGlobal.CurrentClient.Deposit(Convert.ToUInt32(textBox1.Text));

                MessageBox.Show(("The deposit has been successfully completed, You Amount [" + clsGlobal.CurrentClient.AccountBalance + "]"), "Success");
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("الغاء العملية","Message");
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {      
            _DepositAmount();
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
            errorProvider1.SetError(textBox1 , "ادخل المبلغ..");
            if (!IsNumber(textBox1.Text)) { e.Cancel = true; }
        }
    }
}
