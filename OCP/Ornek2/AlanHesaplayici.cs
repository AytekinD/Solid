using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Ornek2
{
    internal class AlanHesaplayici
    {
        public double AlanHesapla(Dikdortgen[] dikdortgens)
        {
            double alan = 0;
            foreach (var item in dikdortgens)
            {
                alan = item.KisaKenar * item.UzunKenar;
            }
            return alan;
        }
    }
}
