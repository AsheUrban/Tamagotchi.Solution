using System.Collections.Generic;
using System; 

namespace Nursery.Models
{
  public class Tamagotchi
  {
    public string Name { get; set; }
    public int Id { get; }
    public int Health { get; set; }


    private static List<Tamagotchi> _instances = new List<Tamagotchi>{ };

    public Tamagotchi(string name)
    {
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
      Health = 10; 
    }

    public static List<Tamagotchi> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Tamagotchi Find(int searchId)
    {
      return _instances[searchId-1];

    }

    // public static Tamagotchi Feed(int foodQuantity)
    // {
    //   return ;
    // }
    
  }
}