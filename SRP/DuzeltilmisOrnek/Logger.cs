using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.DuzeltilmisOrnek
{
    public class Logger
    {
        private string DosyaAdi { get; set; }
        private string Message { get; set; }
        public Logger(string DosyaAdi,string Message)
        {
            this.DosyaAdi = DosyaAdi;
            this.Message = Message;
        }

        public bool Yaz(string message)
        {
            File.WriteAllText(DosyaAdi,message);
            return true;
        }
    }
}
