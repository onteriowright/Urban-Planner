using System;
using System.Collections.Generic;

namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      Building FiveOneTwoEigth = new Building("512 8th Avenue")
      {
        Width = 20,
        Depth = 10,
        Stories = 3,
        Name = "Brigde Stone"

      };
      Building TwoOneTwoEigth = new Building("212 8th Avenue")
      {
        Width = 20,
        Depth = 10,
        Stories = 3,
        Name = "Marathon Music Works"

      };
      Building EigthOneTwoEigth = new Building("812 8th Avenue")
      {
        Width = 20,
        Depth = 10,
        Stories = 3,
        Name = "Nashville Hot Spot"

      };

      FiveOneTwoEigth.Purchase("Onterio");
      FiveOneTwoEigth.Designer("Tyler");

      TwoOneTwoEigth.Purchase("Charles");
      TwoOneTwoEigth.Designer("Donny");

      EigthOneTwoEigth.Purchase("Peter");
      EigthOneTwoEigth.Designer("Roddy");

      City Nashville = new City("Nashville", "Holden", 2005);
      City Houston = new City("Houston", "Onterio", 2002);

      Nashville.PrintCity();
      Houston.PrintCity();

      Nashville.AddBuildingToCity(EigthOneTwoEigth);
      Nashville.AddBuildingToCity(TwoOneTwoEigth);
      Nashville.AddBuildingToCity(FiveOneTwoEigth);

      foreach (Building building in Nashville.BuildingsInCity)
      {
        building.Print();
      }

    }
  }
}