using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Devices
{
    class Device
    {
        protected string name { get; set; }

        public Device(string name)
        {
            this.name = name;
        }
        public void Sound()
        {
            Console.WriteLine("Sound()");
        }
        public void Show()
        {
            Console.WriteLine(name);
        }
    }
}
