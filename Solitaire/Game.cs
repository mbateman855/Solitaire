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
            //TestDeck(cards);
            Deal(cards);
        }
        public static void TestDeck(List<Card> cards)
        {
            foreach (var card in cards)
            {
                Console.Write($" | {card.Value}, {card.Color}, {card.Suit}");
            };
        }

        public static void Deal(List<Card> deck)
        {
            List<Card> columnOne = new List<Card> 
            {
                deck[0]
            };
            deck[0].IsFaceUp = true;
            List<Card> columnTwo = new List<Card> 
            {
                deck[1],
                deck[2]
            };
            deck[2].IsFaceUp = true;
            List<Card> columnThree = new List<Card>
            {
                deck[3],
                deck[4],
                deck[5]
            };
            deck[5].IsFaceUp = true;
            List<Card> columnFour = new List<Card>
            {
                deck[6],
                deck[7],
                deck[8],
                deck[9]
            };
            deck[9].IsFaceUp = true;
            List<Card> columnFive = new List<Card>
            {
                deck[10],
                deck[11],
                deck[12],
                deck[13],
                deck[14]
            };
            deck[14].IsFaceUp = true;
            List<Card> columnSix = new List<Card>
            {
                deck[15],
                deck[16],
                deck[17],
                deck[18],
                deck[19],
                deck[20]
            };
            deck[20].IsFaceUp = true;
            List<Card> columnSeven = new List<Card>
            {
                deck[21],
                deck[22],
                deck[23],
                deck[24],
                deck[25],
                deck[26],
                deck[27]
            };
            deck[27].IsFaceUp = true;
            List<Card> stockPile = new List<Card>();
            for(int i = 28; i < 53; i++)
            {
                stockPile.Add(deck[i]);
            }
            List<Card> drawnStockCards = new List<Card>();
            List<Card> suitStackOne = new List<Card>();
            List<Card> suitStackTwo = new List<Card>();
            List<Card> suitStackThree = new List<Card>();
            List<Card> suitStackFour = new List<Card>();
            //List<List<Card>> allCardLists = new List<List<Card>>
            //{
            //    columnOne,
            //    columnTwo,
            //    columnThree,
            //    columnFour,
            //    columnFive,
            //    columnSix,
            //    columnSeven,
            //    stockPile,
            //    drawnStockCards,
            //    suitStackOne,
            //    suitStackTwo,
            //    suitStackThree,
            //    suitStackFour
            //};

            //foreach (var card in deck)
            //{
            //    int i = 0;

            //    while(i < deck.Count)
            //    {
            //        if ()
            //    }
            //};

            //columnOne.Add(deck[0]);
            //deck[0].IsFaceUp = true;
            //columnTwo.Add(deck[1]);
            //columnTwo
            //columnThree,
            //columnFour,
            //columnFive,
            //columnSix,
            //columnSeven,
            //stockPile,
            //drawnStockCards,
            //suitStackOne,
            //suitStackTwo,
            //suitStackThree,
            //suitStackFour
        }
    }
}
