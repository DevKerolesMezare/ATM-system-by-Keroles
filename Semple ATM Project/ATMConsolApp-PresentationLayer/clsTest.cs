using ATMBusinessLayer;
using System;





namespace ATMConsolApp_PresentationLayer
{
    public class clsTest
    {
        public static bool Test()
        {
            clsClient NewClient = new clsClient();
    
            
            NewClient.FirstName = "Kerolse";
            NewClient.LastName = "Mezare";
            NewClient.DateOfBirth = new DateTime(2005 , 9 , 6);
            NewClient.Email = "KokoAlngar@Gmail.com";
            NewClient.Phone = "01029541543";
            NewClient.Address = "Street 3";
            NewClient.AccountNumber = "A1023";
            NewClient.PinCode = "1234";
            NewClient.AccountBalance = 90000;
            NewClient.ImagePath = "";
            NewClient.CountryID = 1;

            if (NewClient.Save())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
