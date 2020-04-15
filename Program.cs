using System;

namespace HomeWork1504
{
    public class Figure

    {
        public Figure(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public virtual double Height { get; set; }

        public virtual double Width { get; set; }
                
        public double Area()

        {            
            return Height * Width;
        }
        public virtual double Perimeter()

        {
            return 2*(Height + Width);
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please entered values for rectangles height and width");
            Rectangle rectangle = new Rectangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Please entered values for circles radius");
            Circle circle = new Circle(Convert.ToDouble(Console.ReadLine()), 1);

            Console.WriteLine("Please entered values for squares side");
            Square square = new Square(Convert.ToDouble(Console.ReadLine()), 5);
            

           
            Console.WriteLine("Rectangle area is: " + rectangle.Area());
            Console.WriteLine("Circle area is: " +circle.Area());
            Console.WriteLine("Square area is: " + square.Area());

            Console.WriteLine("Rectangle perimeter is: " + rectangle.Perimeter());
            Console.WriteLine("Circle perimeter is: " + circle.Perimeter());
            Console.WriteLine("Square perimeter is: " + square.Perimeter());
            

        }
    }
   

    
    
   



}
