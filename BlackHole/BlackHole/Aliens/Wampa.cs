using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackHole.Aliens
{
  class Wampa : Alien, IAlien
  {
    public Wampa()
    {
      this.goal = "Science";
      this.species = "Wampa";
    }

    public int aggressionLevel
    {
      get
      {
        return 10;
      }

      set
      {
        throw new NotImplementedException();
      }
    }

    public bool canSwim
    {
      get
      {
        return false;
      }

      set
      {
        throw new NotImplementedException();
      }
    }

    public string diet
    {
      get
      {
        return "carnivore";
      }

      set
      {
        throw new NotImplementedException();
      }
    }

    public bool fur
    {
      get
      {
        return true;
      }

      set
      {
        throw new NotImplementedException();
      }
    }

    public string habitat
    {
      get
      {
        return "ice cave";
      }

      set
      {
        throw new NotImplementedException();
      }
    }

    public bool isFriendly
    {
      get
      {
        return false;
      }

      set
      {
        throw new NotImplementedException();
      }
    }

    public string language
    {
      get
      {
        return "womp womp";
      }

      set
      {
        throw new NotImplementedException();
      }
    }

    public double lifespan
    {
      get
      {
        return 200;
      }

      set
      {
        throw new NotImplementedException();
      }
    }

    public string specialPower
    {
      get
      {
        return "strength";
      }

      set
      {
        throw new NotImplementedException();
      }
    }

    public string weapon
    {
      get
      {
        return "claws";
      }

      set
      {
        throw new NotImplementedException();
      }
    }
  }
}
