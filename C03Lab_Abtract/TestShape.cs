using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C03Lab_abtractInterface
{
    public class TestShape
    {
        public static void Main(string[] args)
        {
            Shape triangle = new Triangle("Red", 5, 10);
            Console.WriteLine(triangle.ToString());

            Shape rectangle = new Rectangle("Red", 4, 6);
            Console.WriteLine(rectangle.ToString());
        }
    }
}
