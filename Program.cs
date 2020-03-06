using System;
using System.Collections.Generic;

namespace Planner
{
  class Program
  {
    static void Main(string[] args)
    {
      Building BridgeStoneArena = new Building("512 8th Avenue")
      {
        Width = 20,
        Depth = 10,
        Stories = 3,
        Name = "Bridge Stone"
      };

      Building MarathonMusicWorks = new Building("212 8th Avenue")
      {
        Width = 20,
        Depth = 10,
        Stories = 3,
        Name = "Marathon Music Works"
      };

      Building PrincessHotChicken = new Building("812 8th Avenue")
      {
        Width = 20,
        Depth = 10,
        Stories = 3,
        Name = "Princess Hot Chicken"
      };

      Building GalleriaMall = new Building("713 Post Oak Avenue")
      {
        Width = 18,
        Depth = 21,
        Stories = 4,
        Name = "Galleria Mall"
      };

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
      City Houston = new City("Houston", "Onterio Wright", 2020);
      City Dallas = new City("Dallas", "Danyeal Wright", 2020);

      Nashville.PrintCity();
      Houston.PrintCity();
      Dallas.PrintCity();

      Nashville.AddBuildingToCity(PrincessHotChicken);
      Nashville.AddBuildingToCity(MarathonMusicWorks);
      Nashville.AddBuildingToCity(BridgeStoneArena);

      Nashville.AddBuildingToCity(GalleriaMall);

      foreach (Building building in Nashville.BuildingsInCity)
      {
        building.Print();
      }
      foreach (Building building in Houston.BuildingsInCity)
      {
        building.Print();
      }

    }
  }
}