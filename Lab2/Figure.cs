using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public abstract class Figure
    {
        public string Name { get; set; }
        public abstract double GetArea();
    }
}
