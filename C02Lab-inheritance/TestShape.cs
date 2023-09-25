using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C02Lab_inheritance
{
    public class TestShape
    {
         public static void Main(string[] args)
        {
            Shape s1 = new Shape();
            Console.WriteLine(s1.ToString());
            Console.WriteLine("**************************");

            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle(5,6);
            Console.WriteLine( r1.GetArea());
            Console.WriteLine(r1.GetPerimeter());
            Console.WriteLine(r2.GetArea());
            Console.WriteLine(r2.GetPerimeter());

            Console.WriteLine("**************************");

            Square s = new Square(2);
            Console.WriteLine(s.GetArea());
            Console.WriteLine(s.GetPerimeter());

            Console.WriteLine("**************************");

            Circle c1 = new Circle();
            Console.WriteLine(c1);
            Console.WriteLine("Area is " + c1.GetArea());
            Console.WriteLine("Perimeter is " + c1.GetPerimeter());
            Console.WriteLine();












        }
    }
}
