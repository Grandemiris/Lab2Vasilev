using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Parallelogram : Figure
    {
        public double a { get; set; }
        public double b { get; set; }
        public double h { get; set; }
        public override double GetArea()
        {
            return a * h;
        }
    }
}
