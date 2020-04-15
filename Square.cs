using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1504
{
    public class Square:Figure

    {
        public Square(double height, double width) : base(height, width)
        {

        }

        public override double Width
        {
            get { return Height; }
            set { }
        }
    }
}
