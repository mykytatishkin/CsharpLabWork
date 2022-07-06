using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegates
{
    class SportCar : Cars
    {
        protected int speed { get; set; }

        public SportCar(int speed)
        {
            this.speed = speed;
        }
        public void Win()
        {
            Console.WriteLine("SPORTCAR WIN");
        }

        public void Lose()
        {
            Console.WriteLine("SPORTCAR Lose");
        }
    }
}
