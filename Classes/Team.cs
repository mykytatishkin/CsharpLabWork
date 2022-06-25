using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Classes
{
    class Team : Interfaces.IWorker
    {
        public void Work()
        {
            Console.WriteLine("BuildingHouse();");
        }
        public void Finish()
        {
            Console.WriteLine("Finishing1Element");
        }
    }
}
