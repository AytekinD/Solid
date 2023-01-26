using ISP.Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Validate.Concrete
{
    public class Penguen : IYuruyebilir, IYuzebilir
    {
        public void Yuru()
        {
            throw new NotImplementedException();
        }

        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }
}
