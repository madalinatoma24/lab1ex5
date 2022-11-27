using System;

namespace lab1ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.
            • Exemplu: citim ,9,0 Afisam : 0 9
             */

            int x;
            int y;
            Console.WriteLine("Primul numar:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Al doilea numar:");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Numerele ordonate crescator:");
            if(x < y)
            {
                Console.WriteLine("{0} {1}", x, y);
            }
            else
            {
                Console.WriteLine("{0} {1}", y, x);
            }
        }
    }
}
