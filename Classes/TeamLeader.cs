using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Classes
{
    class TeamLeader : Interfaces.IWorker
    {
        public void Work()
        {
            Console.WriteLine("ControllingBuildingProccess();");
        }
        public void Finish()
        {
            Console.WriteLine("Building Process has finished");
        }
    }
}
