using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Ex.Interfaces
{
    interface IPayableCash : IPayable
    {
        void OpenSeif();
        void InsertAmount(int amount);
        void CloseSeif();
        void PrintReceipt();
    }
}
