using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
  internal abstract class Hero
  {
    // abstract se usa para definir una clase que no se puede instanciar, solo se puede usar como base para otras clases
    // los metodos abstractos no tienen cuerpo, solo se definen
    public abstract string saveTheDay();

    public abstract string name { get; set; }

    // los metodos o atributos que no sean marcados como abstract no se sobreescriben en las clases hijas, la herencia se aplica con normalidad
    public string sayHello()
    {
      return $"Hello, my name is {name}.";
    }
  }
}
