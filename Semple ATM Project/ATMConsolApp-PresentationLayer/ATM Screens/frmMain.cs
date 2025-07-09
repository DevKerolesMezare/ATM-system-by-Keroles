using ATMConsolApp_PresentationLayer.ATM_Screens;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void accountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePinCodeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmChangePinCode();
            frm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showAccountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientInfo frmClientInfo = new frmClientInfo();
            frmClientInfo.ShowDialog();
        }

        private void depositToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDeposit frmDeposit = new frmDeposit();
            frmDeposit.ShowDialog();
        }

        private void quckWiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmQuickWithdraw();
            frm.ShowDialog();
        }

        private void normalWithdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNormalWithdraw frmNormalWithdraw = new frmNormalWithdraw();

            frmNormalWithdraw.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCurrencyExchange frmCurrencyExchange = new frmCurrencyExchange();    
            frmCurrencyExchange.ShowDialog();
        }
    }
}
