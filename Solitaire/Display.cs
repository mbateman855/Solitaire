using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
    class Display
    {
        public static void TestLayout(List<Card[]> deck)
        {
            int cardCounter = 1;
            for (int i = 0; i < 7; i++) //for the first 7 columns in the deck
            {
                foreach (var card in deck[i])
                {
                    if (card.BlankSpace == " . ")
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        //♥ ♦ ♣ ♠
                        if (card.Suit == "spade")
                        {
                            Console.Write($"  {card.Value}♠ ");
                        };
                        if (card.Suit == "club")
                        {
                            Console.Write($"  {card.Value}♣ ");
                        };
                        if (card.Suit == "heart")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"  {card.Value}♥ ");
                            Console.ForegroundColor = ConsoleColor.White;
                        };
                        if (card.Suit == "diamond")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"  {card.Value}♦ ");
                            Console.ForegroundColor = ConsoleColor.White;
                        };
                    }
                    cardCounter++;
                    //Console.WriteLine();
                }
                if (cardCounter == 7)
                {
                    //Console.Write("\n");
                    Console.WriteLine();
                    cardCounter = 1;
                }
            }
        }
        public static void DisplayDeal(List<List<Card>> deck)
        {
            //this deck has already been organized into columns and piles
            //that is why the param is a list of lists
            //int i = 0;
            //int j = 0;
            foreach (var column in deck)
            {
                if (deck.IndexOf(column) < 7)
                {

                    //columns are the first seven lists in the deck
                    foreach (var card in column)
                    {

                        Console.Write("card");
                    }
                    Console.WriteLine();
                }
            }
        }
        public static void SymbolsTest()
        {
            //Console.WriteLine("♡♢♤♧");
            Console.WriteLine("♥ ♦ ♣ ♠");
        }
    }
}
