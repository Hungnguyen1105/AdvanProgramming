using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C03Lab_Interface
{
    public class TestMovablePoints
    {
        public static void Main(string[] args)
        {
            IMovable p;
            
            MovablePoints p1 = new MovablePoints(0, 0);
            MovablePoints p2 = new MovablePoints(1, 1);
            MovablePoints p3 = new MovablePoints(6, 6);
            p = new MovablePoints(5, 5);
            Console.WriteLine(p);
            p.MoveUp();
            p.MoveRight();
            p.MoveDown();
            p.MoveLeft();

            Console.WriteLine("**********************");

            Console.WriteLine("Initial Position: " + p1);

            p1.MoveUp();
            p1.MoveRight();
            p1.MoveDown();
            p1.MoveLeft();

            Console.WriteLine("**********************");

            p2.MoveUp();
            p2.MoveRight();
            p2.MoveDown();
            p2.MoveLeft();
            Console.WriteLine("**********************");

            p3.MoveUp();
            p3.MoveRight();
            p3.MoveDown();
            p2.MoveLeft();



        }
    }
}
