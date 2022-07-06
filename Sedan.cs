using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegates
{
    class Sedan : Cars
    {
        protected int speed { get; set; }

        public Sedan(int speed)
        {
            this.speed = speed;
        }
        public void Win()
        {
            Console.WriteLine("SEDAN WIN");
        }

        public void Lose()
        {
            Console.WriteLine("SEDAN Lose");
        }
    }
}
