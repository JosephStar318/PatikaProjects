using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5; //1 byte
            sbyte c = 3; //1 byte
                
            short s = 6; // 2 byte
            ushort us = 123; //2 byte

            Int16 i16 = 2; //2 byte
            int i = 3; // 4 byte
            Int32 i32 = 3; // 2 byte
            Int64 i64 = 3; // 4 byte
            uint ui = 3; // 4 byte
            long l = 54; // 8 byte
            ulong ul = 32; //8 byte
            float f = 3; //4 byte
            double d = 5; // 8 byte
            decimal de = 4; // 16 byte

            char ch = '2'; //2 bytge
            string str = "Yusuf"; //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            //string ifadeler

            string str1 = string.Empty;
            str1 = "Yusuf Yıldız";
            string ad = "Yusuf";
            string soyad = "Yıldız";
            string tamIsim = ad + " " + soyad;

            //integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;
            //boolean

            bool bool1 = 10 > 2;

            // değişken dönüşümleri

            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);
            int int22 = int20 + int.Parse(str20);

            //dateTime
            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);


        }
    }
}
