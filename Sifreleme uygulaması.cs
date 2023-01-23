using System;
using System.Linq;

// girilen bir metnin herbir harfine sırasıyla fibonacci rakamı ekleyen ve bu rakamlarla yeni bir metin şifresi oluşturan
// ve daha sonrasında bu sifreyi çözüp eski haline getiren uygulamayı metodlar yazarak geliştrin
namespace ConsoleApp2
{ class App
    {
        public static void Main()
        {
            int options;
            do
            {
                Console.WriteLine("MENÜ");
                Console.WriteLine("--------------------");
                Console.WriteLine("1-sifrele");
                Console.WriteLine("2-sifre çöz");
                Console.WriteLine("3-çıkış");
                Console.WriteLine("seçiniz");
                options = int.Parse(Console.ReadLine());

                if (options == 1)
                {
                    Console.Clear();
                    Console.WriteLine("bir yazı giriniz");
                    string s = Console.ReadLine();
                    Console.WriteLine("sifrelenecek metin = {0}", s);
                    Console.WriteLine("sifrelenmiş metin = {0}", sifreOlustr(s));
                }
                else if (options == 2)
                {
                    Console.Clear();
                    Console.WriteLine("bir yazı giriniz");
                    string str = Console.ReadLine();
                    Console.WriteLine("cözülecek metin = {0}", str);

                    Console.WriteLine("orjinal metin = {0}", sifreçöz(str));
                }

                else if (options == 3)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("lütfen 1 ile 3 arasında bir sayı seçimi yapınız");

                }
            } while (true);

            Console.WriteLine("çıkış yaptınız");

        }

        public static string sifreOlustr(string s)
        {
            int sifrelenecekMetin = 0;
            string str = "";
            for (int i = 0; i < s.Length; i++)
            {
                sifrelenecekMetin = s[i] + fibonacci(s, i);
                str += sifrelenmisİfade(sifrelenecekMetin);

            }
            return str;
        }
        public static string sifreçöz(string str)
        {
            int sifrelenmişKod = 0;
            string sifreOrjinal = "";
            for (int i = 0; i < str.Length; i++)
            {
                sifrelenmişKod = str[i] - fibonacci(str, i);
                sifreOrjinal += sifrelenmisİfade(sifrelenmişKod);

            }
            return sifreOrjinal;

        }
        public static char sifrelenmisİfade(int sifrekod)
        {
            char c = (char)sifrekod;
            return c;

        }

        public static int fibonacci(string s, int a)
        {

            int sayı1 = 0, sayı2 = 1, yenisayı = 0;
            int len = s.Length;
            if (a == 0)
                return 0;
            if (a == 1)
                return 1;
            if (a >= 2)
            {

                for (int i = 2; i <= a; ++i)
                {
                    yenisayı = sayı1 + sayı2;
                    sayı1 = sayı2;
                    sayı2 = yenisayı;
                }


            }
            return yenisayı;


        }
}

   
}
