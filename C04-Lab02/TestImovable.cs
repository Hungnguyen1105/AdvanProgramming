using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C04_Lab02
{
    internal class TestImovable
    {
       public static void Main(string[] args)
        {
            IMovable m1 = new MovablePoint(5, 6, 10, 15);  // upcast 
            Console.WriteLine(m1);
            m1.moveLeft();
            Console.WriteLine(m1);

            Console.WriteLine("************************************");
            IMovable m2 = new MovableCircle(1, 2, 3, 4, 20); // upcast	 
            Console.WriteLine(m2);
            m2.moveRight();
            Console.WriteLine(m2);

            Console.WriteLine("************************************");

            MovableRectangle rectangle = new MovableRectangle(5, 5, 6, 6, 7, 7);
            rectangle.moveUp();
            rectangle.moveLeft();
            Console.WriteLine(rectangle);
        }
    }
}
