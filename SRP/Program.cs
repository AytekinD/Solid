using SRP.DuzeltilmisOrnek;
using SRP.Entity;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Single Responsibility Principle

            Personel ali = new Personel { Ad = "Ali", Soyad = "Yilmaz", Email = "Ali@gmail.com", TcNo = "12345678978" };
            PersonelCreate personelCreate = new PersonelCreate();
            Logger logger = new Logger(@"personel2.txt", "Test");
            personelCreate.PersonelEkle(ali);

        }
    }
}