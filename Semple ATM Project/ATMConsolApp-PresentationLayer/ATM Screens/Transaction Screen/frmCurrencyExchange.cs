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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace ATMConsolApp_PresentationLayer.ATM_Screens
{
    public partial class frmCurrencyExchange : Form
    {
        public frmCurrencyExchange()
        {
            InitializeComponent();
        }

        private void _UpadateLable()
        {
            if (listBox1.SelectedIndex == 0)
            {
                lblSubTitle.Text = "EGP TO USD";
                return;
            }


            if (listBox1.SelectedIndex == 1)
            {
                lblSubTitle.Text = "EGP TO EUR";
                return;
            }

            if (listBox1.SelectedIndex == 2)
            {
                lblSubTitle.Text = "USD TO EGP";
                return;
            }

            if (listBox1.SelectedIndex == 3)
            {
                lblSubTitle.Text = "EUR TO EGP";
                return;
            }

        }

        private void _TransactionType()
        {
            if (clsGlobal.CurrentClient == null)
                return;

            if (textBox1.Text == "")
                return;

            float Amount = Convert.ToSingle(textBox1.Text);


            if (listBox1.SelectedIndex == 0)
            {
                if (MessageBox.Show(
                    "Are you sure you want to proceed with the currency conversion?",
                    "Confirm Currency Exchange",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsGlobal.CurrentClient.ConvertEGPToUSD(Amount))
                    {
                        MessageBox.Show($"Conversion successful.\nCurrent Balance: {clsGlobal.CurrentClient.AccountBalance} EGP", "Currency Exchange", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"Insufficient balance.\nCurrent Balance: {clsGlobal.CurrentClient.AccountBalance} EGP", "Currency Exchange", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Conversion canceled.", "Currency Exchange", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


            if (listBox1.SelectedIndex == 1)
            {

                if (MessageBox.Show(
                    "Are you sure you want to proceed with the currency conversion?",
                    "Confirm Currency Exchange",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question) == DialogResult.Yes)

                {


                    if (clsGlobal.CurrentClient.ConvertEGPToEUR(Amount))
                    {
                        MessageBox.Show($"Conversion successful.\nCurrent Balance: {clsGlobal.CurrentClient.AccountBalance} EGP", "Currency Exchange", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"Insufficient balance.\nCurrent Balance: {clsGlobal.CurrentClient.AccountBalance} EGP", "Currency Exchange", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Conversion canceled.", "Currency Exchange", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


            if (listBox1.SelectedIndex == 2)
            {
                if (MessageBox.Show(
                   "Are you sure you want to proceed with the currency conversion?",
                   "Confirm Currency Exchange",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    if (clsGlobal.CurrentClient.ConvertoUSDToEGY(Amount))
                    {
                        MessageBox.Show($"Conversion successful.\nCurrent Balance: {clsGlobal.CurrentClient.AccountBalance} EGP", "Currency Exchange", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"Insufficient balance.\nCurrent Balance: {clsGlobal.CurrentClient.AccountBalance} EGP", "Currency Exchange", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Conversion canceled.", "Currency Exchange", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }


            if (listBox1.SelectedIndex == 3)
            {

                if (MessageBox.Show(
               "Are you sure you want to proceed with the currency conversion?",
               "Confirm Currency Exchange",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    if (clsGlobal.CurrentClient.ConvertEURToEGP(Amount))
                    {
                        MessageBox.Show($"Conversion successful.\nCurrent Balance: {clsGlobal.CurrentClient.AccountBalance} EGP", "Currency Exchange", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"Insufficient balance.\nCurrent Balance: {clsGlobal.CurrentClient.AccountBalance} EGP", "Currency Exchange", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            else
            {
                MessageBox.Show("Conversion canceled.", "Currency Exchange", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            }




            MessageBox.Show("No operation selected.\nPlease select a valid operation to proceed.", "Currency Exchange", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;

        }

        private bool _ValidateAmount()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "ادخل المبلغ.");
                textBox1.Focus();
                return false;
            }


            float amount;

            if (!float.TryParse(textBox1.Text, out amount))
            {
                errorProvider1.SetError(textBox1, "Please enter a valid number.");
                textBox1.Focus();
                return false;
            }

            errorProvider1.SetError(textBox1, ""); // مفيش أخطاء
            return true;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _UpadateLable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _TransactionType();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            button1.Enabled = (_ValidateAmount());

            if (!_ValidateAmount())
            {
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
