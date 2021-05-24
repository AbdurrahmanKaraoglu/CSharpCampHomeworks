using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int,decimal,float,double,enum,bool --> value types
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("Sayı 1 : " + sayi1); // --> 20

          
        }
    }
}
