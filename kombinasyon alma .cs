
            /* UYGULAMA SORULARI ÖRNEK8;
              
               BİLGİSAYARIN TUTTUĞU SAYIYI TAHMİN ETTİĞİMİZ BİR UYGULAMA GELİŞTİRİLİM 
               BİLGİSAYAR 0-100 ARASI BİR SAYI TUTSUN. GİRİLEN TAHMİN RAKAIMINA GÖRE "DAHA BÜYÜK BİR SAYI GİRİNİZ "
               YADA "DAHA KÜÇÜK BİR SAYI GİRİNİZ " DİYEREK YÖNLENDİRME YAPARAK GERÇEK SAYIYI BULMAMIZI SAĞLASIN
               VE SONUCU DOĞRU BULDUĞUMUZDA KAÇ DENENEDEN SONRA DOĞRU BULĞUMUZADA GÖSTEREN UYGULAMAYI GELİŞTİRİN
           
             */

using System;
using System.Linq;

namespace ConsoleApp2
{ class App
    {
        public static void Main()
        {


            int number = new Random().Next(0, 100);
            int count = 0;
            int guess;
            Console.WriteLine("BİLGİSAYAR 0 İLE 100 ARASINDA BİR SAYI TUTTU");

            do
            {
                Console.Write("TAHMİNİNİZ : ");
                guess = int.Parse(Console.ReadLine());

                if (guess < number)
                {
                    Console.WriteLine("DAHA BÜYÜK BİR SAYI GİRİNİZ");
                    count++;
                }
                else if (guess > number)
                {
                    Console.WriteLine("DAHA KÜÇÜK BİR SAYI GİRİNİZ");
                    count++;
                }

                else
                    Console.WriteLine("TEBRİKLER {0} DENEMEDEN SONRA DOĞRU BİLDİNİZ", count);

            } while (guess != number);


        }
    }

   
}
