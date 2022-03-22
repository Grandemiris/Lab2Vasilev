using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Square : Figure
    {
        public double a { get; set; }
        public override double GetArea()
        {
            return a * a;
        }
    }
}
