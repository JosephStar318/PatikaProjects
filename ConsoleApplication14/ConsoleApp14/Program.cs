using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintOutEvenNumbers();
            PrintOutFullyDivided();
            PrintOutStringsInReverse();
            PrintOutWordCharacterCount();
        }

        private static void PrintOutWordCharacterCount()
        {
            Console.WriteLine("Lütfen bir cümle yazın.");
            string str = Console.ReadLine();
            Console.WriteLine("Cümledeki kelime sayısı: {0}", str.Split(" ").Length);
            Console.WriteLine("Cümledeki harf sayısı: {0}", str.Length);
        }

        private static void PrintOutStringsInReverse()
        {
            Console.WriteLine("Lütfen pozitif bir sayı girin");
            int n = int.Parse(Console.ReadLine());
            string[] strArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                strArray[i] = Console.ReadLine();
            }
            Array.Reverse(strArray);
            foreach (var item in strArray)
            {
                Console.WriteLine(item);
            }
        }

        private static void PrintOutFullyDivided()
        {
            Console.WriteLine("Lütfen pozitif iki sayı girin");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen pozitif {0} adet sayı girin", n);
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in nums)
            {
                if (item % m == 0) Console.WriteLine(item);
            }
        }

        private static void PrintOutEvenNumbers()
        {
            int num;
            Console.WriteLine("Lütfen pozitif bir sayı girin");
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Hatalı giriş yaptınız.");
                return;
            }
            Console.WriteLine("Lütfen pozitif {0} adet sayı girin",num);
            int[] nums = new int[num];
            for (int i = 0; i < num; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in nums)
            {
                if (item % 2 == 0) Console.WriteLine(item);
            }
        }
    }
}
