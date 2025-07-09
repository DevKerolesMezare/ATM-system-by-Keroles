using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ATMBusinessLayer; 

namespace ATMConsolApp_PresentationLayer
{
    internal class clsGlobal
    {
        public static clsClient CurrentClient = clsClient.Find("" , "");

    }

}
