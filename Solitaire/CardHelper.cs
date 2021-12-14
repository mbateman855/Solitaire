using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
    public static class CardHelper
    {
        public static List<Card> GetDeck()
        {
            //GenerateDeck();
            return ShuffleDeck(GenerateDeck());
        }
        public static List<Card> GenerateDeck()
        {
            List<Card> cards = new List<Card>();

            for (int i = 1; i <= 13; i++)
            {
                cards.Add(new Card(i, "black", "spade"));
                cards.Add(new Card(i, "black", "club"));
                cards.Add(new Card(i, "red", "heart"));
                cards.Add(new Card(i, "red", "diamond"));
            }

            return cards;
        }

        public static List<Card> ShuffleDeck(List<Card> cards)
        {
            List<Card> shuffledDeck = new List<Card>();

            Random rand = new Random();

            //rand.Next(1, 14);

            List<int> randIndex = new List<int>();
            int index = 0;
            while (index < 13)
            {
                var randCheck = rand.Next(1, 14);
                bool badNumber = false;

                if (index == 0)
                {
                    randIndex.Add(cards[randCheck].Value);
                    index++;
                }
                else
                {
                    foreach (var num in randIndex)
                    {
                        if (randCheck == num)
                        {
                            badNumber = true;
                        }
                    }

                    if (!badNumber)
                    {
                        randIndex.Add(randCheck);
                        index++;
                    }


                }
            }

            foreach (var card in cards)
            {
                foreach (var randCard in randIndex)
                {
                    if (cards.IndexOf(card) == randCard)
                    {
                        shuffledDeck.Add(card);
                    }
                }
            }


            return shuffledDeck;
        }
    }
}
