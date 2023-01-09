using System;

namespace lab4ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrieti o functie recursiva care pentru un numar “n” primit ca parametru, va afisa urmatoarea piramida a numerelor:
            Console.WriteLine("Introduceti n: ");
            int n = int.Parse(Console.ReadLine());
            Pyramid(n);
        }
        static void Pyramid(int n)
        {
            if(n<=0)
            {
                return;
            }
            int i= n;
            while(i!=0)
            {
                Console.Write(n + " ");
                i--;
            }
            Console.WriteLine();
            Pyramid(n - 1);
        }
    }
}
