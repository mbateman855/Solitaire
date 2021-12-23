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
                    if (card.BlankSpace)
                    {
                        Console.Write(" ");
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

        public static void TestLayoutTwo(Card[][] deck)
        {
            int subsetTracker = 0;
            foreach (var subset in deck)
            {
                if (subsetTracker < 20)
                {
                    foreach (var card in subset)
                    {
                        if (card.IsFaceUp)
                        {
                            if (!card.BlankSpace)
                            {
                                ValueSuitDisplay(card);
                            }
                            else
                            {
                                Console.Write("    ");
                            }
                        }
                        else
                        {
                            Console.Write("....");
                        }
                    }
                    Console.WriteLine();
                }
                subsetTracker++;
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
        public static void ValueSuitDisplay(Card card)
        {
            //string convertedSuit;
            string convertedValue;

            if (card.Value == 1)
            {
                convertedValue = " A";
            }
            else if (card.Value == 10)
            {
                //this is the only card that would display two characters instead of one
                //all of the other values would get a space before the value but 10 will not, this keeps the column formatting consistent
                convertedValue = "10";
            }
            else if (card.Value == 11)
            {
                convertedValue = " J";
            }
            else if (card.Value == 12)
            {
                convertedValue = " Q";
            }
            else if (card.Value == 13)
            {
                convertedValue = " K";
            }
            else
            {
                convertedValue = $" {card.Value}";
            }

            if (card.Suit == "spade")
            {
                Console.Write($"{convertedValue}♠ ");
            };
            if (card.Suit == "club")
            {
                Console.Write($"{convertedValue}♣ ");
            };
            if (card.Suit == "heart")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{convertedValue}♥ ");
                Console.ForegroundColor = ConsoleColor.White;
            };
            if (card.Suit == "diamond")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{convertedValue}♦ ");
                Console.ForegroundColor = ConsoleColor.White;
            };
        }

        public static void WinScreen()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congratulations! You've won!");
        }
    }
}
