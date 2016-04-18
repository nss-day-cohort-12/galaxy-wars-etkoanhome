using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackHole.Spacecrafts
{
    class Speeder : Spacecraft
    {
        public Speeder()
        {
            this.craftName = "Speeder";
            this.avgSpeed = 180;
            this.numOfSeats = 2;
            this.lightSpeed = false;
        }
    }
}
