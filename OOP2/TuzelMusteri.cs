using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class TuzelMusteri:Musteri//İnheritance. Asıl olayı müşteride olan özellikler artık tüzel ve gerçektede vardır.     //coorporate customer
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
