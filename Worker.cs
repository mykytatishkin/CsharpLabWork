using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingLabo
{
    class Worker
    {
        protected int salary = 0;
        public Worker()
        {
            this.salary = 0;
        }
        public Worker(int salary)
        {
            this.salary = salary;
        }

        public int Salary
        {
            get { return salary; }
            set { this.salary = value; }
        }

        public static Worker operator +(Worker a, int b) => new Worker(a.salary + b);
        public static Worker operator -(Worker a, int b) => new Worker(a.salary - b);
        public static bool operator ==(Worker a, Worker b)
        {
            return a.salary == b.salary;
        }
        public static bool operator !=(Worker a, Worker b)
        {
            return a.salary != b.salary;
        }
    }
}
