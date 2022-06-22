using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Products
{
    class Money
    {
        protected int dollars;
        protected int cents;


        public Money()
        {
            dollars = 0;
            cents = 0;
        }
        public Money(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
            if (cents >= 100)
            {
                this.dollars++;
                this.cents -= 100;
            }
        }

        public int Dollars
        {
            get { return dollars; }
            set { dollars = value; }
        }
        public int Cents
        {
            get { return cents; }
            set
            {
                cents = value;
                while (cents >= 100)
                {
                    dollars++;
                    cents -= 100;
                }
            }
        }
        public void print()
        {
            Console.WriteLine("{0}.{1}", dollars, cents);
        }
    }
}
