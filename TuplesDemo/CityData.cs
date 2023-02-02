using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuplesDemo
{
    public class CityData
    {
        private string _city;
        private string _country;

        public CityData() : this("unknown", "unknown") { }

        public CityData(string city, string country) { 
            _city = city;
            _country = country;
        }

        public string City { get { return _city; }  }

        public string Country { get { return _country;} }

        public (string,string,string,string) GetCityData()
        {
            string cityCountry = $"{City}-{Country}";
            string countryCity = $"{Country}-{City}";

            return (City, Country, cityCountry, countryCity);
        }

        public (string, int) GetInhabitants()
        {
            return (City, 134976);
        }
    }
}
