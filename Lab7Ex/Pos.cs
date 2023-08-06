using Lab7Ex.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Ex
{
    class Pos
    {
        public static void AcceptPayment(Device dispozitiv, int suma)
        {
            dispozitiv.MakePayment(suma);
        }
    }
}
