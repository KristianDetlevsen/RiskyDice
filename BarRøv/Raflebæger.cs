using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarRøv
{
    internal class Raflebæger
    {
        public List<Terning> terninger = new List<Terning>();

        Terning t1 = new Terning();
        Terning t2 = new Terning();
        Terning t3 = new Terning();
        Terning t4 = new Terning();
        Terning t5 = new Terning();

        public void FyldBæger()
        {
            terninger.Add(t1);
            terninger.Add(t2);
            terninger.Add(t3);
            terninger.Add(t4);
            terninger.Add(t5);
        }
        
        public void RystBæger()
        {
            foreach (Terning t in terninger)
            {
                t.Ryst();
            }
        }

        public void VisTerninger()
        {
            Console.WriteLine("---");
            int i = 1;
            foreach(Terning t in terninger)
            {
                Console.WriteLine($"Terning{i}: {t.Værdi}");
                i++;
            }
            Console.WriteLine("---");
        }

        public void FjernTerninger()
        {
            List<Terning> terningerAtFjerne = new List<Terning>();
            
            foreach (Terning t in terninger)
            {
                if (t.Værdi == 2 || t.Værdi == 5)
                {
                    terningerAtFjerne.Add(t);
                }
            }

            foreach (Terning t in terningerAtFjerne)
            {
                terninger.Remove(t);
            }
        }

        public bool ErDerTerninger()
        {
            if (terninger.Any())
            {
                return true;
            }
            return false;
        }

        public int BeregnPoint()
        {
            int totalVærdi = 0;
            foreach(Terning t in terninger)
            {
                totalVærdi += t.Værdi;
            }
            return totalVærdi;
        }

        public bool SkalDerFjernesTerninger()
        {
            foreach (Terning t in terninger)
            {
                if (t.Værdi == 2 || t.Værdi == 5)
                {
                    return true;
                }
            }
            return false;
        }

        public void NulstilRaflebæger()
        {
            terninger.Clear();
        }
    }
}
