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

        public (string, double, int, int, int, int) QueryCityDataForYears(string name, int year1, int year2)
        {
            int population1 = 0, population2 = 0;
            double area = 0;

            if (name == "New York City")
            {
                area = 468.48;
                if (year1 == 1960)
                {
                    population1 = 7781984;
                }
                if (year2 == 2010)
                {
                    population2 = 8175133;
                }
                return (name, area, year1, population1, year2, population2);
            }

            return ("", 0, 0, 0, 0, 0);
        }

        public void Deconstruct(out string city, out string country)
        {
            city = City;
            country = Country;
        }
    }
}
