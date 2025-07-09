using System;

using ATMDataAccessLayer;


namespace ATMBusinessLayer
{
    public class clsLogData
    {   
        public static void LogDataToFile(string Message)
        {
            clsLoggerData.LogToFile(Message); 
        }     
        
    }
}
