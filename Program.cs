using System;

namespace dsföcaidföiş
{
    class Program
    {
        static void Main(string[] args)
        {
            string UrunAdi = "Elma";
            double UrunFiyatı = 10;
            string Açıklama = "Amasya Elması";

            string[]meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adı = "Elma";
            urun1.Fiyat = 10;
            urun1.Açıklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adı = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Açıklama = "Diyarbakır Karpuzu";


            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adı);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Açıklama);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("------------------------dsföcaidföiş---------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
        }
    }
}
