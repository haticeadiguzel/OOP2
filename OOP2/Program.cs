using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bunun enginle alaksı yok o bir şahıs bir şirket değil. Bu hatalıdır. Zamanla şirketin Tc'nosu olan tüzel müşteriler vs olabilir. Bunlar yanlışlıkla girilmiş olabilir.
            //Gerçek - Tüzel benziyorlar diye irbirlerinin yerine kullanılamaz
            //SOLID tekniği
            //Bu karışıklığı önlemek için iki ayrı class kurmak daha mantıklıdır

            //Engin Demiroğ 
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678912";
            
            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "15478";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "12457896312";

            Musteri musteri3 = new GercekMusteri();  //Bir yerde new görürsek ref.No olarak okuyalım
            Musteri musteri4 = new TuzelMusteri();   //Musteri Class'ı hem gerçek müşterinin hem tüzel müşterinin referansını tutabiliyor.

            MusteriManager musteriManager = new MusteriManager(); //Managerde müşteri diye paremetre gönderdiğimiz için
            musteriManager.Ekle(musteri1);                        //Ekle kısmında musteri ister. tüm oluşturulan müşteriler eklenebilir.
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
        }
    }
}
