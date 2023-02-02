
using TuplesDemo;

Console.WriteLine("Tuple Demo");

CityData wroclawCity = new("Wroclaw", "Polska");

var (cityName, countryName, cityCountry, countryCity ) = wroclawCity.GetCityData();

(string cityNameTwo, int inhabitants) = wroclawCity.GetInhabitants();

Console.WriteLine($"{cityName} is placed in {countryName}");
Console.WriteLine($"{cityCountry} or {countryCity}?");

Console.WriteLine($"{cityNameTwo} has {inhabitants} inhabitants");


// skip variables with discards _
var (_, _, _, pop1, _, pop2) = wroclawCity.QueryCityDataForYears("New York City", 1960, 2010);

Console.WriteLine($"Population change, 1960 to 2010: {pop2 - pop1:N0}");


//using custom deconstruct

var (cityNameDe, countryNameDe) = wroclawCity;

Console.WriteLine($"deconstructed {cityNameDe} in {countryNameDe}");