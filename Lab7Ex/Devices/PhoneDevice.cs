using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Lab7Ex.Interfaces;

namespace Lab7Ex.Devices
{
    public class PhoneDevice : Device, IContactless 
    {
        public PhoneDevice(string Nume) : base(Nume) { }

        public void ApproachCard()
        {
            Console.WriteLine($"Please approach the PHONE.");
        }

        public override void MakePayment(int amount)
        {
            ApproachCard();
            base.MakePayment(amount);
        }
    }
}
