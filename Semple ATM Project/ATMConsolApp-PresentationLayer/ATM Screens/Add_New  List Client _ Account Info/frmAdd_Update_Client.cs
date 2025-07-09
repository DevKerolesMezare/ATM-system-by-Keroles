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

namespace ATMConsolApp_PresentationLayer
{
    public partial class frmAdd_Update_Client : Form
    {

       public enum enMode { Update = 1 , AddNew = 0 };
       private enMode Mode = enMode.AddNew;

        int _ClientID = -1;

        clsClient Client1;


        // Learn How To Using Delegate
        public delegate void DataBackEventHandler(object Sender , string AccountNumber , string PinCode);

        public event DataBackEventHandler DataBck; 



        public frmAdd_Update_Client(int ID)
        {
            InitializeComponent();

            _ClientID = ID;

            if (_ClientID != -1)
            {
                Mode = enMode.Update;
            }
            else
            {
                Mode = enMode.AddNew;
            }

        }

        private void _FillCountriesInComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }

        }

        private void llimage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pbImage.Load(selectedFilePath);
                // ...
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (Client1 != null)
            {
                DataBck?.Invoke(this,Client1.AccountNumber , Client1.PinCode);
            }

             this.Close();
        }

        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImage.ImageLocation = null; 
            llRemove.Visible = false;
        }



        private void _LoadData()
        {
            _FillCountriesInComboBox();



            if (Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Client";

                Client1 = new clsClient();
                return;
            }


            Client1 = clsClient.Find(_ClientID);
            if (Client1 == null)
            {
                MessageBox.Show("This form will be closed because No Client with ID =" + _ClientID);

                this.Close();
                return;
            }


            lblTitle.Text = "Edit Client ID = " + _ClientID;

            lblClientID.Text       = _ClientID.ToString();
            txtFirstName.Text      = Client1.FirstName.Trim();
            txtLastName.Text       = Client1.LastName.Trim();
            txtEmail.Text          = Client1.Email;
            txtPhone.Text          = Client1.Phone;
            txtAddress.Text        = Client1.Address;
            txtAccountNumber.Text  = Client1.AccountNumber;
            txtPinCode.Text        = Client1.PinCode;
            txtAccountBalance.Text = Client1.AccountBalance.ToString();

            dtbBirthDate.Value = Client1.DateOfBirth;

            cbCountry.SelectedIndex = cbCountry.FindString(clsCountry.Find(Client1.CountryID).CountryName);

            if (Client1.ImagePath != "")
            {
                pbImage.Load(Client1.ImagePath);
            }

            llRemove.Visible = (Client1.ImagePath != "");
        }


        private void frmAdd_Update_Client_Load(object sender, EventArgs e)
        {       
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            int CountryID = clsCountry.Find(cbCountry.Text).CountryID;

            Client1.FirstName = txtFirstName.Text;
            Client1.LastName = txtLastName.Text;
            Client1.Phone = txtPhone.Text;
            Client1.Address = txtAddress.Text;
            Client1.Email = txtEmail.Text;
            Client1.AccountNumber = txtAccountNumber.Text;
            Client1.PinCode = txtPinCode.Text;
            Client1.AccountBalance = Convert.ToSingle( txtAccountBalance.Text ) ;
            Client1.CountryID = CountryID;
            Client1.DateOfBirth = dtbBirthDate.Value;
           

            if(pbImage.ImageLocation != null)
            {
                Client1.ImagePath = pbImage.ImageLocation;            
            }
            else
            {
                Client1.ImagePath = "";
            }


            if (Client1.Save())
            {
                MessageBox.Show("Data Saved Successfully.");

            }
            else
            {
                bool test = clsClient.IsAccountNumberExist(txtAccountNumber.Text);

                if (clsClient.IsAccountNumberExist(txtAccountNumber.Text))
                {
                    MessageBox.Show("Error: Account Number Is Already Used", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error: Data Is not Saved Successfully.");
                }
            }

            Mode = enMode.Update; 

            lblTitle.Text = "Edit Client ID = " + Client1.ID;
            lblClientID.Text = Client1.ID.ToString();
        }

        private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        {
       
            //if (clsClient.IsAccountNumberExist(txtAccountNumber.Text))
            //{
            //    errorProvider1.SetError(txtAccountNumber , "Account Number Is Alrady Used");
            //    e.Cancel = true;
            //}
            //else
            //{
            //    errorProvider1.SetError(txtAccountNumber, ""); // تمسح الخطأ لو مفيش مشكلة
            //}

        }


        private void ValidateRequiredField(TextBox textBox, CancelEventArgs e, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider1.SetError(textBox, errorMessage);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox, ""); // الأفضل من Clear لو عندك أكثر من ErrorProvider
            }
        }


        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            ValidateRequiredField(txtPhone,e ,"ادخل رقم الهاتف"); 
        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }
    }
}
