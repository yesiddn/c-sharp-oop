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

//List<SuperPower> supermanPowers = new List<SuperPower>(); // se crea una lista de superpoderes
//supermanPowers.Add(SuperStrength); // se añade el superpoder SuperStrength a la lista
//supermanPowers.Add(SuperSpeed); // se añade el superpoder SuperSpeed a la lista
//supermanPowers.Add(HeatVision); // se añade el superpoder HeatVision a la lista
//supermanPowers.Add(Flight); // se añade el superpoder Flight a la lista
//superman.powers = supermanPowers; // se asigna la lista de superpoderes al superhéroe

////superman.Fly();
//string supermanMessage = superman.useSuperPower();
//Console.WriteLine(supermanMessage);

SuperHero superman2 = new SuperHero();
superman2.id = 1;
superman2.name = "Superman";
superman2.secretIdentity = "Clark Kent";
superman2.city = "Metropolis";
superman2.canFly = true;

bool areEqual = superman == superman2; // aunque dos clases tengan el mismo contenido no son iguales
Console.WriteLine("Superman == Superman2: " + areEqual);

//SuperHeroRecord supermanRecord = new SuperHeroRecord(1, "Superman", "Clark Kent");
SuperHeroRecord supermanRecord = new(1, "Superman", "Clark Kent"); // esta es otra forma de instanciar una clase o un record para no tener que repetir el nombre de la clase
SuperHeroRecord supermanRecord2 = new(1, "Superman", "Clark Kent");

bool areEqualRecord = supermanRecord == supermanRecord2; // los records son iguales si tienen el mismo contenido
Console.WriteLine("SupermanRecord == SupermanRecord2: " + areEqualRecord);

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

// al record no se le crea un comportamiento con metodos como en una clase
// los records son utiles en microservicios cuando recibimos multiples mensajes de varios servicios y queremos compararlos para saber si son iguales
// el tipo de dato structure es parecido a un record pero no tiene la misma funcionalidad
public record SuperHeroRecord(int id, string nombre, string secretIdentity);

/*
 RECORD En C#, un "record" es un tipo de referencia inmutable introducido en C# 9.0 que se utiliza para modelar datos simples y valores inmutables. Los "records" son especialmente útiles cuando tienes un conjunto de datos que no cambia después de su creación y deseas garantizar que no se pueda modificar. Algunas de las ventajas y casos de uso comunes de los "records" incluyen:

Inmutabilidad: Los "records" son inmutables de forma predeterminada, lo que significa que sus valores no pueden cambiar después de que se hayan creado. Esto garantiza que los datos permanezcan consistentes y predecibles.

Facilidad de Igualdad: Los "records" facilitan la comparación de igualdad de objetos basándose en sus valores en lugar de sus referencias. Esto es útil al realizar comparaciones de igualdad en lugar de referencia.

Sintaxis Concisa: Los "records" tienen una sintaxis concisa para definir propiedades y métodos. Puedes definir propiedades de solo lectura de manera abreviada.

Desestructuración: Los "records" admiten la desestructuración, lo que significa que puedes descomponer un objeto "record" en sus componentes individuales.

Patrones de Coincidencia: Los "records" funcionan bien con patrones de coincidencia, lo que facilita la escritura de código que responde a diferentes combinaciones de valores de objetos "record".

Usos Comunes: Los "records" son ideales para modelar tipos de datos simples como puntos, vectores, coordenadas geográficas, datos de sensores y otros valores inmutables.
*/
