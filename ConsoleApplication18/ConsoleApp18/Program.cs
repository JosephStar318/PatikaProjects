using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            //list.Add("Ayşe");
            //list.Add(2);
            //list.Add(true);
            //list.Add('A');

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //string[] renkler = { "kırmızı", "sarı", "yeşil" };
            List<int> sayilar = new List<int>() { 1, 2, 4, 5, 7, 3, 7, 1 };
            //list.AddRange(renkler);
            list.AddRange(sayilar);

            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(list.BinarySearch(7));
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Clear();


        }
       
    }
}
