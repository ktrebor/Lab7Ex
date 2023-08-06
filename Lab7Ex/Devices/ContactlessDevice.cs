using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Ex.Devices
{
    public class ContactlessDevice : Device, IContactfull, IContactless
    {
        public ContactlessDevice(string Name) : base(Name) {}

        public void ApproachCard()
        {
            Console.WriteLine($"Please approach the CONTACTLESSCARD.");
        }

        public void InsertDevice()
        {
            Console.WriteLine("Please insert the CONTACTLESSCARD");
        }

        public void RemoveDevice()
        {
            Console.WriteLine("Please remove the CONTACTLESSCARD");
        }

        public override void MakePayment(int amount, bool contactless)
        {
            if (contactless)
            {
                ApproachCard();
                base.MakePayment(amount);
            }
            else
            {
                InsertDevice();
                base.MakePayment(amount);
                RemoveDevice();
            }
        }
    }
}
