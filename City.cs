using System;
using System.Collections.Generic;

namespace Planner
{
  class City
  {
    public string CityName { get; set; }
    public string MayorName { get; set; }
    public int CityEstablished { get; set; }
    public List<Building> BuildingsInCity = new List<Building>();
    public List<City> NameOfCity = new List<City>();

    public City(string city, string mayor, int year)
    {
      CityName = city;
      MayorName = mayor;
      CityEstablished = year;
    }
    public void PrintCity()
    {
      Console.WriteLine($"City: {CityName}");
      Console.WriteLine($"Mayor: {MayorName}");
      Console.WriteLine($"Date established: {CityEstablished}");
      Console.WriteLine("===============================");
    }
    public void AddBuildingToCity(Building nameOfBuilding)
    {
      BuildingsInCity.Add(nameOfBuilding);
    }
    public void AddCity(City nameOfCity)
    {
      NameOfCity.Add(nameOfCity);
    }
  }
}