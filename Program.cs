using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleSerialized
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Реализовать для класса Address, сериализацию/десеаризацию внтутри Person
            */

            var itemsList = new PersonList()
            {
                new Person() { Id = 1, Age = 18, Name = "John" },
                new Person() { Id = 2, Age = 20, Name = "Jack" }
            };

            SoapFormatter soapFormatter = new SoapFormatter();

            using (Stream stream = File.Create("test.soap"))
            {
                soapFormatter.Serialize(stream, itemsList);
            }

            using (Stream stream = File.OpenRead("test.soap"))
            {
                var deItem = (PersonList)soapFormatter.Deserialize(stream);
            }
        }
    }

    [Serializable]
    public class PersonList : List<Person> 
    {
        
    }

    class Address
    {
        public int Postcode { get; set; }
        public string Street { get; set; }
    }
    [Serializable]
    public class Person : ISerializable
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        private Address address { get; set; }

        public Person()
        {

        }

        public Person(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("FullName");
            Age = info.GetInt32("Age");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("FullName", Name);
            info.AddValue("Age", Age);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }


    }
}
