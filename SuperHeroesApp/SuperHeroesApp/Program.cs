// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

var SuperStrength = new SuperPower();
SuperStrength.name = "Super strength";
SuperStrength.description = "Super strength is the ability to exert a force on objects beyond what is physically possible for a human.";
SuperStrength.level = PowerRank.LevelFive;

var SuperSpeed = new SuperPower();
SuperSpeed.name = "Super speed";
SuperSpeed.description = "Super speed is the ability to move at speeds faster than what is physically possible for a human.";
SuperSpeed.level = PowerRank.LevelFive;

var HeatVision = new SuperPower();
HeatVision.name = "Heat vision";
HeatVision.description = "Heat vision is the ability to emit beams of intense heat at a target.";
HeatVision.level = PowerRank.LevelFour;

var Flight = new SuperPower();
Flight.name = "Flight";
Flight.description = "Flight is the ability to defy gravity and propel oneself through the air.";
Flight.level = PowerRank.LevelTwo;

SuperHero superman = new SuperHero();
superman.id = 1;
superman.name = "Superman";
superman.secretIdentity = "Clark Kent";
superman.city = "Metropolis";
superman.canFly = true;
//superman.powers = new[] { SuperStrength, SuperSpeed, HeatVision, Flight };

List<SuperPower> supermanPowers = new List<SuperPower>(); // se crea una lista de superpoderes
supermanPowers.Add(SuperStrength); // se añade el superpoder SuperStrength a la lista
supermanPowers.Add(SuperSpeed); // se añade el superpoder SuperSpeed a la lista
supermanPowers.Add(HeatVision); // se añade el superpoder HeatVision a la lista
supermanPowers.Add(Flight); // se añade el superpoder Flight a la lista
superman.powers = supermanPowers; // se asigna la lista de superpoderes al superhéroe

//superman.Fly();
string supermanMessage = superman.useSuperPower();
Console.WriteLine(supermanMessage);

class SuperHero
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

class SuperPower
{
  public string name;
  public string description;
  //public int level;
  public PowerRank level;

  public SuperPower()
  {
    level = PowerRank.LevelOne;
  }
}

enum PowerRank
{
  LevelOne,
  LevelTwo,
  LevelThree,
  LevelFour,
  LevelFive
}