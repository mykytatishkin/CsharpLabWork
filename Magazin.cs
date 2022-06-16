using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOperatorOverloading
{
    class Magazin
    {
        protected int countOfPages;
        public Magazin(int countOfPages)
        {
            this.countOfPages = countOfPages;
        }

        public int CountOfPages
        {
            get { return countOfPages; }
            set { countOfPages = value; }
        }

        public static Magazin operator +(Magazin a, int b) => new Magazin(a.countOfPages + b);
        public static Magazin operator -(Magazin a, int b) => new Magazin(a.countOfPages + (-b));
        public static bool operator >(Magazin a, Magazin b) 
        {
            return a.countOfPages > b.countOfPages;
        }
        public static bool operator <(Magazin a, Magazin b)
        {
            return a.countOfPages < b.countOfPages;
        }
        public static bool operator ==(Magazin a, Magazin b)
        {
            return a.countOfPages == b.countOfPages;
        }
        public static bool operator !=(Magazin a, Magazin b)
        {
            return a.countOfPages != b.countOfPages;
        }
    }
}
