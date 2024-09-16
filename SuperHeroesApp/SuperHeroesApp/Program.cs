// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

SuperHeroe superman = new SuperHeroe();
superman.id = 1;
superman.name = "Superman";
superman.secretIdentity = "Clark Kent";
superman.city = "Metropolis";
superman.powers = new[] { "Super strength", "Super speed", "Heat vision", "Flight" };

class SuperHeroe
{
  public int id; // se puede usar int o guid para el id
  public string name;
  public string secretIdentity;
  public string city;
  public string[] powers;
  public bool canFly;
}