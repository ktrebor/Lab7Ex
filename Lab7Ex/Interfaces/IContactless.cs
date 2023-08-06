using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Ex.Interfaces
{
    interface IContactless : IPayable
    {
        void ApproachCard();
    }
}
