using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegates
{
    abstract class Cars
    {
        private int speed = 0;

        public int Ride()
        {
            Console.WriteLine($"Car riding with speed: {speed}");
            return speed;
        }
        public void Win()
        {
            Console.WriteLine("CAR WIN");
        }
        public void Lose()
        {
            Console.WriteLine("CAR Lose");
        }
    }
}
