﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackHole.Aliens;

namespace BlackHole.Spacecrafts
{
    class Transporter : Spacecraft
    {
        public Transporter()
        {
            this.craftName = "Transporter";
            this.avgSpeed = 40;
            this.numOfSeats = 200;
            this.lightSpeed = false;
        }

        public new List<Wampa> crew = new List<Wampa>();
  }
}
