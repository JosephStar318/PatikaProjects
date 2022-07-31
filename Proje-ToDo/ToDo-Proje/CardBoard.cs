using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_Proje
{
    class CardBoard
    {
        private static List<Card> toDoCards = new List<Card>();
        private static List<Card> inProgressCards = new List<Card>();
        private static List<Card> finishedCards = new List<Card>();

        public void ListCardBoard()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            foreach (var card in toDoCards)
            {
                ListCard(card);
                Console.WriteLine("-");
            }
            if (toDoCards.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }

            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            foreach (var card in inProgressCards)
            {
                ListCard(card);
                Console.WriteLine("-");
            }
            if (inProgressCards.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }

            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");
            foreach (var card in finishedCards)
            {
                ListCard(card);
                Console.WriteLine("-");
            }
            if(finishedCards.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
        }
        public Card SearchCard(string header)
        {
            foreach (var card in toDoCards)
            {
                if(card.CardHeader == header)
                {
                    return card;
                }
            }
            foreach (var card in inProgressCards)
            {
                if (card.CardHeader == header)
                {
                    return card;
                }
            }
            foreach (var card in finishedCards)
            {
                if (card.CardHeader == header)
                {
                    return card;
                }
            }
            return null;
        }
        public void AddCard(Card card)
        {
            toDoCards.Add(card);
        }
        public void RemoveCard(Card card)
        {
            if (card.CardType == CardType.TODO)
            {
                toDoCards.Remove(card);
            }
            else if (card.CardType == CardType.INPROGRESS)
            {
                inProgressCards.Remove(card);
            }
            else if (card.CardType == CardType.DONE)
            {
                finishedCards.Remove(card);
            }
        }
        public void MoveCard(Card card, CardType destinationCard )
        {
            RemoveCard(card);
            if (destinationCard == CardType.TODO)
            {
                toDoCards.Add(card);
                card.CardType = CardType.TODO;
            }
            else if (destinationCard == CardType.INPROGRESS)
            {
                inProgressCards.Add(card);
                card.CardType = CardType.INPROGRESS;
            }
            else if (destinationCard == CardType.DONE)
            {
                finishedCards.Add(card);
                card.CardType = CardType.DONE;
            }
        }
        public void ListCard(Card card)
        {
            Console.WriteLine("Başlık      :{0}", card.CardHeader);
            Console.WriteLine("İçerik      :{0}", card.CardContent);
            Console.WriteLine("Atanan Kişi :{0}", card.DedicatedUser);
            Console.WriteLine("Büyüklük    :{0}", card.CardSize);
        }
    }
    public enum CardType
    {
        TODO = 1,
        INPROGRESS,
        DONE
    }
}
