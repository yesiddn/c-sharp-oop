// See https://aka.ms/new-console-template for more information
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

SuperHeroe superman = new SuperHeroe();
superman.id = 1;
superman.name = "Superman";
superman.secretIdentity = "Clark Kent";
superman.city = "Metropolis";
//superman.powers = new[] { SuperStrength, SuperSpeed, HeatVision, Flight };

List<SuperPower> supermanPowers = new List<SuperPower>(); // se crea una lista de superpoderes
supermanPowers.Add(SuperStrength); // se añade el superpoder SuperStrength a la lista
supermanPowers.Add(SuperSpeed); // se añade el superpoder SuperSpeed a la lista
supermanPowers.Add(HeatVision); // se añade el superpoder HeatVision a la lista
supermanPowers.Add(Flight); // se añade el superpoder Flight a la lista
superman.powers = supermanPowers; // se asigna la lista de superpoderes al superhéroe

class SuperHeroe
{
  public int id; // se puede usar int o guid para el id
  public string name;
  public string secretIdentity;
  public string city;
  //public string[] powers;
  public List<SuperPower> powers;
  public bool canFly;
}

class SuperPower
{
  public string name;
  public string description;
  //public int level;
  public PowerRank level;
}

enum PowerRank
{
  LevelOne,
  LevelTwo,
  LevelThree,
  LevelFour,
  LevelFive
}