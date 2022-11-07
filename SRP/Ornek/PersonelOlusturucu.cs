using SRP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Ornek
{
    public class PersonelOlusturucu
    {

        public void PersonelEkle(Personel personel)
        {
			try
			{
				#region Personel Katdetme islemi
				string str = personel.Ad + ";" + personel.Soyad + ";" + personel.TcNo + ";" + personel.Email;

				File.WriteAllText(@"personel.txt", str);

				#endregion
				#region Kaydedilen personelin loglanmasi

				string log = "Kayit Tarihi:" + DateTime.Now + "Kaydedilen Kisi:" + personel.Ad + " " + personel.Soyad;
				File.WriteAllText(@"log.txt", log);

				#endregion

			}
			catch (Exception ex)
			{
				#region Eger Hata yakalarsa Error.txt dosyasina yazsin.

				File.WriteAllText(@"Error.txt", "HataTarihi:" + DateTime.Now + "Hata:" + ex.Message);
				#endregion

				throw;
			}

        }
    }
}
