using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.CoffieExample
{
    public enum CoffeeType
    {
        Latte=1,
        Expresso,
        Capucino,
        
    }

    public class Coffee
    {
        public double GetTotalPrice(double Adet, CoffeeType coffeeType)
        {
            double toplamFiyat = 0;
            switch (coffeeType)
            {
                case CoffeeType.Latte:
                    toplamFiyat += Adet * 60; 
                    break;
                case CoffeeType.Expresso:
                    toplamFiyat += Adet * 50;
                    break;
                case CoffeeType.Capucino:
                    toplamFiyat += Adet * 70;
                    break;
                default:
                    break;
            }
            return toplamFiyat;

        }
    }
}
