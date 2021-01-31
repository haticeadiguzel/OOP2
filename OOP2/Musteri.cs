using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Classların iki önemli özelliği vardır. 1. Özellikleri tutarlar 2. Operasyonlar tutarlar. 
    //Özellik olan yerde operasyonları tutmuyoruz operasyonları tuttuğumuz yerde özellikleri tutmuyoruz
    //Müşteri burda ebeveyn gibidir
    //base sınıf referans tutucudur
    class Musteri //Hem gerçek hem tüzel için geçerli olanları burada kullandık
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; } 

        //Eğer bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsa
        //o nesneye ait gibi durmuyorsa orada soyutlama hatası yapıyoruzdur 

    }
}
