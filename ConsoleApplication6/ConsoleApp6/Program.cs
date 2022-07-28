﻿using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındasınız");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındasınız");
                    break;
                case 3:
                    Console.WriteLine("Mart ayındasınız");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayındasınız");
                    break;
                default:
                    Console.WriteLine("Yanlış veri");
                    break;
            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış ayındasınız");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("ilk bahar ayındasınız");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaz ayındasınız");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("son bahar ayındasınız");
                    break;
                default:
                    break;
            }
        }
    }
}