using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interfaceler birbirinin alternatifi olan fakat farklı kod içerikleri farklı olan durumlar için kullanılır.
    //Bunların hepsi birbirinin alternatifidir. Her kredi türü hesaplama işini farklı yapar.
    //Yani bu sadece base görevi görür.
    interface IKrediManager //Class yazan yeri interface ile değiştirdik //okunurluğu arttırmak için I harfi ile başlarız
    {
        //Ortalama bir bankada çok fazla kredi vardır. tüm hesaplamaları buraya yazarsak olmaz.
        //yeni bir classmanager oluşturmalıyız
        void Hesapla(); //Süslü parantezler ve public kısmı silindi
        void BiseyYap(); //örnek olsun diye yazdık

        //her iki void her kredi türünde olmak zorundadır
    }
}

//Loglama=kim ne zaman hangi operasyonu çağırdı. Logları bir dosyada tutabiliriz yada veri tabanı yada sms te tutmak mail atmak.
//Hepsinin imzasi aynı fakat kodları farklıdır.
