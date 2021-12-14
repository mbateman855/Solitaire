﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
    public class Card
    {
        public int Value { get; set; }
        public string Color { get; set; }
        public string Suit { get; set; }

        public Card(int value, string color, string suit)
        {
            Value = value;
            Color = color;
            Suit = suit;
        }
    }
}