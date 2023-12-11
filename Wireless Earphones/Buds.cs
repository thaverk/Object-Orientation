using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Wireless_Earphones
{
    internal class Buds
    {

        public string powerON;
        public string brand;
        public string colour;
        public string bluetooth;

        







        public Buds(bool PowerOn, bool Bluetooth, string Brand, string Color)
        {
            brand = Brand;
           colour = Color;

            if (Bluetooth)
            {
                bluetooth = "Bluetooth is connected";
            }
            else
            {
                bluetooth = "Bluetooth is not connected";
            }

            if (PowerOn)
            {
                powerON = "Power is on";
            }
            else
            {
                powerON = "Power is off";
            }



        }

        




    }
}