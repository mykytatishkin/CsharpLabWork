using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Devices
{
    class Chaynik : Devices.Device
    {
        protected string name;
        public Chaynik(string name) : base(name)
        {
            this.name = name;
        }

    }
}
