using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackHole.Aliens;
using BlackHole.Planets;
using BlackHole.Spacecrafts;

namespace BlackHole
{
    class BlackHole
    {
        static void Main(string[] args)
        {
          Ewok ewok = new Ewok();
            Console.WriteLine(ewok.goal);
            Console.WriteLine(ewok.diet);
            Console.WriteLine(ewok.fur);
     

          Wookiee wookiee = new Wookiee();
            Console.WriteLine(wookiee.weapon);

          Wampa wampa = new Wampa();
            Console.WriteLine(wampa.mindWeapon);

          Falcon falcon = new Falcon();
            Console.WriteLine(falcon.CalculateSpeed());
          falcon.crew.Add(wookiee);
            Console.WriteLine("falcon crew is comprised of " + falcon.crew);

      Speeder speeder = new Speeder();
            Console.WriteLine(speeder.avgSpeed);

          Transporter transporter = new Transporter();
            Console.WriteLine(transporter.avgSpeed);
            Console.ReadLine();
        }
    }
}
