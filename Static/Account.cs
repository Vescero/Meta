using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Account
    {
        internal static decimal bonus = 100;
        internal decimal totalSum;
        public Account (decimal sum)
        {
            totalSum = sum + bonus;
        }
    }
}
