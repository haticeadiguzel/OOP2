using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class GercekMusteri:Musteri //inheritance'dir bu.    //individual customer
    {
        
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; } //Eğer kullanılan sayı matematiksel işlemlerde kullanılmıyorsa string olarak tanımlarız
    }
}
