using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_DependencyInversionPrinciple_.Ornek
{
    public class KofteciRAmiz
    {
        private Kofte kofte = new Kofte();
        private Tavuk tavuk = new Tavuk();

        public void Pisir()
        {
            kofte.KotePisir();
            tavuk.TavukPisir();
        }
    }
}
