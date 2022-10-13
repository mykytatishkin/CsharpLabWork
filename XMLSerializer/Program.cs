using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerializ
{
    public class XMLS
    {
        [XmlAttribute]
        public string Name { get; set; }
        public double Value { get; set; }
        public string Date { get; set; }
        
        public void Save(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(XMLS));
                XML.Serialize(stream, this);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            XMLS xmls = new XMLS();
            xmls.Name = "HP Laptop";
            xmls.Value = 36456.99;
            xmls.Date = "2022";
            xmls.Save("1.xml");
        }
    }
}
