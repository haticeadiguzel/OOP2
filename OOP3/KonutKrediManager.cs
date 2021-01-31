using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager //Bununda içinde hesapla olsun diye
    {
        //IKrediManager üstündeki ampulden implement interface diyince aşağıdaki kod bloğu ortaya çıkar
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
