using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz.";
            string degisken2 = "Yusuf Yıldız.";
            //Length
            Console.WriteLine(degisken.Length);

            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            Console.WriteLine(string.Concat(degisken, "merhaba"));

            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken, degisken2,true));
            Console.WriteLine(String.Compare(degisken, degisken2,false));

            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.StartsWith("Hoşgeldiniz"));
            Console.WriteLine(degisken.EndsWith("Merhaba"));

            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("yusuf"));

            Console.WriteLine(degisken.Insert(0,"merhaba"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            Console.WriteLine(degisken + degisken2.PadLeft(30)); 
            Console.WriteLine(degisken + degisken2.PadLeft(30),'*'); 
            Console.WriteLine(degisken.PadRight(50) + degisken2); 
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            Console.WriteLine(degisken.Replace(" ", "*"));

            Console.WriteLine(degisken.Split(' ')[1]);
            Console.WriteLine(degisken.Substring(4, 6));


        }
    }
}
