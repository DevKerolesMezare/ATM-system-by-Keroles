using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using ATMDataAccessLayer;

namespace ATMBusinessLayer
{
    public class clsClient
    {
        public enum enMode {AddNew = 0 , Update = 1}
        public enMode Mode = enMode.AddNew;

        public int      ID { set; get; }
        public string   FirstName { set; get; }
        public string   LastName { set; get; }
        public string   Email { set; get; }
        public string   Phone { set; get; }
        public string   Address { set; get; }
        public DateTime DateOfBirth { set; get; }


        public string AccountNumber { get; set; }
        public string PinCode { get; set; }
        public float  AccountBalance { get; set; }
        public string ImagePath { set; get; }
        public int    CountryID { set; get; }
        public string FullName()
        {
            return FirstName + " " + LastName;
        }


        public clsClient()
        {
            this.ID = -1;
            this.FirstName = "";
            this.LastName = "";

            this.DateOfBirth = DateTime.Now;

            this.Email = "";
            this.Address = "";
            this.Phone = "";
            this.ImagePath = "";

            this.CountryID = -1;

            this.AccountNumber = "";
            this.PinCode = "";

            this.AccountBalance = 0;

            Mode = enMode.AddNew;
        }

        private clsClient(int ID,  string FirstName,  string LastName,  DateTime DateOfBirth, 
            string Phone,  string Address,  string Email, 
            string AccountNumber,  string PinCode,  float AccountBalance,
            int CountryID,  string ImagePath)
        {
            this.ID = ID;
            this.FirstName=FirstName; 
            this.LastName=LastName;          
            this.DateOfBirth=DateOfBirth;
            this.Phone=Phone;
            this.Address=Address;
            this.Email =Email;
            
            this.AccountNumber=AccountNumber;
            this.PinCode=PinCode;
            this.AccountBalance=AccountBalance;
          
            this.ImagePath=ImagePath;
            this.CountryID=CountryID;

            Mode = enMode.Update;
        }


        public static clsClient Find(string AccountNumber , string PinCode)
        {

            int ID = -1;
            string FirstName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            string Phone = "";
            string Address = "";
            string Email = "";

            float AccountBalance = 0;

            string ImagePath = "";

            int CountryID = -1;


            if (clsClientData.GetClientByِAccountNumberAndPinCode(AccountNumber, PinCode, ref ID, ref FirstName, ref LastName, ref DateOfBirth, ref Phone, ref Address, ref Email, ref AccountBalance, ref  CountryID, ref ImagePath))
            {
                return new clsClient(ID, FirstName, LastName, DateOfBirth, Phone, Address, Email, AccountNumber, PinCode, AccountBalance, CountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static clsClient Find(int ClientID)
        {

           
            string FirstName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            string Phone = "";
            string Address = "";
            string Email = "";

            string AccountNumber = ""; 
            string PinCode = ""; 

            float AccountBalance = 0;

            string ImagePath = "";

            int CountryID = -1;


            if (clsClientData.GetClientByID(ClientID,ref FirstName,ref LastName,ref DateOfBirth,ref Phone,ref Address,ref Email,ref AccountNumber,ref PinCode,ref AccountBalance,ref CountryID,ref ImagePath))
            {
                return new clsClient(ClientID, FirstName, LastName, DateOfBirth, Phone, Address, Email, AccountNumber, PinCode, AccountBalance, CountryID, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static bool IsAccountNumberExist(string AccountNumber)
        {
           return clsClientData.IsAccountNumberExict(AccountNumber);
        }

        public bool Withdraw(float Amount)
        {

            if (this.AccountBalance < Amount)
                return false;
            
            else
            {
                this.AccountBalance -= Amount;

                if(Save_UpdateAmount())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

           
        }

        public void Deposit(float Amount)
        {
            this.AccountBalance += Amount;

            Save_UpdateAmount();
        }

        bool Save_UpdateAmount ()
        {
            if (ATMDataAccessLayer.clsClientData.UpdateAccountBalance(this.ID, this.AccountBalance))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void ChangePinCode(string PinCode)
        {

            if(PinCode == "")
                { return; }


            this.PinCode = PinCode;

            clsClientData.UpdatePINCode(this.ID, this.PinCode);
        }


        public static DataTable GetAllClients()
        {
            return clsClientData.GetAllClients();
        }
        private bool _AddNewClient()
        {
            this.ID = clsClientData.AddNewClient(this.FirstName , this.LastName ,
                this.DateOfBirth , this.Phone, this.Address , this.Email , 
                this.AccountNumber , this.PinCode , this.AccountBalance 
                ,this.CountryID , this.ImagePath);

            return (this.ID != -1);
        }

        private bool _UpdateClient()
        {
            return (clsClientData.UpdateClientInfo(this.ID  ,this.FirstName, this.LastName,
                this.DateOfBirth, this.Phone, this.Address, this.Email,
                this.AccountNumber, this.PinCode, this.AccountBalance
                , this.CountryID, this.ImagePath));
        }

        public static bool DeleteClient(int ClientID)
        {
            return clsClientData.DeleteCLientByClientID(ClientID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewClient())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    
                    case enMode.Update:
                    {
                        return _UpdateClient();                     
                    }
            }

            return false;
        }

        ////////////////////////////////////////////
        //             تحويل العملات               //       
        ////////////////////////////////////////////
        
        public bool ConvertEGPToUSD(float Amount)
         {
             //float A = (Amount * 0.020f);

             if (Withdraw(Amount))
             {
                 return true;
             }

             return false;
         }

         public bool ConvertEGPToEUR(float Amount)
         {
            // float A = (Amount * 0.017f);

             if (Withdraw(Amount))
             {
                 return true;
             }

             return false;
         }

         public bool ConvertoUSDToEGY(float Amount)
         {
             float A = Amount * 51;

             Deposit(A);

             return true;
         }

         public bool ConvertEURToEGP(float Amount)
         {
             float A = (Amount * 57.85f);

             Deposit(A);

             return true;
         }

    }
}
