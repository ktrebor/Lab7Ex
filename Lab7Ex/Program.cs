using Lab7Ex.Devices;
using System;

namespace Lab7Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pos = new Pos("POS ak9292lo");
            
            var iPhone = new PhoneDevice("iPhone 20XXL");
            iPhone.MakePayment(100);

            var bcrOldCard = new ContactfullDevice("bcr Old Card");
            bcrOldCard.MakePayment(200);

            var bcrNewCard = new ContactlessDevice("bcr contaless card");
            bcrNewCard.MakePayment(20, true);
            bcrNewCard.MakePayment(30);

            var casaDeMarcat = new CasaDeMarcat();
            casaDeMarcat.CashPayment(50);
      
        }
    }
}
