using System.Diagnostics;
using ATMBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ATMConsolApp_PresentationLayer.Transactions
{
    public partial class frmLogin : Form
    {
        // غير مستخدمين لاكنهم بيجيبو ليا الداتا من الداتا باك
        private string _AccountNumber = "";  
        private string _PinCode = "";


        // Used in _CheckLoginFailed()
        private short _FailedLoginCount = 0;
        private string _sAccessTrials = "";


        public frmLogin()
        {
            InitializeComponent();
        }
        public frmLogin(string AccountNumber , string PinCode)
        {
            InitializeComponent();


            if (AccountNumber != "" && PinCode != "")
            {
                this._AccountNumber = AccountNumber;
                this._PinCode = PinCode;
            }
        }


        //   Logging Example     ___ Event Viewer
        private void _LogFaildLoginError(string message ,EventLogEntryType entryType)
        {
            string SourceApp = "ATM_System";

            try
            {
                if (!EventLog.SourceExists(SourceApp))
                {
                    EventLog.CreateEventSource(SourceApp, "Application");
                }

                EventLog.WriteEntry(SourceApp , message, entryType);
            }
            catch (Exception ex)
            {
                // Error
            }

        }

        private bool _CheckLoginFailed()
        {
            bool LoginFaild = false;    

            do
            {
                if(LoginFaild == false)
                {
                    _FailedLoginCount++;
                    _sAccessTrials += ($"[Failed: Trial:{_FailedLoginCount}  AccountNumber:{txtAccountNumber.Text}  PinCode:{txtPinCode.Text} ]\n");

                    MessageBox.Show("Login Failed" ,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    MessageBox.Show($"You have {3 - _FailedLoginCount} Trials to login." , "Message" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
                }

                if(_FailedLoginCount == 3 )
                {
                    _LogFaildLoginError($"You are looked after 3 faild trails \n {_sAccessTrials}", EventLogEntryType.Error);

                    MessageBox.Show("You are looked after 3 faild trails", "Message" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();       
                    return false;
                }

                LoginFaild = (clsGlobal.CurrentClient != null);

            } while (LoginFaild);

            return true;
        }


        // Class Logger Example
        private string _DataLogSavingToFile(string separator = "  -  ")
        {
            string MessageInfoToLine = "Login Registry To System: \n";
             MessageInfoToLine += "Record Info: ";

            if (clsGlobal.CurrentClient != null)
            {
                MessageInfoToLine += "Login Successful" + separator;
                MessageInfoToLine += "Client Name: " + clsGlobal.CurrentClient.FullName() + separator;
                MessageInfoToLine += "Client ID: " + clsGlobal.CurrentClient.ID.ToString() + separator;
            }
            else
            {
                MessageInfoToLine += "Login Failed" + separator;
            }

            MessageInfoToLine +="Date Time: "+ DateTime.Now.ToString() + separator;
            MessageInfoToLine += "Account Number: " + txtAccountNumber.Text + separator;
            MessageInfoToLine += "PinCode:" + txtPinCode.Text + "\n";

            return MessageInfoToLine;
        }


        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsLogger  LogToFile = new clsLogger(clsLogData.LogDataToFile);

            clsGlobal.CurrentClient = clsClient.Find(txtAccountNumber.Text , txtPinCode.Text);
            LogToFile.Log(_DataLogSavingToFile());


            if (clsGlobal.CurrentClient != null )          
             {
                txtAccountNumber.Text = "";
                txtPinCode.Text = "";

                MessageBox.Show("login Successfully", "Message",MessageBoxButtons.OK , MessageBoxIcon.Information);
                frmMain frm = new frmMain();
                frm.ShowDialog();

            }
            else
            {              
                _CheckLoginFailed();
               // MessageBox.Show("Login Failed , Try again" ,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
   
        }


        private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtAccountNumber, "ادخل رقم الحساب..");
            if (string.IsNullOrWhiteSpace(txtAccountNumber.Text)) 
            { 
                txtAccountNumber.Focus();
            }

            else
            {
                errorProvider1.Clear();
            }

        }

        private void txtPinCode_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(txtPinCode, "ادخل الرقم السري..");

            if (string.IsNullOrWhiteSpace(txtPinCode.Text))
            { 
                txtPinCode.Focus(); 
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdd_Update_Client frm = new frmAdd_Update_Client(-1);
            frm.DataBck += _DataBack; 
            frm.ShowDialog();
        }

        private void _DataBack(object Sender , string AccountNumber , string PinCode)
        {
            txtAccountNumber.Text = AccountNumber;
            txtPinCode.Text = PinCode;


            // ملهمش لازمه حاليا
            this._AccountNumber = AccountNumber;
            this._PinCode = PinCode;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _sAccessTrials = "";
            _FailedLoginCount = 0;

            if (!string.IsNullOrEmpty(_AccountNumber) && !string.IsNullOrEmpty(_PinCode))
            {
                txtAccountNumber.Text = _AccountNumber;
                txtPinCode.Text = _PinCode;
            }
        }
    }
}
