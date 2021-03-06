using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeTekno.DATA
{

    //Urun
    //* UrunAd: string
    //* BirimFiyat: decimal
    //- ToString() : string
    public class Urun
    {
        public string UrunAd { get; set; }
        public decimal BirimFiyat { get; set; }

        public override string ToString()
        {
            return $"{UrunAd} (₺{BirimFiyat:n2})";
        }

    }
    
}
