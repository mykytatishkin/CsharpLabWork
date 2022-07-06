using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegates
{
    internal class Program
    {
        public delegate void CarRiding();

        static void Main(string[] args)
        {
            CarRiding carRiding;

            MyDelegates.Bus bus = new MyDelegates.Bus(50);
            MyDelegates.Sedan sedan = new MyDelegates.Sedan(90);
            MyDelegates.SportCar sportCar = new MyDelegates.SportCar(120);


            carRiding = Tournament;

            Console.WriteLine(carRiding);

            void Tournament()
            {
                sportCar.Win();
                sedan.Lose();
                bus.Lose();
            }

        }
    }
}
