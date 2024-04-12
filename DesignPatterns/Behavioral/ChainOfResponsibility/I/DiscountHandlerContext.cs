﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    internal class DiscountHandlerContext
    {
        public float Price { get; }
        public float Value { get; } 
        public bool Result { get; set; }

        public DiscountHandlerContext(float price, float value)
        {
            Price = price;
            Value = value;
        }
    }
}