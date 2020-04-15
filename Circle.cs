using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1504
{
    class Circle:Figure

    {
        public const double PI = 3.14;
        public Circle(double height, double width) : base(height, width)
        {
           
        }
        public override double Perimeter()

        {
            return Height*2*PI;
        }

        public override double Width
        {
            get { return Height; }
            set { } 
        }

    }
}
