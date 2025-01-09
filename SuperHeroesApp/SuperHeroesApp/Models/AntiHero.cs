using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
  // con dos puntos (:) se indica que la clase AntiHero hereda de la clase SuperHero
  internal class AntiHero : SuperHero
  {
    public string doAntiHeroAction(string action)
    {
      return $"{name} is doing an anti-hero action: {action}";
    }
  }
}
