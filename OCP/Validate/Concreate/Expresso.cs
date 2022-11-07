using OCP.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Validate.Concreate
{
    public class Expresso : CoffeBase
    {
        public override double TutarHesapla(double Adet)
        {
            return Adet * 50;
        }
    }
}
