using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarRøv
{
    internal class Runde
    {
        Raflebæger raflebæger = new Raflebæger();
        
        public void Spil(Spiller spiller)
        {
            int rundePoint = 0;
            raflebæger.FyldBæger();

            Console.WriteLine($"Det er nu {spiller.Navn}'s tur!");
            Console.Write("Tryk enter for at kaste terningerne!");
            Console.ReadLine();

            while (raflebæger.ErDerTerninger())
            {
                bool exit = false;

                raflebæger.RystBæger();
                raflebæger.VisTerninger();
                
                if (raflebæger.SkalDerFjernesTerninger())
                {
                    raflebæger.FjernTerninger();
                    Console.Write("Lægger terninger til side - tast enter for at kaste igen!");
                    Console.ReadLine();
                }
                else
                {
                    rundePoint += raflebæger.BeregnPoint();
                    
                    while (!exit)
                    {
                        Console.Write("Ønsker du at fortsætte - j/n? ");
                        string input = Console.ReadLine();
                        switch (input)
                        {
                            case "j":
                                exit = true;
                                break;
                            case "n":
                                spiller.Point += rundePoint;
                                raflebæger.NulstilRaflebæger();
                                return;
                            default:
                                Console.WriteLine("Du skal enten taste j for ja eller n for nej - prøv igen!");
                                break;
                        }
                    }    
                }
            }
            spiller.Point += 0;
            raflebæger.NulstilRaflebæger();
            Console.Write("Ingen terninger tilbage - bar røv! Tryk enter for næste spiller! ");
            Console.ReadLine();            
        }
    }
}
