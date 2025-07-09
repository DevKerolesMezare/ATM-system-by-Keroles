using ATMBusinessLayer;
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
    public partial class frmChangePinCode : Form
    {
        public frmChangePinCode()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void _ChangePinCode()
        {

            if (txtNewPin.Text == "" || txtPinCode.Text == "" || txtNewPin2.Text == "")
            {
                MessageBox.Show("Invalid data entry, try again", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (clsGlobal.CurrentClient.PinCode == txtPinCode.Text)
            {
                if (txtPinCode.Text == txtNewPin.Text && txtNewPin.Text == txtNewPin2.Text)
                {
                    MessageBox.Show("The passwords cannot be the same. Please enter different passwords.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtNewPin.Text == txtNewPin2.Text)
                {
                    if (MessageBox.Show("Are you sure you want to change your PIN?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        clsGlobal.CurrentClient.ChangePinCode(txtNewPin.Text);
                        MessageBox.Show("Success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("PIN change has been cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("The current password does not match! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The current password is incorrect! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ChangePinCode();
        }
    }
}
