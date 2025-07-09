using ATMBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMConsolApp_PresentationLayer
{
    public partial class frmTest : Form
    {  
        public int ClientID = -1; 

        public frmTest(int ID)
        {
            InitializeComponent();

            ClientID = ID; 

            clsClient Client1 = clsClient.Find(ClientID);

            if (Client1 != null ) 
               {

                textBox1.Text = Client1.AccountNumber;
                textBox2.Text = Client1.PinCode;

                if (Client1.ImagePath != "")
                {
                    pictureBox1.Load(Client1.ImagePath);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
 
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
            linkLabel1.Visible = (pictureBox1.ImageLocation != null);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(clsGlobal.CurrentClient.Withdraw(Convert.ToInt32(textBox3.Text)))
            {
                MessageBox.Show(("تمت العمليه بنجاح رصيك الحالي{0}؟", clsGlobal.CurrentClient.AccountBalance).ToString());
            }
            else
            {
                MessageBox.Show("The operation was not, because be your current balance is lower than the required amount." , "فشلت العملية");
            }

            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            clsGlobal.CurrentClient.Deposit(Convert.ToInt32(textBox3.Text));

            MessageBox.Show(("Done! {0}",clsGlobal.CurrentClient.AccountBalance).ToString());

            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentClient.ChangePinCode(textBox4.Text.ToString());


            MessageBox.Show(("Success, new PinCode is: ",clsGlobal.CurrentClient.PinCode).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentClient.Withdraw(Convert.ToInt32(radioButton1.Tag)))
            {
                MessageBox.Show(("تمت العمليه بنجاح رصيك الحالي{0}؟", clsGlobal.CurrentClient.AccountBalance).ToString());
            }
            else
            {
                MessageBox.Show("لا يوجد رصيد كافي", "فشلت العملية");
            }

            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
