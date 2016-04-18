using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackHole.Aliens;

namespace BlackHole.Spacecrafts
{
    class Spacecraft
    {
        public string craftName { get; set; }
        public int avgSpeed { get; set; }
        public int numOfSeats { get; set; }
        public bool lightSpeed { get; set; }

        public virtual int CalculateSpeed()
        {
            return avgSpeed;
        }

        public List<Alien> crew = new List<Alien>();
  }
}
