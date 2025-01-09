using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
  // internal se difiere de public en que solo se puede acceder a la clase desde el mismo proyecto, es decir, si creo otro proyecto llamado MarvelApp no podría acceder a esta clase, pero si a otras clases que sean public
  // los unicos modificadores de acceso que se pueden usar en una clase son public e internal
  internal class SuperHero
  {
    // tambien se puede asignar un valor por defecto directamente en la declaración en lugar de usar el constructor
    public int id = 1; // se puede usar int o guid para el id
    public string name;
    public string secretIdentity;
    public string city;
    //public string[] powers;
    public List<SuperPower> powers;
    public bool canFly;

    // constructor
    public SuperHero()
    {
      powers = new List<SuperPower>();
      canFly = false;
    }

    public string useSuperPower()
    {
      StringBuilder sb = new StringBuilder(); // se crea un objeto StringBuilder para concatenar los mensajes
      foreach (var power in powers)
      {
        sb.AppendLine($"{name} is using {power.name}!");
      }

      return sb.ToString();
    }

    public void Fly()
    {
      if (canFly)
      {
        Console.WriteLine($"{name} is flying!");
      }
      else
      {
        Console.WriteLine($"{name} can't fly.");
      }
    }
  }
}
