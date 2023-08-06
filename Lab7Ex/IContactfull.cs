using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Ex
{
    interface IContactfull : IPayable
    {
        void InsertDevice();
        void RemoveDevice();
    }
}
