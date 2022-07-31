using System;
using System.Collections;
using System.Collections.Generic;


namespace ToDo_Proje
{
    class Program
    {
        public static CardBoard cardBoard = new CardBoard();
        public static Dictionary<string, int> teamMember = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            teamMember.Add("Ali", 1);
            teamMember.Add("Ahmet", 2);
            teamMember.Add("Hüseyin", 3);
            teamMember.Add("Ayşe", 4);
            teamMember.Add("Fatma", 5);

            while(true)
            {
                QuestionUser();
            }
        }

        private static void QuestionUser()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            string input = Console.ReadLine();
            Console.Clear();
            switch (input)
            {
                case "1":
                    ListBoard();
                    break;
                case "2":
                    AddCard();
                    break;
                case "3":
                    RemoveCard();
                    break;
                case "4":
                    MoveCard();
                    break;
                default:
                    Console.WriteLine("Hatalı giriş yaptınız.");
                    break;
            }
        }

        private static void MoveCard()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            Card card = cardBoard.SearchCard(Console.ReadLine());
            if (card != null)
            {
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("************************");
                cardBoard.ListCard(card);

                Console.WriteLine(" Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                Console.WriteLine(" (1) TODO");
                Console.WriteLine(" (2) IN PROGRESS");
                Console.WriteLine(" (3) DONE");

                CardType cardType = (CardType)int.Parse(Console.ReadLine());
                cardBoard.MoveCard(card, cardType);
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Taşımayı sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    //do nothing
                }
                else
                {
                    MoveCard();
                }
            }
        }

        private static void RemoveCard()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            Card card = cardBoard.SearchCard(Console.ReadLine());
            if(card != null)
            {
                cardBoard.RemoveCard(card);
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                string input = Console.ReadLine();
                if(input == "1")
                {
                    //do nothing
                }
                else
                {
                    RemoveCard();
                }
            }
         

        }

        private static void AddCard()
        {
            Console.Write("Başlık Giriniz                                  : ");
            string header = Console.ReadLine();
            Console.Write("İçerik Giriniz                                  : ");
            string content = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  : ");
            Size cardSize = (Size)int.Parse(Console.ReadLine());
            Console.Write("Kişi Seçiniz                                    : ");
            string user = Console.ReadLine();
            if (teamMember.TryGetValue(user, out int value))
            {
                Card card = new Card(header, content, user, cardSize);
                cardBoard.AddCard(card);
            }
            else
            {
                Console.WriteLine("Hatalı kullanıcı girişi");
            }
            
        }

        private static void ListBoard()
        {
            cardBoard.ListCardBoard();
        }
    }
}
