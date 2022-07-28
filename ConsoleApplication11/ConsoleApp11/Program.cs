using System;

namespace ConsoleApp11
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            Console.WriteLine(a + b);
            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);
            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(sonuc.ToString());

            int sonuc2 = ornek.ArtırVeTopla(ref a, b);
            ornek.EkranaYazdir(sonuc2.ToString());
            ornek.EkranaYazdir((a + b).ToString());
        }
        static int Topla(int deger1,int deger2)
        {
            return deger1 + deger2;
        }
    }
    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public int ArtırVeTopla(ref int deger1,int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}
