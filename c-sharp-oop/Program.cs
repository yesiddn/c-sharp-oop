// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Monitor miMonitor = new Monitor(); // hay que instanciar la clase antes de la creación de la misma
var CarlosMonitor = new Monitor();

miMonitor.brand = "Sceptre";
miMonitor.color = "Black";
miMonitor.size = 27;
miMonitor.buttonCount = 5;
miMonitor.hasSpeakers = true;
miMonitor.herz = 165;

CarlosMonitor.brand = "Samsung";
CarlosMonitor.color = "White";
CarlosMonitor.size = 17;
CarlosMonitor.buttonCount = 3;
CarlosMonitor.hasSpeakers = false;
CarlosMonitor.herz = 90;

class Monitor
{
  public string brand; // si no se usa ningun access modifier, por defecto es private
  public string color;
  public int size;
  public short buttonCount; // short -> es un tipo de dato numérico que almacena numeros pequeños
  public bool hasSpeakers;
  public ushort herz;
}
