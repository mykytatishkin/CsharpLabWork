using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.ExceptionBase
{
    public class BalanceLowException : Exception
    {
        public void BalanceLowExceptions()
        {
            Console.WriteLine("Not enough money");
        }
    }
}
