using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackHole.Aliens;

namespace BlackHole.Spacecrafts
{
    class Falcon : Spacecraft
    {
        public Falcon()
        {
            this.craftName = "Falcon";
            this.avgSpeed = 100;
            this.numOfSeats = 60;
            this.lightSpeed = true;
        }

            private int lightSpeedBonus = 400;

            public override int CalculateSpeed()
            {
                return avgSpeed + lightSpeedBonus;
            }
       public new List<Wookiee> crew = new List<Wookiee>();
  }
}
