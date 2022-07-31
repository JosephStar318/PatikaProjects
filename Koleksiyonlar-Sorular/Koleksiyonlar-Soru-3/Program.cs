using System;
using System.Collections;
using System.Collections.Generic;


namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle giriniz!");
            string sentence = Console.ReadLine();
            List<string> vowelList = new List<string>();
            List<string> consonantlList = new List<string>();

            
            foreach (char character in sentence.ToLower())
            {
                if(character == 'a' || character == 'e' || character == 'i' || character == 'ı' || character == 'o' || character == 'ö' || character == 'u' || character == 'ü')
                {
                    vowelList.Add(character.ToString());
                }
                else
                {
                    consonantlList.Add(character.ToString());
                }
            }
            vowelList.Sort();
            consonantlList.Sort();
            Console.WriteLine("Sesli harfler sıralı");
            foreach (var item in vowelList)
            {
                Console.Write(" {0} ", item);
            }
            Console.WriteLine("\nSessiz harfler sıralı");
            foreach (var item in consonantlList)
            {
                Console.Write(" {0} ", item);
            }
        }
    }
}
