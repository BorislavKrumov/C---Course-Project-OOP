using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInventoryManagement
{
    interface ISum
    {
     decimal Sum(int quantity, decimal price);
    }
}
