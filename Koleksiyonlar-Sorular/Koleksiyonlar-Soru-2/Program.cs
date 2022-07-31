using System;
using System.Collections;
using System.Collections.Generic;


namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;
            string input;
            int count = 0;
            int[] nums = new int[20];
            Console.WriteLine("Lütfen 20 adet sayı giriniz");
            while (!validInput || count != 20)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    if (result > 0)
                    {
                        validInput = true;
                        nums[count] = result;
                        count++;

                    }
                }
                else
                {
                    validInput = false;
                }
            }
            Array.Sort(nums);
            int[] smallNums = { nums[0], nums[1], nums[2] };
            int[] bigNums = { nums[nums.Length - 1], nums[nums.Length - 2], nums[nums.Length - 3] };
            Console.WriteLine("En büyük üç sayının ortalaması: {0}", bigNums.Mean());
            Console.WriteLine("En küçük üç sayının ortalaması: {0}", smallNums.Mean());
            Console.WriteLine("Ortalamalar toplamı: {0}", (bigNums.Mean()+smallNums.Mean()));


        }
    }
    public static class Extensions
    {
        public static double Mean(this int[] arr)
        {
            int temp = 0;
            foreach (int item in arr)
            {
                temp += item;
            }
            return (double)temp / arr.Length;
        }
    }
}
