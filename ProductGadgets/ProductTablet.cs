using Exam.Shop.ProductBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.ProductGadgets
{
    public class ProductTablet : ProductGadget
    {
        public int Weigth { get; set; }
        public string CPU { get; set; }
        public string DDR { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} | Name:{Name} | Create:{Create:dd-MM-yyyy HH:mm} | Change:{Change:dd-MM-yyyy HH:mm} | Weigth:{Weigth} | CPU:{CPU} | DDR:{DDR}";
        }
    }
}
