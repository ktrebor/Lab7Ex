using Lab7Ex.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Ex
{
    class Pos
    {
        protected string Name { get; set; }

        public Pos(string Name)
        {
            this.Name = Name;
        }

        public static void AcceptPayment(Device dispozitiv, int suma)
        {
            dispozitiv.MakePayment(suma);
        }
    }
}
