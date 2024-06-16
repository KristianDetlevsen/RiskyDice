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
            List<Spiller> vindere = new List<Spiller>();
            
            foreach (Spiller spiller in spillere)
            {
                if (spiller.Point > højScore)
                {
                    højScore = spiller.Point;
                    vindere.Clear();
                    vindere.Add(spiller);
                }
                else if (spiller.Point == højScore)
                {
                    vindere.Add(spiller);
                }
            }

            if (vindere.Count == 1)
            {
                var vinder = vindere[0];
                Console.WriteLine($"Vinderen blev: Spiller{vinder.Nummer} - {vinder.Navn} med {højScore} point - tillykke!");
            }
            else
            {
                Console.Write("Der er flere vindere: ");
                foreach (var vinder in vindere)
                {
                    Console.Write($"Spiller{vinder.Nummer} - {vinder.Navn}, ");
                }
                Console.WriteLine($"alle med {højScore} point - tillykke!");
            }
            
        }
    }
}
