
using System;
using System.Linq;

namespace ConsoleApp2
{ class App
    {
        public static void Main()
        {
            Console.WriteLine("birinci sayıyı giriniz");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("ikinci sayıyı giriniz");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} sayısının {1} 'li  kombinasyonu :  {2}", n, r, combination(n, r));


        }

        public static int combination(int n, int r)
        {
            int result = 1;

            for (int i = 0; i < r; i++)
            {
                result *= n;
                n--;

            }
            return result / Faktoryel(r);


        }

        public static int Faktoryel(int n)
        {
            if (n == 0)
                return 1;
            return n * Faktoryel(n - 1);
        }



    }
}

   
}
