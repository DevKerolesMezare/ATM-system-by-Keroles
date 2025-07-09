using ATMConsolApp_PresentationLayer.ATM_Screens;
using ATMConsolApp_PresentationLayer.Transactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMConsolApp_PresentationLayer
{
    public partial class frmMainMenue : Form
    {
        public frmMainMenue()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListClients frmListClients = new frmListClients();
            
            frmListClients.ShowDialog();
        }
    }
}
