using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegates
{
    internal class Bus : Cars
    {
        protected int speed { get; set; }

        public Bus(int speed)
        {
            this.speed = speed;
        }
        public void Win()
        {
            Console.WriteLine("BUS WIN");
        }

        public void Lose()
        {
            Console.WriteLine("BUS Lose");
        }
    }
}
