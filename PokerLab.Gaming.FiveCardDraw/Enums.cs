﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerLab.Gaming.FiveCardDraw
{
    internal class Enums
    {
        internal enum HandStrength
        {
            StraightFlush=1,
            FourOfAKind = 2,
            FullHouse = 3,
            Flush = 4,
            Straight = 5,
            ThreeOfAKind = 6,
            TwoPair = 7,
            OnePair = 8,
            HighCards = 9,
            NotFound = 10
        }
    }
}
