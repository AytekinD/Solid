using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Bad
{
    internal class Kare:Dikdortgen
    {
        int _KisaKenar;
        int _UzunKenar;

        public override int KisaKenar
        {
            get 
            { 
            
                return _KisaKenar;
            }
            set 
            { 
                _KisaKenar= value;
                _UzunKenar= value;
            }
        }


        public override int UzunKenar {
            get 
            {
                return (int)_UzunKenar;
            } 
            set 
            {
                _KisaKenar = value;
                _UzunKenar= value;
            }
                
          }
    }
}
