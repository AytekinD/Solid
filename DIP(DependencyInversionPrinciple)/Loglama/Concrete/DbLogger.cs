using DIP_DependencyInversionPrinciple_.Loglama.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_DependencyInversionPrinciple_.Loglama.Concrete
{
    public class DbLogger:ILogger
    {
        public void Logla(string message)
        {
            Console.WriteLine("database Yazildi:" + message);
        }
    }
}
