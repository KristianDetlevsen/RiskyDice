using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarRøv
{
    internal class Terning
    {
        public int Værdi;

        public void Ryst()
        {
            Random random = new Random();
            Værdi = random.Next(1, 7);
        }
    }
}
