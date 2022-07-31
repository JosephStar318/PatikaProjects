using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);
            int sicaklik = 32;
            if(sicaklik <= (int)HavaSicakligi.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için biraz daha ısınmasını bekleyelim.");
            }
            else if(sicaklik >= (int)HavaSicakligi.Sıcak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak.");
            }
            else if(sicaklik >= (int)HavaSicakligi.Normal && sicaklik <= (int)HavaSicakligi.Sıcak)
            {
                Console.WriteLine("Hadi dışarı çıkalım.");
            }
        }
    }
    enum Gunler
    {
        Pazartesi,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum HavaSicakligi
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 30
    }
}
