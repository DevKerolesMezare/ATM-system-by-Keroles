using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDataAccessLayer
{
    public class clsLoggerData
    {
        public static void LogToFile(string Message)
        {
            string FileName = "log.txt";

            using (StreamWriter writer = new StreamWriter(FileName, true))
            {
                writer.WriteLine(Message);
            }

        }

    }
}
