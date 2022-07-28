using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayidizisi = { 23, 12, 53, 75, 23, 6, 1, 4 };
            Console.WriteLine("************Sırasız Liste");
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("************Sıralı Liste");

            Array.Sort(sayidizisi);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("************Array clear");

            Array.Clear(sayidizisi, 2, 2);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("************Array reverse");

            Array.Reverse(sayidizisi);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("************Array indexof");

           
            Console.WriteLine(Array.IndexOf(sayidizisi, 23));

            Console.WriteLine("************Array resize");

            Array.Resize<int>(ref sayidizisi, 9);
            sayidizisi[8] = 90;
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
