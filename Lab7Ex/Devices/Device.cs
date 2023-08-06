using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab7Ex.Interfaces;

namespace Lab7Ex.Devices
{
    public abstract class Device : IPayable
    {
        protected string Name { get; }
        protected Guid IdDevice { get; }

        public Device(string Name)
        {
            this.IdDevice = Guid.NewGuid();
            this.Name = Name;
        }
        
        public virtual void MakePayment(int amount)
        {
            Console.WriteLine($"The payment of {amount} was made from {Name} device. ID {IdDevice}");
        }

        public virtual void MakePayment(int amount, bool contactless)
        {
            Console.WriteLine($"The payment of {amount} was made from {Name} device. ID {IdDevice}");
        }
    }
}
