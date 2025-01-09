using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
  internal class SuperPower
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
}
