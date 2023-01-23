using System;
using System.Linq;


namespace ConsoleApp2
{ class App
    {
        public static void Main()
        {
            /* UYGULAMA SORULARI ÖRNEK8;
              BİLGİSAYARIN TUTTUĞU SAYIYI TAHMİN ETTİĞİMİZ BİR UYGULAMA GELİŞTİRİLİM 
             BİLGİSAYAR 0-100 ARASI BİR SAYI TUTSUN. GİRİLEN TAHMİN RAKAIMINA GÖRE "DAHA BÜYÜK BİR SAYI GİRİNİZ "
             YADA "DAHA KÜÇÜK BİR SAYI GİRİNİZ " DİYEREK YÖNLENDİRME YAPARAK GERÇEK SAYIYI BULMAMIZI SAĞLASIN

              */


            int sayı = new Random().Next(0, 100);
            int sayac = 0;
            int tahmin;
            Console.WriteLine("BİLGİSAYAR 0 İLE 100 ARASINDA BİR SAYI TUTTU");

            do
            {
                Console.Write("TAHMİNİZ : ");
                tahmin = int.Parse(Console.ReadLine());

                if (tahmin < sayı)
                {
                    Console.WriteLine("DAHA BÜYÜK BİR SAYI GİRİNİZ");
                    sayac++;
                }
                else if (tahmin > sayı)
                {
                    Console.WriteLine("DAHA KÜÇÜK BİR SAYI GİRİNİZ");
                    sayac++;
                }

                else
                    Console.WriteLine("TEBRİKLER {0} DENEMEDEN SONRA DOĞRU BİLDİNİZ", sayac);

            } while (tahmin != sayı);






        }
    }

   
}
