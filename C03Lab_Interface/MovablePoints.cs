using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C03Lab_Interface
{
    public class MovablePoints : IMovable
    {
        private int x;
        private int y;
        public MovablePoints(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return "MovablePoints (" + x + ", " + y + ")";
        }
        public  void MoveUp()
        {
            y++;
            Console.WriteLine("Move up " + y);
        }
        public void MoveDown()
        {
            y--;
            Console.WriteLine("Move Down" + y);

        }
        public void MoveLeft()
        {
            x--;
            Console.WriteLine("Move Left" + x);

        }
        public void MoveRight()
        {
            x++;
            Console.WriteLine("MoveRight" + x);
        }
    }
}
