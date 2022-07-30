using System;
using System.Collections.Generic;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Sarı");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Yeşil");

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var item in sayiListesi)
            {
                Console.WriteLine(item);
            }
            foreach (var item in renkListesi)
            {
                Console.WriteLine(item);
            }

            sayiListesi.ForEach((item) => Console.WriteLine(item));
            renkListesi.ForEach((item) => Console.WriteLine(item));

            sayiListesi.RemoveAt(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach((item) => Console.WriteLine(item));
            renkListesi.ForEach((item) => Console.WriteLine(item));

            if(sayiListesi.Contains(10))
            {
                Console.WriteLine("10 Liste içerinde bulundu");
            }
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            string[] hayvanlar = { "kedi", "köpek", "kuş" };
            List<string> hayvanlarListesi = new List<string>(hayvanlar);
            hayvanlarListesi.Clear();

            List<Kullanıcılar> kullanicilarListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanici1 = new Kullanıcılar();
            kullanici1.Isim = "Yusuf";
            kullanici1.SoyIsim = "Yıldız";
            kullanici1.Yas = 22;

            Kullanıcılar kullanici2 = new Kullanıcılar();
            kullanici1.Isim = "Ahmet";
            kullanici1.SoyIsim = "Yıldız";
            kullanici1.Yas = 25;


            kullanicilarListesi.Add(kullanici1);
            kullanicilarListesi.Add(kullanici2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar
            {
                Isim = "Deniz",
                SoyIsim = "Arda",
                Yas = 21
            });
            foreach (var item in kullanicilarListesi)
            {
                Console.WriteLine("Kullanıcı Adı:" + item.Isim);
                Console.WriteLine("Kullanıcı Soyadı:" + item.SoyIsim);
                Console.WriteLine("Kullanıcı Yaşı:" + item.Yas);
            }
        }
    }
    public class Kullanıcılar
    {
        string isim;
        string soyIsim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsim { get => soyIsim; set => soyIsim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
