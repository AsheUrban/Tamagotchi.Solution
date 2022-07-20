using System.Collections.Generic;
using System; 

namespace Nursery.Models
{
  public class Tamagotchi
  {
    public string Name { get; set; }
    public int Id { get; }
    public int Food { get; set; }
    public int Sleep { get; set; }
    public int Play { get; set; }
    public int Health { get; set; }
   
    private static List<Tamagotchi> _instances = new List<Tamagotchi>{ };

    public Tamagotchi(string name, int health)
    {
      Name = name;
      _instances.Add(this);
      Id = _instances.Count;
      Health = health; 
      Food = 0;
      Sleep = 0;
      Play = 0;
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

    public static Tamagotchi Feed(int foodQuantity)
    {

      return Health += foodQuantity;
    }
    
    public static Tamagotchi Sleep(int sleepQuantity)
    {

      return Health += sleepQuantity;
    }

    public static Tamagotchi Play(int playQuantity)
    {

      return Health += playQuantity;
    }
  }
}