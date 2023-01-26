using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Ornek2.duzeltilmis
{
    internal class YeniDaire : ISekil
    {
        public int YariCap { get; set; }
        public double AlaHesapla()
        {
            return YariCap * YariCap * Math.PI;
        }
    }
}
