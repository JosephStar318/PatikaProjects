using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_Proje
{
    public class Card
    {
        private string _cardHeader;
        private string _cardContent;
        private string _dedicatedUser;
        private CardType _cardType = CardType.TODO;
        private Size _cardSize;
        public string CardHeader { get => _cardHeader; set => _cardHeader = value; }
        public string CardContent { get => _cardContent; set => _cardContent = value; }
        public string DedicatedUser { get => _dedicatedUser; set => _dedicatedUser = value; }
        internal Size CardSize { get => _cardSize; set => _cardSize = value; }
        public CardType CardType { get => _cardType; set => _cardType = value; }

        public Card(string cardHeader, string cardContent, string dedicatedUser, Size cardSize)
        {
            _cardHeader = cardHeader;
            _cardContent = cardContent;
            _dedicatedUser = dedicatedUser;
            _cardSize = cardSize;
        }
    }
    public enum Size
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}
