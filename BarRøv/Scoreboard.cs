using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarRøv
{
    internal class Scoreboard
    {
        public int Mål { get; set; }
        
        public void VisScoreboard(List<Spiller> spillere)
        {
            Console.WriteLine($"Scoreboard for Bar røv - mål: {Mål}");
            Console.WriteLine("-----------------");
            foreach (Spiller spiller in spillere)
            {
                Console.WriteLine($"Spiller{spiller.Nummer} - {spiller.Navn}: {spiller.Point}");
            }
            Console.WriteLine("-----------------");
        }

        public bool ErSpilletIGang(List<Spiller> spillere)
        {
            foreach (Spiller spiller in spillere)
            {
                if (spiller.Point >= Mål)
                {
                    return false;
                }
            }            
            return true;
        }

        public void FindVinder(List<Spiller> spillere)
        {
            int højScore = 0;
            string vinder = "";
            int nummer = 0;
            
            foreach (Spiller spiller in spillere)
            {
                if (spiller.Point > højScore)
                {
                    højScore = spiller.Point;
                    vinder = spiller.Navn;
                    nummer = spiller.Nummer;
                }                 
            }
            Console.WriteLine($"Vinderen blev: Spiller{nummer} - {vinder} med {højScore} point - tillykke!");
        }
    }
}
