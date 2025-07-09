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
    public partial class frmTestAddNew : Form
    {
        public frmTestAddNew()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (clsTest.Test())
            {
                MessageBox.Show("Client Added Successfuly.");
                button5.Enabled = false;
            }
            else
            {
                MessageBox.Show("Client Added Falid.");
            }
        }
    }
}
