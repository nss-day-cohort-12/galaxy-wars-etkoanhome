using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackHole.Aliens
{
  interface IAlien
  {
    bool fur { get; set; }
    string language { get; set; }
    int aggressionLevel { get; set; }
    string weapon { get; set; }
    string habitat { get; set; }
    string diet { get; set; }
    double lifespan { get; set; }
    bool canSwim { get; set; }
    bool isFriendly { get; set; }
    string specialPower { get; set; }
  }
}
