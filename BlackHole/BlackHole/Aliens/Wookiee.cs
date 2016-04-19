using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackHole.Spacecrafts;

namespace BlackHole.Aliens
{
  class Wookiee : Alien, IAlien, IWarfare
  {
    public Wookiee()
    {
      this.goal = "Warfare";
      this.species = "Wookiee";
    }

    public int aggressionLevel
    {
      get
      {
        return 6;
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
        return true;
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
        return "omnivore";
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
        return "city";
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
        return true;
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
        return "graaawrgh";
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
        return 400;
      }

      set
      {
        throw new NotImplementedException();
      }
    }

        public string martialArt
        {
            get
            {
                return "Kung Fu";
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string motivation
        {
            get
            {
                return "revenge";
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
        return "dance";
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
        return "blasters";
      }

      set
      {
        throw new NotImplementedException();
      }
    }
  }
}
