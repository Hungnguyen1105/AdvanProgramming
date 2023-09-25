using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C02Lab_polymorphism
{
    public class TestShape1
    {

        public static void Main(String[] args)
        {

            Shape s1 = new Rectangle("red", 4, 5); // Upcast

            Console.WriteLine(s1); // Run Rectangle's toString()

            Console.WriteLine("Area is " + s1.GetArea()); // Run Rectangle's getArea()

            Shape s2 = new Triangle("blue", 4, 5); // Upcast

            Console.WriteLine(s2); // Run Triangle's toString()

            Console.WriteLine("Area is " + s2.GetArea()); // Run Triangle's getArea()
            Console.WriteLine("*******************");

            Circle1 c1 = new Circle1(1.1);
            Console.WriteLine(c1);
            Console.WriteLine("Area is " + c1.GetArea());

            Console.WriteLine();

            Cylinder c2 = new Cylinder(2.2, 3.3);
            Console.WriteLine(c2);
            Console.WriteLine("Area is " + c2.GetArea());
            Console.WriteLine("Volume is " + c2.GetVolume());

            Console.WriteLine();

        }

    }
}
