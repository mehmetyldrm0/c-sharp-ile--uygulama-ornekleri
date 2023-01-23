using System;
using System.Linq;

namespace ConsoleApp2
{ class App
    {
        public static void Main()
        {

            // KULLANICIDAN ALDIĞI KULLANICI BİLGİLERİ İLE
            // * EĞER GİRİŞ BİLGİLERİ UYUŞUYORSA "GİRİŞ BAŞARILI"
            // * EĞER HATALI BİR GİİRİŞ YAPILDIYSA GİRİŞ BAŞARISIZ VE DENEME HAKKINI GÖSTERİNİZ
            // 3 DENEMEDE BAŞARISIZ OLURSA GİRİŞ BAŞARISIZ DENEME HAKKINIZ BİTTİ YAZISINI EKRANA BASAN UYGULAMAYI EKRANA BASINIZ/
            int count = 3;

            for (; ; )
            {
                Console.WriteLine("kullanıcı adınızı giriniz");
                string usurname = Console.ReadLine();
                Console.WriteLine("şifrenizi giriniz");
                string password = Console.ReadLine();
                --count;

                if (usurname == "admin" && password == "12345")
                    break;
                else if (count == 0)
                    break;
                else
                {
                    Console.Clear();
                    Console.WriteLine("HATALI GİRİŞ YAPTINIZ {0} DENEME HAKKINIZ KALDI", count);
                }

            }
            if (count == 0)
                Console.WriteLine("******HATALI GİRİŞ YAPTINIZ ARTIK DENEME HAKKINIZ BİTTİ******");

            else if (count != 0)
                Console.WriteLine("******GİRİŞ BAŞARILI******");


        }
    }

   
}
