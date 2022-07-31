using System;
using System.Collections;
using System.Collections.Generic;


namespace Proje_Telefon_Rehberi
{
    class Program
    {
        public static PhoneBook phoneBook = new PhoneBook();
        static void Main(string[] args)
        {
            while(true)
            {
                
                QuestionUser();
            }
        }

        private static void QuestionUser()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("********************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    PhoneBookAdd();
                    break;
                case 2:
                    PhoneBookDeletion();
                    break;
                case 3:
                    PhoneBookUpdate();
                    break;
                case 4:
                    ListPhoneBook();
                    break;
                case 5:
                    ListPhoneUser();
                    break;
                default:
                    Console.WriteLine("Hatalı giriş");
                    QuestionUser();
                    break;
            }
        }

        private static void ListPhoneUser()
        {
            Console.Clear();
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            string prompt = Console.ReadLine();
            if(prompt == "1")
            {
                Console.WriteLine("Aramak için kullanıcı adı giriniz.");
                string name = Console.ReadLine();
                phoneBook.ListPhoneUser(name);
            }
            else if(prompt == "2")
            {
                Console.WriteLine("Aramak için numara giriniz.");
                long number = long.Parse(Console.ReadLine());
                phoneBook.ListPhoneUser(number);
            }

        }

        private static void ListPhoneBook()
        {
            Console.Clear();
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            phoneBook.ListPhoneBook();
        }

        private static void PhoneBookAdd()
        {
            Console.Clear();
            Console.Write("Lütfen isim giriniz             :");
            string name = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz          :");
            string surname = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz :");
            long number = long.Parse(Console.ReadLine());
            phoneBook.AddUser(name, surname, number);
        }

        private static void PhoneBookUpdate()
        {
            Console.Clear();
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string name = Console.ReadLine();
            if(phoneBook.SearchUser(name))
            {
                Console.WriteLine("Lütfen güncellemek istediğiniz numarayı giriniz.");
                long number = long.Parse(Console.ReadLine());
                phoneBook.UpdateUser(name,number);
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
                Console.WriteLine("* Yeniden denemek için              : (2)");
                string prompt = Console.ReadLine();
                if(prompt == "1")
                {
                    //do nothing
                }
                else if(prompt == "2")
                {
                    PhoneBookUpdate();
                }
            }
        }
        private static void PhoneBookDeletion()
        {
            Console.Clear();
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string username = Console.ReadLine();
            if (phoneBook.SearchUser(username))
            {
                Console.WriteLine(" {0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", username);
                string prompt = Console.ReadLine();
                if (prompt == "y")
                {
                    phoneBook.DeleteUser(username);
                }
                else if(prompt == "n")
                {
                    //do nothing
                }
            }
            else
            {
                Console.WriteLine(" Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int input1 = int.Parse(Console.ReadLine());
                if (input1 == 2)
                {
                    PhoneBookDeletion();
                }
            }
        }
    }
}
