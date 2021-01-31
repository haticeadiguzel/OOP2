using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {                                                      //burda log ekledik //buna method injection denir
        public void BasvuruYap(IKrediManager kredimanager, ILoggerService loggerService)//IKrediManager hepsini tutuyor. Bu yüzden parametre kısmına bunu yazarsak istediğimiz krediye göre seçim yaparız.
        {
            //Başvuranın bilgilerini değerlendirme
            //
            //KonutKrediManager konutKrediManager = new KonutKrediManager(); //Bu şekilde yazdığımız anda tüm başvurular 
            //konutKrediManager.Hesapla();                                   //konut kredi hesaplamasıyla yapılır

            //yukarıdaki iki işleme gerek kalmaz
            kredimanager.Hesapla(); //otomatik olarak istediğimiz krediye ait kısım gelir.
            loggerService.Log(); //hangi loglayıcı seçildiyse onu logla
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
