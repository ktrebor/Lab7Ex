using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Ex.Devices
{
    public class ContactfullDevice: Device, IContactfull
    {
        public ContactfullDevice(string Nume) : base(Nume) { }

        public void InsertDevice()
        {
            Console.WriteLine("Please insert the CARD");
        }

        public void RemoveDevice()
        {
            Console.WriteLine("Please remove the CARD");
        }

        public override void MakePayment(int amount)
        {
            InsertDevice();
            base.MakePayment(amount);
            RemoveDevice();
        }
    }
}
