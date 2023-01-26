using OCP.Ornek2;
using OCP.Ornek2.duzeltilmis;

namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Open Closed Principle:
            Siniflar gelismeye acik lakin degismeye kapali olmalidir.
            */

            //AlanHesaplayici hesaplayici = new();
            //Dikdortgen dikdortgen = new();
            //dikdortgen.KisaKenar = 4;
            //dikdortgen.UzunKenar = 5;
            //Daire daire = new Daire();
            //daire.YariCap = 6;

            DikUcgen dikUcgen = new DikUcgen { KisaKenar = 4, UzunKenar = 5 };
            YeniDaire daire = new YeniDaire { YariCap = 5 };
            YeniDikdortgen dikdortgen = new YeniDikdortgen { UzunKenar = 6, KisaKenar = 9 };


            ISekil dikUcgen2 = new DikUcgen { KisaKenar = 4, UzunKenar = 5 };
            ISekil daire2 = new YeniDaire { YariCap = 5 };
            ISekil dikdortgen2 = new YeniDikdortgen { UzunKenar = 6, KisaKenar = 9 };


            hesapla(dikUcgen);
            hesapla(daire);
            hesapla(dikdortgen);





        }
        static void hesapla(ISekil sekil)
        {
            sekil.AlaHesapla();
        }
    }
}