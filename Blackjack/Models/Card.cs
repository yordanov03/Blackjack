﻿using Blackjack.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackjack.Models
{
    public class Card
    {
        public bool IsVisible { get; set; } = true;
        public string ImageName { get; set; }
        public CardSuit Suit { get; set; }
        public CardValue Value { get; set; }

        public int Score
        {
            get
            {
                if(Value == CardValue.King || Value == CardValue.Queen || Value == CardValue.Jack)
                {
                    return 10;
                }
                if(Value == CardValue.Ace)
                {
                    return 11;
                }
                else
                {
                    return (int)Value;
                }
            }
        }

        public bool IsTenCard
        {
            get
            {
                return Value == CardValue.Ten
                       || Value == CardValue.Jack
                       || Value == CardValue.Queen
                       || Value == CardValue.King;
            }
        }
    }
}
