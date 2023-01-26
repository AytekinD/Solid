using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Validate
{
    internal class YeniDikDortgen:Sekil
    {
        public int KisaKenar { get; set; }
        public int UzunKenar { get; set; }



        override public double AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }

    }
}
