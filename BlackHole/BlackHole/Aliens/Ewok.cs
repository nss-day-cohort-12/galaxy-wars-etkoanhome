using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackHole.Aliens
{
  class Ewok : Alien, IAlien, IReligious
  {
    public Ewok()
    {
      this.goal = "Religion";
      this.species = "Ewok";
    }

    public int aggressionLevel
    {
      get
      {
        return 4;
      }

      set
      {
        throw new NotImplementedException();
      }
    }

        public string book
        {
            get
            {
                return "A Smarter Way to Learn JavaScript";
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
        return "forest";
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
        return "ewokese";
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
        return 60;
      }

      set
      {
        throw new NotImplementedException();
      }
    }

        public string reincarnation
        {
            get
            {
                return "returns as teddy bear";
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
        return "high jump";
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
        return "sticks";
      }

      set
      {
        throw new NotImplementedException();
      }
    }
    
    



  }
}
