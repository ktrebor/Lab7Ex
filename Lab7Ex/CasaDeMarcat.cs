using Lab7Ex.Devices;
using Lab7Ex.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab7Ex
{
    class CasaDeMarcat : IPayableCard, IPayableCash
    {
        public CasaDeMarcat()
        {

        }

        public void CardPayment(int amount)
        {
            SendAmount(amount);
        }

        public void CashPayment(int amount)
        {
            OpenSeif();
            InsertAmount(amount);
            CloseSeif();
            PrintReceipt();
            MakePayment(amount);
        }

        public void CloseSeif()
        {
            Console.WriteLine("Closing the seif");
        }

        public void InsertAmount(int amount)
        {
            Console.WriteLine($"Insert {amount} in the seif.");
        }

        public void MakePayment(int amount)
        {
            Console.WriteLine($"Cash payment of {amount} was Cashed in.");
        }

        public void OpenSeif()
        {
            Console.WriteLine("Opening the seif");

        }

        public void PrintReceipt()
        {
            Console.WriteLine("Printing the receipt");

        }

        public void SendAmount(Pos pos, int amount)
        {
            Console.WriteLine($"Sending the {amount}");
        }
    }
}
