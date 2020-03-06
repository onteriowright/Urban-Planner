using System;
using System.Collections.Generic;

namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      Building BridgeStoneArena = new Building("512 8th Avenue", 3, 20, 10, "Bridge Stone");

      Building MarathonMusicWorks = new Building("212 8th Avenue", 3, 20, 10, "Marathon Music works");

      Building PrincessHotChicken = new Building("812 8th Avenue", 3, 20, 10, "Princess Hot Chicken");

      Building GalleriaMall = new Building("713 Post Oak Avenue", 4, 18, 21, "Galleria Mall");

      BridgeStoneArena.Purchase("Onterio Wright");
      BridgeStoneArena.Construct(DateTime.Now.ToLocalTime());
      BridgeStoneArena.Designer("Tyler Davis");

      MarathonMusicWorks.Purchase("Charles Hopkins");
      MarathonMusicWorks.Construct(DateTime.Now.ToLocalTime());
      MarathonMusicWorks.Designer("Donny");

      PrincessHotChicken.Purchase("Peter James");
      PrincessHotChicken.Construct(DateTime.Now.ToLocalTime());
      PrincessHotChicken.Designer("Roddy");

      GalleriaMall.Purchase("Onterio Wright");
      GalleriaMall.Construct(DateTime.Now.ToLocalTime());
      GalleriaMall.Designer("Danyeal Wright");

      City Nashville = new City("Nashville", "Holden Parker", 2020);
      City Conroe = new City("Conroe", "Akemo Wright", 2020);
      City Houston = new City("Houston", "Onterio Wright", 2020);
      City Dallas = new City("Dallas", "Danyeal Wright", 2020);

      Nashville.AddCity(Nashville);
      Houston.AddCity(Houston);
      Dallas.AddCity(Dallas);
      Houston.AddCity(Conroe);

      Nashville.AddBuildingToCity(PrincessHotChicken);
      Nashville.AddBuildingToCity(MarathonMusicWorks);
      Nashville.AddBuildingToCity(BridgeStoneArena);

      Houston.AddBuildingToCity(GalleriaMall);

      foreach (Building building in Nashville.BuildingsInCity)
      {
        building.Print();
      }

      foreach (Building building in Houston.BuildingsInCity)
      {
        building.Print();
      }

      foreach (City city in Dallas.NameOfCity)
      {
        city.PrintCity();
      }

      foreach (City city in Houston.NameOfCity)
      {
        city.PrintCity();
      }

      foreach (City city in Nashville.NameOfCity)
      {
        city.PrintCity();
      }
    }
  }
}