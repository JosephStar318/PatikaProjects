using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayi giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while(sayac <= sayi)
            {
                toplam += sayi;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            char character = 'a';
            while(character < 'z')
            {
                Console.WriteLine(character);
                character++;
            }
            Console.WriteLine("***********foreach");

            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
