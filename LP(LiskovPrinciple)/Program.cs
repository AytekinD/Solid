using LSP.Validate;

namespace LP_LiskovPrinciple_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dikdortgen dikdortgen = new Dikdortgen() { KisaKenar = 5,UzunKenar=9 };
            // Kare kare = new Kare() { KisaKenar=3,UzunKenar=3};
            // AlanHesaplayici hesaplayici = new AlanHesaplayici();
            // if (hesaplayici.AlanHesapla(dikdortgen) != 45)
            // {
            //     Console.WriteLine("Dikdortgenin Alan hesabi hatalidir ");
            // }
            // if (hesaplayici.AlanHesapla(kare) != 9)
            // {
            //     Console.WriteLine("KAre hesabi yanlistir");
            // }

            //Kare yeniKare = new Kare() { KisaKenar=3,UzunKenar=5};

            // if (hesaplayici.AlanHesapla(yeniKare) != 15)
            // {
            //     Console.WriteLine("Alan HEsabi yanlistir");
            // }

            Sekil dikDortgen = new YeniDikDortgen() { KisaKenar = 3, UzunKenar = 5 };
            Sekil kare = new Kare() { Kenar = 5 };
            if (kare.AlanHesapla() != 25)
            {
                Console.WriteLine("Yanlis hesap");
            }

            if (dikDortgen.AlanHesapla() != 15)
            {
                Console.WriteLine("Dikdortgen hesabi yanlis");
            }

        }
    }
}