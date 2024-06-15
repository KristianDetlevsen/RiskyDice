using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarRøv
{
    internal class Menu
    {
        public List<Spiller> spillere = new List<Spiller>();
        Scoreboard scoreboard = new Scoreboard();
        Runde runde = new Runde();

        public void VisMenu()
        {
            bool exitAntal = false;
            bool exitMål = false;

            Console.WriteLine("Velkommen til Bar røv! Tryk enter for at starte!");
            Console.ReadLine();
            Console.Clear();

            while (!exitAntal)
            {
                Console.Write("Indtast antal spillere (2-10): ");
                bool checkAntal = int.TryParse(Console.ReadLine(), out int antal);
                if (checkAntal && antal >= 2 && antal <= 10)
                {
                    for (int i = 1; i < antal + 1; i++)
                    {
                        Console.Write("Indtast navn på spiller: ");
                        Spiller spiller = new Spiller();
                        spiller.Nummer = i;
                        spiller.Navn = Console.ReadLine();
                        spiller.Point = 0;
                        spillere.Add(spiller);
                    }
                    exitAntal = true;
                }
                else
                {
                    Console.WriteLine("Du skal indtaste et tal, som er mellem 2 og 10 - prøv igen!");
                }
            }

            Console.Clear();

            while (!exitMål)
            {
                Console.Write("Indtast mål for spillet (f.eks. 100): ");
                bool checkMål = int.TryParse(Console.ReadLine(), out int mål);
                if (checkMål && mål > 0)
                {
                    scoreboard.Mål = mål;
                    exitMål = true;
                }
                else
                {
                    Console.WriteLine("Du skal indtaste et tal større end 0 - prøv igen!");
                }
            }

            Console.Clear();

            while (scoreboard.ErSpilletIGang(spillere))
            {
                foreach (Spiller spiller in spillere)
                {
                    scoreboard.VisScoreboard(spillere);
                    runde.Spil(spiller);
                    Console.Clear();
                }
            }

            scoreboard.VisScoreboard(spillere);
            Console.WriteLine("---");
            scoreboard.FindVinder(spillere);
        }
    }
}
