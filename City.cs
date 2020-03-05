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

    public City(string city, string mayor, int year)
    {
      CityName = city;
      MayorName = mayor;
      CityEstablished = year;
    }
    public void PrintCity()
    {
      Console.WriteLine(CityName);
      Console.WriteLine(MayorName);
      Console.WriteLine(CityEstablished);
      Console.WriteLine("===============================");
    }
    public void AddBuildingToCity(Building nameOfBuilding)
    {
      BuildingsInCity.Add(nameOfBuilding);
    }
  }
}