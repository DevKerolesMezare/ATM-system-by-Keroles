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
    public partial class frmQuickWithdraw : Form
    {
        public frmQuickWithdraw()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private int _ChooseAmount()  // خصم المبلغ حسب الاختيار
        {

            if (rbAmount200.Checked)
            {
                return Convert.ToInt32(rbAmount200.Tag);
            }

            if (rbAmount500.Checked)
            {
                return Convert.ToInt32(rbAmount500.Tag);
            }

            if (rbAmount1000.Checked)
            {
                return Convert.ToInt32(rbAmount1000.Tag);
            }

            if (rbAmount1500.Checked)
            {
                return Convert.ToInt32(rbAmount1500.Tag);
            }

            if (rbAmount2000.Checked)
            {
                return Convert.ToInt32(rbAmount2000.Tag);
            }

            if (rbAmount5000.Checked)
            {
                return Convert.ToInt32(rbAmount5000.Tag);
            }

            return -1;        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_ChooseAmount() != -1)
            {
                if (MessageBox.Show("Are you sure you want to withdraw this amount?", "Withdrawal Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (clsGlobal.CurrentClient.Withdraw(_ChooseAmount()))
                    {
                        MessageBox.Show(("Successfully,Your Balance is: " + clsGlobal.CurrentClient.AccountBalance), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    else
                    {
                        MessageBox.Show("Insufficient balance to complete the transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Withdrawal operation canceled.");
                }

            }


        }
    }
}
