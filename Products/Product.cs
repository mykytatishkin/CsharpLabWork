using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Products
{
    class Product : Money
    {
        protected int productDollar;
        protected int productCent;

        public Product()
        {
            productDollar = 0;
            productCent = 0;
        }
        public Product(int dollarsNe, int centsNe)
        {
            productDollar = dollarsNe;
            productCent = centsNe;
            if (centsNe >= 100)
            {
                productDollar++;
                productCent -= 100;
            }
        }


        public void print()
        {
            Console.WriteLine($"{productDollar}.{productCent}");
        }
        public string MakePriceLess(int priceDollars, int priceCent)
        {
            productDollar -= priceDollars;
            productCent -= priceCent;

            return $"{productDollar}.{productCent}";
        }
    }
}
