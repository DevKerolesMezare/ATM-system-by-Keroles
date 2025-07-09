using ATMBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATMConsolApp_PresentationLayer.Transactions
{

    public partial class ctrlClientInfo : UserControl
    {

       


        public ctrlClientInfo()
        {
            InitializeComponent();
        }

        private void _FillClientInfo()
        {

            clsClient ClientInfo = clsGlobal.CurrentClient;


            if (ClientInfo != null)
            {
                lblClientID.Text       = ClientInfo.ID.ToString();
                lblFullName.Text       = ClientInfo.FullName();
                lblPhone.Text          = ClientInfo.Phone;
                lblEmail.Text          = ClientInfo.Email;
                lblAddress.Text        = ClientInfo.Address;
                lblAccountNU.Text      = ClientInfo.AccountNumber;
                lblPinCode.Text        = ClientInfo.PinCode;
                lblAccountB.Text       = (ClientInfo.AccountBalance).ToString() + " EGP";

                if(ClientInfo.ImagePath != "")   // التحقق من ان الصوره موجوده
                {
                    pbClientImage.SizeMode = PictureBoxSizeMode.Zoom;

                    // تحميل الصوره الخاصه بالشخص الحالي
                    pbClientImage.Load(ClientInfo.ImagePath); 
                }

            }

 
        }

        private void ctrlClientInfo_Load(object sender, EventArgs e)
        {
            _FillClientInfo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
