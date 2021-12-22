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
            //Deal(cards);
            var allocatedCards = AllocateCards(cards);
            TestAllocatedCards(allocatedCards);
        }
        public static void TestDeck(List<Card> cards)
        {
            foreach (var card in cards)
            {
                Console.Write($" | {card.Value}, {card.Color}, {card.Suit}");
            };
        }

        public static void TestAllocatedCards(Card[][] allocatedDeck)
        {
            foreach (var subset in allocatedDeck)
            {
                //Console.WriteLine(subset);
                foreach (var card in subset)
                {
                    if (!card.BlankSpace && card != null)
                    {
                        Console.WriteLine($"{card.Value} {card.Suit}");
                    }
                    //Console.WriteLine(card.BlankSpace);
                }
            }

        }

        public static Card[][] AllocateCards(List<Card> deck)
        {
            //creating 20 rows of seven cards to display
            Card[] rowOne = new Card[7];
            Card[] rowTwo = new Card[7];
            Card[] rowThree = new Card[7];
            Card[] rowFour = new Card[7];
            Card[] rowFive = new Card[7];
            Card[] rowSix = new Card[7];
            Card[] rowSeven = new Card[7];
            Card[] rowEight = new Card[7];
            Card[] rowNine = new Card[7];
            Card[] rowTen = new Card[7];
            Card[] rowEleven = new Card[7];
            Card[] rowTwelve = new Card[7];
            Card[] rowThirteen = new Card[7];
            Card[] rowFourteen = new Card[7];
            Card[] rowFifteen = new Card[7];
            Card[] rowSixteen = new Card[7];
            Card[] rowSeventeen = new Card[7];
            Card[] rowEighteen = new Card[7];
            Card[] rowNineteen = new Card[7];
            Card[] rowTwenty = new Card[7];

            //creating other sections that have cards
            Card[] suitStackOne = new Card[13];
            Card[] suitStackTwo = new Card[13];
            Card[] suitStackThree = new Card[13];
            Card[] suitStackFour = new Card[13];
            Card[] stockPile = new Card[24];
            Card[] drawnStockPile = new Card[24];

            Card[][] allocatedDeck = new Card[26][];

            //putting cards into the arrays
            rowOne[0] = deck[0];
            for (int i = 1; i < rowOne.Length; i++)
            {
                //the Card constructor just has a bool for whether it is blank or not
                //true in this context means it is indeed a blank space
                rowOne[i] = new Card(true);
            }

            rowTwo[0] = deck[1];
            rowTwo[1] = deck[2];

            for (int i = 2; i < rowTwo.Length; i++)
            {
                rowTwo[i] = new Card(true);
            }

            rowThree[0] = deck[3];
            rowThree[1] = deck[4];
            rowThree[2] = deck[5];

            for (int i = 3; i < rowTwo.Length; i++)
            {
                rowThree[i] = new Card(true);
            }

            rowFour[0] = deck[6];
            rowFour[1] = deck[7];
            rowFour[2] = deck[8];
            rowFour[3] = deck[9];

            for (int i = 4; i < rowTwo.Length; i++)
            {
                rowFour[i] = new Card(true);
            }

            rowFive[0] = deck[10];
            rowFive[1] = deck[11];
            rowFive[2] = deck[12];
            rowFive[3] = deck[13];
            rowFive[4] = deck[14];

            for (int i = 5; i < rowTwo.Length; i++)
            {
                rowFive[i] = new Card(true);
            }

            rowSix[0] = deck[15];
            rowSix[1] = deck[16];
            rowSix[2] = deck[17];
            rowSix[3] = deck[18];
            rowSix[4] = deck[19];
            rowSix[5] = deck[20];

            for (int i = 6; i < rowTwo.Length; i++)
            {
                rowSix[i] = new Card(true);
            }

            rowSeven[0] = deck[21];
            rowSeven[1] = deck[22];
            rowSeven[2] = deck[23];
            rowSeven[3] = deck[24];
            rowSeven[4] = deck[25];
            rowSeven[5] = deck[26];
            rowSeven[6] = deck[27];

            for (int i = 0; i < rowEight.Length; i++)
            {
                rowEight[i] = new Card(true);
            }

            for (int i = 0; i < rowNine.Length; i++)
            {
                rowNine[i] = new Card(true);
            }

            for (int i = 0; i < rowTen.Length; i++)
            {
                rowTen[i] = new Card(true);
            }

            for (int i = 0; i < rowEleven.Length; i++)
            {
                rowEleven[i] = new Card(true);
            }

            for (int i = 0; i < rowTwelve.Length; i++)
            {
                rowTwelve[i] = new Card(true);
            }

            for (int i = 0; i < rowThirteen.Length; i++)
            {
                rowThirteen[i] = new Card(true);
            }

            for (int i = 0; i < rowFourteen.Length; i++)
            {
                rowFourteen[i] = new Card(true);
            }

            for (int i = 0; i < rowFifteen.Length; i++)
            {
                rowFifteen[i] = new Card(true);
            }

            for (int i = 0; i < rowSixteen.Length; i++)
            {
                rowSixteen[i] = new Card(true);
            }

            for (int i = 0; i < rowSeventeen.Length; i++)
            {
                rowSeventeen[i] = new Card(true);
            }

            for (int i = 0; i < rowEighteen.Length; i++)
            {
                rowEighteen[i] = new Card(true);
            }

            for (int i = 0; i < rowNineteen.Length; i++)
            {
                rowNineteen[i] = new Card(true);
            }

            for (int i = 0; i < rowTwenty.Length; i++)
            {
                rowTwenty[i] = new Card(true);
            }

            for (int i = 0; i < stockPile.Length; i++)
            {
                stockPile[i] = deck[28 + i];
            }

            for (int i = 0; i < drawnStockPile.Length; i++)
            {
                drawnStockPile[i] = new Card(true);
            }

            for (int i = 0; i < suitStackOne.Length; i++)
            {
                suitStackOne[i] = new Card(true);
            }

            for (int i = 0; i < suitStackTwo.Length; i++)
            {
                suitStackTwo[i] = new Card(true);
            }

            for (int i = 0; i < suitStackThree.Length; i++)
            {
                suitStackThree[i] = new Card(true);
            }

            for (int i = 0; i < suitStackFour.Length; i++)
            {
                suitStackFour[i] = new Card(true);
            }

            allocatedDeck[0] = rowOne;
            allocatedDeck[1] = rowTwo;
            allocatedDeck[2] = rowThree;
            allocatedDeck[3] = rowFour;
            allocatedDeck[4] = rowFive;
            allocatedDeck[5] = rowSix;
            allocatedDeck[6] = rowSeven;
            allocatedDeck[7] = rowEight;
            allocatedDeck[8] = rowNine;
            allocatedDeck[9] = rowTen;
            allocatedDeck[10] = rowEleven;
            allocatedDeck[11] = rowTwelve;
            allocatedDeck[12] = rowThirteen;
            allocatedDeck[13] = rowFourteen;
            allocatedDeck[14] = rowFifteen;
            allocatedDeck[15] = rowSixteen;
            allocatedDeck[16] = rowSeventeen;
            allocatedDeck[17] = rowEighteen;
            allocatedDeck[18] = rowNineteen;
            allocatedDeck[19] = rowTwenty;
            allocatedDeck[20] = suitStackOne;
            allocatedDeck[21] = suitStackTwo;
            allocatedDeck[22] = suitStackThree;
            allocatedDeck[23] = suitStackFour;
            allocatedDeck[24] = stockPile;
            allocatedDeck[25] = drawnStockPile;

            return allocatedDeck;
        }


        //public static void Deal(List<Card> deck)
        //{
        //    List<Card> columnOne = new List<Card>
        //    {
        //        deck[0]
        //    };
        //    deck[0].IsFaceUp = true;
        //    List<Card> columnTwo = new List<Card>
        //    {
        //        deck[1],
        //        deck[2]
        //    };
        //    deck[2].IsFaceUp = true;
        //    List<Card> columnThree = new List<Card>
        //    {
        //        deck[3],
        //        deck[4],
        //        deck[5]
        //    };
        //    deck[5].IsFaceUp = true;
        //    List<Card> columnFour = new List<Card>
        //    {
        //        deck[6],
        //        deck[7],
        //        deck[8],
        //        deck[9]
        //    };
        //    deck[9].IsFaceUp = true;
        //    List<Card> columnFive = new List<Card>
        //    {
        //        deck[10],
        //        deck[11],
        //        deck[12],
        //        deck[13],
        //        deck[14]
        //    };
        //    deck[14].IsFaceUp = true;
        //    List<Card> columnSix = new List<Card>
        //    {
        //        deck[15],
        //        deck[16],
        //        deck[17],
        //        deck[18],
        //        deck[19],
        //        deck[20]
        //    };
        //    deck[20].IsFaceUp = true;
        //    List<Card> columnSeven = new List<Card>
        //    {
        //        deck[21],
        //        deck[22],
        //        deck[23],
        //        deck[24],
        //        deck[25],
        //        deck[26],
        //        deck[27]
        //    };
        //    deck[27].IsFaceUp = true;
        //    List<Card> stockPile = new List<Card>();
        //    for (int i = 28; i < 52; i++)
        //    {
        //        stockPile.Add(deck[i]);
        //    }
        //    List<Card> drawnStockCards = new List<Card>();
        //    List<Card> suitStackOne = new List<Card>();
        //    List<Card> suitStackTwo = new List<Card>();
        //    List<Card> suitStackThree = new List<Card>();
        //    List<Card> suitStackFour = new List<Card>();
        //    List<List<Card>> allCardLists = new List<List<Card>>
        //    {
        //        columnOne,
        //        columnTwo,
        //        columnThree,
        //        columnFour,
        //        columnFive,
        //        columnSix,
        //        columnSeven,
        //        stockPile,
        //        drawnStockCards,
        //        suitStackOne,
        //        suitStackTwo,
        //        suitStackThree,
        //        suitStackFour
        //    };

        //    //foreach (var card in deck)
        //    //{
        //    //    int i = 0;

        //    //    while(i < deck.Count)
        //    //    {
        //    //        if ()
        //    //    }
        //    //};

        //    //columnOne.Add(deck[0]);
        //    //deck[0].IsFaceUp = true;
        //    //columnTwo.Add(deck[1]);
        //    //columnTwo
        //    //columnThree,
        //    //columnFour,
        //    //columnFive,
        //    //columnSix,
        //    //columnSeven,
        //    //stockPile,
        //    //drawnStockCards,
        //    //suitStackOne,
        //    //suitStackTwo,
        //    //suitStackThree,
        //    //suitStackFour

        //    //Display.DisplayDeal(allCardLists);
        //    //Display.TestLayout(allCardArrays);
        //    Display.TestLayout(CardListToArrays(allCardLists));
        //}

        //public static List<Card[]> CardListToArrays(List<List<Card>> deck)
        //{
        //    Card[] columnOne = new Card[30];
        //    Card[] columnTwo = new Card[30];
        //    Card[] columnThree = new Card[30];
        //    Card[] columnFour = new Card[30];
        //    Card[] columnFive = new Card[30];
        //    Card[] columnSix = new Card[30];
        //    Card[] columnSeven = new Card[30];
        //    Card[] stockPile = new Card[24];
        //    Card[] drawnStockCards = new Card[24];
        //    Card[] suitStackOne = new Card[13];
        //    Card[] suitStackTwo = new Card[13];
        //    Card[] suitStackThree = new Card[13];
        //    Card[] suitStackFour = new Card[13];

        //    List<Card[]> arrayDeck = new List<Card[]>
        //    {
        //        columnOne,
        //        columnTwo,
        //        columnThree,
        //        columnFour,
        //        columnFive,
        //        columnSix,
        //        columnSeven,
        //        stockPile,
        //        drawnStockCards,
        //        suitStackOne,
        //        suitStackTwo,
        //        suitStackThree,
        //        suitStackFour
        //    };

        //    foreach (var array in arrayDeck)
        //    {
        //        int indexTracker = 0;
        //        for (int i = 0; i < deck[i].Count; i++)
        //        {
        //            foreach (var card in deck[i])
        //            {
        //                array[i] = card;
        //            }
        //            indexTracker++;
        //        }
                
        //        for (int j = indexTracker; j < array.Length; j++)
        //        {
        //            array[j] = new Card(" . ");
        //        }
        //    }

        //    //foreach (var array in arrayDeck)
        //    //{
        //    //    foreach (var cardSlot in array)
        //    //    {
        //    //        int i = 0;
        //    //        foreach (var card in deck[0])
        //    //        {
        //    //            array[i] = card;
        //    //            i++;
        //    //        }

        //    //        for (int j = i; j < array.Length; j++)
        //    //        {
        //    //            array[i] = new Card(" . ");
        //    //        }
        //    //    }
        //    //}

        //    //foreach (var cardSlot in columnOne)
        //    //{
        //    //    int i = 0;
        //    //    foreach (var card in deck[0])
        //    //    {
        //    //        columnOne[i] = card;
        //    //        i++;
        //    //    }

        //    //    for (int j = 1; j < 30; j++)
        //    //    {
        //    //        columnOne[i] = new Card(" . ");
        //    //    }
        //    //}

        //    return arrayDeck;
        //}
    }
}
