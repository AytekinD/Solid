using DIP_DependencyInversionPrinciple_.Loglama.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_DependencyInversionPrinciple_.Loglama.Concrete
{
    public class Loglayici
    {
        private ILogger _logger;
        public void Logla(ILogger logger, string message)
        {
            _logger = logger;

            _logger.Logla(message);

        }
    }
}
