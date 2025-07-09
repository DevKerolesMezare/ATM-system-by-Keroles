using ATMBusinessLayer;
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

namespace ATMConsolApp_PresentationLayer.ATM_Screens
{
    public partial class frmListClients : Form
    {
        public frmListClients()
        {
            InitializeComponent();
        }

        private static DataTable _dtClients = clsClient.GetAllClients();


        private void _GetAllClients()
        {

            dgvClients.DataSource = _dtClients;
            lblRecords.Text = _dtClients.Rows.Count.ToString();

            if (dgvClients.Rows.Count > 0)
            {

                dgvClients.Columns[0].HeaderText = "Client ID";
                dgvClients.Columns[0].Width = 90;

                dgvClients.Columns[1].HeaderText = "Name";
                dgvClients.Columns[1].Width = 150;

                dgvClients.Columns[2].HeaderText = "BirthDate";
                dgvClients.Columns[2].Width = 120;
                
                dgvClients.Columns[3].HeaderText = "Phone";
                dgvClients.Columns[3].Width = 100;



                dgvClients.Columns[4].HeaderText = "AccountNumber";
                dgvClients.Columns[4].Width = 110;



                dgvClients.Columns[5].HeaderText = "PinCode";
                dgvClients.Columns[5].Width = 110;



                dgvClients.Columns[6].HeaderText = "AccountBalance";
                dgvClients.Columns[6].Width = 110;


                dgvClients.Columns[7].HeaderText = "Country Name";
                dgvClients.Columns[7].Width = 120;

            }


        }
   

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            frmAdd_Update_Client frm = new frmAdd_Update_Client(-1);

            frm.ShowDialog();
        }

   

        private void frmListClients_Load(object sender, EventArgs e)
        {
            _GetAllClients();
        }

    
        private void _RefreshClientsList()
        {
            _dtClients = clsClient.GetAllClients();


            dgvClients.DataSource = _dtClients;
            lblRecords.Text = dgvClients.Rows.Count.ToString();
        }
    

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_Update_Client frm = new frmAdd_Update_Client((int)dgvClients.CurrentRow.Cells[0].Value);
            frm.ShowDialog();


            _RefreshClientsList();
        }

        private void seleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // easy (:-+

            if(MessageBox.Show("Are You Sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                if (clsClient.DeleteClient((int)dgvClients.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Client Deleted Succssfuly!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Canceled!" , "Message" , MessageBoxButtons.OK , MessageBoxIcon.Stop);
            }

                _RefreshClientsList();

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string AccountNumber = (dgvClients.CurrentRow.Cells[4].Value).ToString();
            string PinCode = (dgvClients.CurrentRow.Cells[5].Value).ToString();


            frmLogin frmLogin = new frmLogin(AccountNumber , PinCode);
            frmLogin.ShowDialog();
        }
    }
}
