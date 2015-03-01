using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        public static DateTime ilkZaman = new DateTime();


        static void Main(string[] args)
        {

            Console.Write("Calisma seklini seciniz 1?2 : /n Recursive:1 Loop:2 -> ");
            int secim = int.Parse(Console.ReadLine());
            if (secim==1)
            {
                ilkZaman = DateTime.Now;
                for (int i = 0; i <= 80; i=i+1)
                {
                    Console.WriteLine(i +".Fibonacci sayisi");
                    Console.WriteLine("Degeri : " + fiborecusive(i));
                    Console.WriteLine("Hesaplama Süresi : " + (DateTime.Now - ilkZaman));
                    Console.WriteLine("____________________");
                }
            }
            else
            {
                ilkZaman = DateTime.Now;
                decimal a, b, c;
                a = 0;b = 1;c = 1;
                int k = 1;
                for (int i = 0; i <= 150; i=i+10)
                {
                    
                    if (i < 2)
                    { c = i; }
                    else
                    {                       
                        while (k < i)
                        {
                            c = a + b;
                            a = b;
                            b = c;
                            k++;
                        }
                    }
                    Console.WriteLine(i + ".Fibonacci sayisi");
                    Console.WriteLine("Degeri : " + c);
                    Console.WriteLine("Hesaplama Süresi : " + (DateTime.Now - ilkZaman));
                    Console.WriteLine("____________________");

                    
                }

            }
            Console.ReadKey();
        }

        private static long fiborecusive(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
                return (fiborecusive(n - 1) + fiborecusive(n - 2));
        }

        
    }
}
