using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList primeNums = new ArrayList();
            ArrayList nonePrimeNums = new ArrayList();
            bool validInput = false;
            string input;
            int count = 0;

            Console.WriteLine("Lütfen 20 adet sayı giriniz");
            while(!validInput || count != 20)
            {
                input = Console.ReadLine();
                if(int.TryParse(input,out int result))
                {
                    if (result > 0)
                    {
                        validInput = true;
                        count++;

                        //is prime or not
                        if(IsPrime(result))
                        {
                            primeNums.Add(result);
                        }
                        else
                        {
                            nonePrimeNums.Add(result);
                        }
                    }
                }
                else
                {
                    validInput = false;
                }
            }
            primeNums.Sort();
            nonePrimeNums.Sort();
            primeNums.Reverse();
            nonePrimeNums.Reverse();

            Console.WriteLine("Asal elemanlar büyükten küçüğe...");
            foreach (var item in primeNums)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Asal olmayan elemanlar büyükten küçüğe...");
            foreach (var item in nonePrimeNums)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Asal sayıların sayısı:" + primeNums.Count);
            Console.WriteLine("Asal olmayan sayıların sayısı:" + nonePrimeNums.Count);
            int temp = 0;
            //ortalama al
            
            Console.WriteLine("Asal sayıların ortalaması:" + primeNums.Sum()/(double)primeNums.Count);
            Console.WriteLine("Asal olmayan sayıların ortalaması:" + nonePrimeNums.Sum()/ (double)nonePrimeNums.Count);
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        
    }
    public static class Extensions
    {
        public static int Sum(this ArrayList arrayList)
        {
            int temp = 0;
            
            foreach (int item in arrayList)
            {
                temp += item;
            }
            return temp;
            
        }
    }

}
