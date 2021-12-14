using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
    public static class Game
    {
        public static void Start()
        {
            var cards = CardHelper.GetDeck();
            TestDeck(cards);
        }
        public static void TestDeck(List<Card> cards)
        {
            foreach (var card in cards)
            {
                Console.Write($" | {card.Value}, {card.Color}, {card.Suit}");
            };
        }

        public static void Deal()
        {

        }
    }
}
