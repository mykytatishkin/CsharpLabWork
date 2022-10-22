using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Customer
{
    public class Customers
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public decimal Balance { get; set; }
        public DateTime Create { get; set; }
        public DateTime Change { get; set; }
    }
}
