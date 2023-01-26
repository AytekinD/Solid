using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Ornek2.duzeltilmis
{
    internal class YeniDikdortgen : ISekil
    {
        public int KisaKenar { get; set; }
        public int UzunKenar { get; set; }
        public double AlaHesapla()
        {
            return KisaKenar * UzunKenar;
        }
    }
}
