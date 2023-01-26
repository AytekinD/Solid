using DIP_DependencyInversionPrinciple_.Loglama.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_DependencyInversionPrinciple_.Loglama.Concrete
{
    public class FileLogger : ILogger
    {
        public string DosyaAdi { get; set; }
        public void Logla(string message)
        {
            Console.WriteLine("Dosyaya kaydedildi:" + message);
        }
        public string DosyaPath()
        {

            return @"c:\Temp\abc.txt";
        }
    }
}
