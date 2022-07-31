using System;
using System.Collections.Generic;
using System.Text;

namespace Proje_Telefon_Rehberi
{
    public class PhoneBook
    {
        public static List<PhoneBook> phoneBookList = new List<PhoneBook>();
        private string _phoneUsername;
        private string _phoneSurname;
        private long _phoneNumber;
        public string PhoneUsername { get => _phoneUsername; set => _phoneUsername = value; }
        public long PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string PhoneSurname { get => _phoneSurname; set => _phoneSurname = value; }

        public void AddUser(string phoneUsername,string phoneSurname,long phoneNumber)
        {
            PhoneBook phoneUser1 = new PhoneBook();
            phoneUser1.PhoneUsername = phoneUsername;
            phoneUser1.PhoneSurname = phoneSurname;
            phoneUser1.PhoneNumber = phoneNumber;
            phoneBookList.Add(phoneUser1);
        }
        public void DeleteUser(string filter)
        {
            foreach (var item in phoneBookList)
            {
                if(item.PhoneUsername == filter || item.PhoneSurname == filter)
                {
                    phoneBookList.Remove(item);
                    return;
                }
            }
        }
        public bool SearchUser(string filter)
        {
            foreach (var item in phoneBookList)
            {
                if (item.PhoneUsername == filter || item.PhoneSurname == filter)
                {
                    return true;
                }
            }
            return false;
        }
        public void UpdateUser(string filter,long number)
        {
            foreach (var item in phoneBookList)
            {
                if (item.PhoneUsername == filter || item.PhoneSurname == filter)
                {
                    item.PhoneNumber = number;
                }
            }
        }
        public void ListPhoneBook()
        {
            foreach (var item in phoneBookList)
            {
                Console.WriteLine("isim: {0}", item.PhoneUsername);
                Console.WriteLine("Soyisim: {0}", item.PhoneSurname);
                Console.WriteLine("Telefon Numarası: {0}", item.PhoneNumber);
                Console.WriteLine("-");
            }
        }
        public void ListPhoneUser(string filter)
        {
            foreach (var item in phoneBookList)
            {
                if (item.PhoneUsername == filter || item.PhoneSurname == filter)
                {
                    Console.WriteLine("isim: {0}", item.PhoneUsername);
                    Console.WriteLine("Soyisim: {0}", item.PhoneSurname);
                    Console.WriteLine("Telefon Numarası: {0}", item.PhoneNumber);
                    Console.WriteLine("-");
                }
            }
        }
        public void ListPhoneUser(long filter)
        {
            foreach (var item in phoneBookList)
            {
                if (item.PhoneNumber == filter)
                {
                    Console.WriteLine("isim: {0}", item.PhoneUsername);
                    Console.WriteLine("Soyisim: {0}", item.PhoneSurname);
                    Console.WriteLine("Telefon Numarası: {0}", item.PhoneNumber);
                    Console.WriteLine("-");
                }
            }
        }

    }
}
