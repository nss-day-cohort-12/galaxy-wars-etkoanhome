using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackHole.Spacecrafts;

namespace BlackHole.Aliens
{
  class Alien
  {
    private string _goal;

    public string goal
    {
      get
      {
        return _goal;
      }
      set
      {
        _goal = value;
      }
    }


    private string _species;

    public string species
    {
      get
      {
        return _species;
      }
      set
      {
        _species = value;
      }
    }


  }
}
