using System;
using System.Collections.Generic;

namespace Car.Models
{

public class Cars
{

  private static string _Make;
  private static string _Model;
  private static int _Price;
  private static int _Miles;

  public Cars (string Make, string Model, int Price, int Miles)
  {
  _Make = Make;
  _Model = Model;
  _Price = Price;
  _Miles = Miles;
  }

  private static List<Cars> _instances = new List<Cars> {};

  public static bool WorthBuying(int maxPrice, int maxMiles)
  {
    return (Cars._Price < maxPrice && Cars._Miles < maxMiles);
  }
  public string GetMake()
  {
    return _Make;
  }
  public void SetMake(string newMake)
  {
    _Make = newMake;
  }
  public string GetModel()
  {
    return _Model;
  }
  public void SetModel(string newModel)
  {
    _Model = newModel;
  }
  public int GetPrice()
  {
    return _Price;
  }
  public void SetPrice(int newPrice)
  {
    _Price = newPrice;
  }
  public int GetMiles()
  {
    return _Miles;
  }
  public void SetMiles(int newMiles)
  {
    _Miles = newMiles;
  }



    // Cars porsche = new Cars();
    // porsche.MakeModel = "2014 Porsche 911";
    // porsche.Price = 114991;
    // porsche.Miles = 7864;
    //
    // Cars ford = new Cars();
    // ford.MakeModel = "2011 Ford F450";
    // ford.Price = 55995;
    // ford.Miles = 14241;
    //
    // Cars lexus = new Cars();
    // lexus.MakeModel = "2013 Lexus RX 350";
    // lexus.Price = 44700;
    // lexus.Miles = 20000;
    //
    // Cars mercedes = new Cars();
    // mercedes.MakeModel = "Mercedes Benz CLS550";
    // mercedes.Price = 39900;
    // mercedes.Miles = 37979;

    // public static void List<Cars> Cars = new List<Cars>() { porsche, ford, lexus, mercedes };
    //
    // foreach(Cars automobile in Cars)
    // {
    // Console.WriteLine(automobile.MakeModel);
    // }
    // public static void MaxPrice()
    // {
    // Console.WriteLine("Enter maximum price: ");
    // string stringMaxPrice = Console.ReadLine();
    // int maxPrice = int.Parse(stringMaxPrice);
    // }
    //
    // public static void MaxMiles()
    // {
    // Console.WriteLine("Enter maximum miles: ");
    // string stringMaxMiles = Console.ReadLine();
    // int maxMiles = int.Parse(stringMaxMiles);
    // }

    public void Save()
      {
        _instances.Add(this);
      }

      public static List<Cars> GetAll()
      {
        return _instances;
      }

      public static void ClearAll()
      {
        // Console.WriteLine("Got here.");
        _instances.Clear();
      }

    // List<Cars> CarsMatchingSearch = new List<Cars>(0);
    //
    // foreach (Car automobile in Cars)
    // {
    //   if (automobile.WorthBuying(maxPrice, maxMiles))
    //   {
    //     CarsMatchingSearch.Add(automobile);
    //   }
    // }
    //
    // foreach(Cars automobile in CarsMatchingSearch)
    // {
    //   Console.WriteLine(automobile.MakeModel);
    // }

  }
}
