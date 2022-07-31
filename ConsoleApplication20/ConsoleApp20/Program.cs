using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {

            Calisan calisan1 = new Calisan();

            calisan1.Ad = "Yusuf";
            calisan1.Soyad = "Yıldız";
            calisan1.No = 123;
            calisan1.Departman = "İnsan kaynakları";
            calisan1.CalisanBilgileri();
            Console.WriteLine("*********************");
            Calisan calisan2 = new Calisan();

            calisan2.Ad = "Ahmet";
            calisan2.Soyad = "Yıldız";
            calisan2.No = 324;
            calisan2.Departman = "Satın Alım";
            calisan2.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}", Ad);
            Console.WriteLine("Çalışan Syoadı:{0}", Soyad);
            Console.WriteLine("Çalışan No:{0}", No);
            Console.WriteLine("Çalışan Departman:{0}", Departman);
        }
    }
}
