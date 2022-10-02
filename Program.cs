using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAttribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ДЗ: Доработать обработку списка Emploee и выполнить метод IncreaseWages для John и Jack, 
             * на значение указанные в атрибутах*/

            List<Emploee> emploes = new List<Emploee>();
            emploes.Add(new Emploee() { Id = 1, Name = "John" });

            foreach (MemberInfo member in typeof(Emploee).GetMember("IncreaseWages"))
            {
                foreach (var attr in member.GetCustomAttributes(true))
                {
                    if (emploes[0].Name == "John") 
                    {
                        emploes[0].IncreaseWages(100);
                    }
                    Console.WriteLine(attr + "");
                }
            }

            Console.ReadLine();
        }
    }

    [Coder]
    class Emploee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
        
        [Coder("John", 100)]
        [Coder("Jack", 200)]                
        public void IncreaseWages(decimal wage) 
        {
            Salary += wage;
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple =true)]
    class CoderAttribute : Attribute
    {
        string _name;
        int _wage;
        public CoderAttribute()
        {

        }

        public CoderAttribute(string name, int wage)
        {
            _name = name;
            _wage = wage;
        }

        public override string ToString()
        {
            return $"Coder: {_name}, Date: {_wage}"; 
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    class SaleAttribute : Attribute
    {
        string _name;
        string _datetime;
        public SaleAttribute()
        {

        }

        public SaleAttribute(string name, string datetime)
        {
            _name = name;
            _datetime = datetime;
        }

        public override string ToString()
        {
            return $"Coder: {_name}, Date: {_datetime}";
        }
    }
}
