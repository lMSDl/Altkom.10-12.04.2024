﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.SOLID.L
{
    //złamanie LSP
    public abstract class Shape
    {
        public abstract int Area { get; }
    }

    public class Square : Rectangle
    {
        public override int A { set => base.A = base.B = value; }
        public override int B { set => base.B = base.A = value; }
    }

    public class Rectangle : Shape
    {
        public virtual int A { get; set; }
        public virtual int B { get; set; }

        public override int Area => A * B;
    }
}
