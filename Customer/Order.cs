using Exam.Shop.ProductBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Customer
{
    public class Order
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Customers Customers { get; set; }
        public decimal OrderSum { get; set; }
        public DateTime Create { get; set; }
    }
}
