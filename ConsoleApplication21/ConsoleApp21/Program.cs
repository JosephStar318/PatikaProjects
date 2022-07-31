using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {

            Calisan calisan1 = new Calisan("Yusuf", "Yıldız", 123, "İnsan kaynakları");
            calisan1.CalisanBilgileri();
            Console.WriteLine("*********************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Ahmet";
            calisan2.Soyad = "Yıldız";
            calisan2.No = 324;
            calisan2.Departman = "Satın Alım";
            calisan2.CalisanBilgileri();
            Console.WriteLine("*********************");

            Calisan calisan3 = new Calisan("Elif", "Kara");
            calisan3.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public Calisan() { }
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı:{0}", Ad);
            Console.WriteLine("Çalışan Syoadı:{0}", Soyad);
            Console.WriteLine("Çalışan No:{0}", No);
            Console.WriteLine("Çalışan Departman:{0}", Departman);
        }
    }
}
