﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Structural.Bridge.I
{
    internal abstract class Color
    {
        public Brightness Brightness { get; set; }

        public override string ToString()
        {
            return (Brightness?.ToString() ?? "") + GetType().Name;
        }
    }
}