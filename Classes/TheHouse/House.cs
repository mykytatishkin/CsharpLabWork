using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Classes.TheHouse
{
    class House : Interfaces.IPart
    {
        public void bePart()
        {
            Console.WriteLine("House have been completed");
        }

        public void intallingPart()
        {
            Console.WriteLine("installingHouse()");
        }

        public void removingPart()
        {
            Console.WriteLine("removingHouse()");
        }
    }
}
