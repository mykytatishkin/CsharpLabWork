using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork
{
    internal class City
    {
        private String city;
        private String country;
        private int peopleCount;
        private int cityPhoneCode;
        private String[] cityParts = { };

        public City(string city, string country, int peopleCount, int cityPhoneCode, string[] cityPartsring)
        {
            this.city = city;
            this.country = country;
            this.peopleCount = peopleCount;
            this.cityPhoneCode = cityPhoneCode;
            this.cityParts = cityParts;
        }

        public String CCity
        {
            get { return city; }
            set { city = value; }
        }
        public String Country
        {
            get { return country; }
            set { country = value; }
        }
        public int PeopleCount
        {
            get { return peopleCount; }
            set { peopleCount = value; }
        }
        public int CityPhoneCode
        {
            get { return cityPhoneCode; }
            set { cityPhoneCode = value; }
        }
        public String[] CityParts
        {
            get { return cityParts; }
            set { cityParts = value; }
        }
    }
}
