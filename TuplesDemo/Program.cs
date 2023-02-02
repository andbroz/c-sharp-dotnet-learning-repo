
using TuplesDemo;

Console.WriteLine("Tuple Demo");

CityData wroclawCity = new("Wroclaw", "Polska");

var (cityName, countryName, cityCountry, countryCity ) = wroclawCity.GetCityData();

(string cityNameTwo, int inhabitants) = wroclawCity.GetInhabitants();

Console.WriteLine($"{cityName} is placed in {countryName}");
Console.WriteLine($"{cityCountry} or {countryCity}?");

Console.WriteLine($"{cityNameTwo} has {inhabitants} inhabitants");