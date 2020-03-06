using System;
using System.Collections.Generic;

namespace Planner
{
  public class Building
  {
    private string _designer { get; set; }
    private DateTime _dateConstructed { get; set; }
    private string _address { get; set; }
    private string _owner { get; set; }
    public int Stories { get; set; }
    public double Width { set; get; }
    public double Depth { set; get; }
    public string Name { get; set; }
    public string Volume
    {
      get
      {
        return $"{Width * Depth * (3 * Stories)}";
      }
    }

    public Building(string address)
    {
      _address = address;
    }

    public void Construct(DateTime date)
    {
      _dateConstructed = date;
    }
    public void Purchase(string purchaserName)
    {
      _owner = purchaserName;
    }
    public void Designer(string designer)
    {
      _designer = designer;
    }
    public void Print()
    {
      Console.WriteLine(_address);
      Console.WriteLine($"Designed by {_designer}");
      Console.WriteLine($"Constructed on {_dateConstructed}");
      Console.WriteLine($"Owned by {_owner}");
      Console.WriteLine($"{Volume} cubic meters of space");
      Console.WriteLine(Name);
      Console.WriteLine("==========================================");
    }
  }

};