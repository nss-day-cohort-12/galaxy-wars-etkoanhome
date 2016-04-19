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
            Console.WriteLine(ewok.population);
            //Console.ReadLine();

            bool scienceBeatsReligion = true;
            bool religionBeatsWarfare = true;
            bool warfareBeatsScience = true;
            bool religionBeatsScience = false;
            bool warfareBeatsReligion = false;
            bool scienceBeatsWarfare = false;








            double runningEwokpop = ewok.population;
            double runningWampapop = wampa.population;
            double runningWookieepop = wookiee.population;
            double religiousWampaPercent;
            double religiousWookieePercent;

            double wampaWeightedBonus;
            double ewokWeightedBonus;
            double wookieeWeightedBonus;
            int year = 0;
            while (runningEwokpop >= 0 || runningWampapop >= 0 || runningWookieepop >= 0)
            {
                wampaWeightedBonus = runningWampapop * 0.02;
                religiousWampaPercent = runningWampapop * 0.01;
                runningWampapop = runningWampapop - 20000;
                runningWampapop = runningWampapop + 5000;
                runningWampapop = runningWampapop - 10000;

                wookieeWeightedBonus = runningWookieepop * 0.02;
                religiousWookieePercent = runningWookieepop * 0.01;
                runningWookieepop = runningWookieepop - 20000;
                runningWookieepop = runningWookieepop - 2500;

                ewokWeightedBonus = runningEwokpop * 0.02;
                runningEwokpop = runningEwokpop - 20000;
                runningEwokpop = runningEwokpop - 10000;
                runningEwokpop = runningEwokpop + religiousWampaPercent + religiousWookieePercent;

                if(religionBeatsWarfare)
                {
                    runningWookieepop = runningWookieepop - wookieeWeightedBonus;
                } else if (warfareBeatsReligion)
                {
                    runningEwokpop = runningEwokpop - ewokWeightedBonus;
                };

                if (warfareBeatsScience)
                {
                    runningWampapop = runningWampapop - wookieeWeightedBonus;
                }else if (scienceBeatsWarfare)
                {
                    runningWookieepop = runningWookieepop - wampaWeightedBonus;
                };

                if (scienceBeatsReligion)
                {
                    runningEwokpop = runningEwokpop - wampaWeightedBonus;
                } else if (religionBeatsScience)
                {
                    runningWampapop = runningWampapop - ewokWeightedBonus;
                };

                if(year % 25 == 0)
                {
                    Random random = new Random();
                    int anomoly = random.Next(1, 4);
                    switch (anomoly)
                    {
                        case 1:
                            religionBeatsWarfare = false;
                            warfareBeatsReligion = true;
                           // Console.WriteLine("IT WORKED CASE ONE");
                            break;
                        case 2:
                            warfareBeatsScience = false;
                            scienceBeatsWarfare = true;
                           // Console.WriteLine("it worked case two");
                            break;
                        case 3:
                            scienceBeatsReligion = false;
                            religionBeatsScience = true;
                            //Console.WriteLine("it works case 3");
                            break;
                    }
                } year++;

                if (runningWampapop <= 0)
                    {
                        Console.WriteLine("Wampas died first and it is year " + year);
                    break;
                        
                    }
                    else if (runningEwokpop <= 0)
                    {
                        Console.WriteLine("Ewoks died first and it is year " + year);
                    break;
                        
                    }
                    else if (runningWookieepop <= 0)
                    {
                        Console.WriteLine("Wookiees died first and it is year " + year);
                    break;
                       

                    }
                
                 }

            Console.ReadLine();
        }
        }
 
    }


    

