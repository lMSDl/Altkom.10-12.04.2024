﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.Strategy
{
    internal class DivideStrategy : ICalcStrategy
    {
        public float Calc(float a, float b)
        {
            return a / b;
        }
    }
}