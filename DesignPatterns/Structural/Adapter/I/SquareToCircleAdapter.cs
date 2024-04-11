using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Structural.Adapter.I
{
    internal class SquareToCircleAdapter : ICircle
    {
        private Square _square;
        public SquareToCircleAdapter(Square square)
        {
            _square = square;
        }

        public double R => _square.A * Math.Sqrt(2) / 2.0;
    }
}
