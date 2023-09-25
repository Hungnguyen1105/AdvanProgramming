using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C04_Lab02
{
    public class MovablePoint: IMovable
    {
        int x; 
        int y;
        int xSpeed;
        int ySpeed;

        public MovablePoint(int x ,int y , int xSpeed, int ySpeed) 
        {
            this.x = x;
            this.y = y;
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }
        public override string ToString()
        {
            return "x: " + x  + "y: " + y + "xSpeed: " + xSpeed + "ySpeed: " + ySpeed;
        }
        public void moveUp()
        {
            Console.WriteLine("x" + x);
        }
        public void moveDown()
        {
            Console.WriteLine("y" + y);
        }
        public void moveLeft()
        {
            Console.WriteLine("xSpeed" + xSpeed);
        }
        public void moveRight()
        {
            Console.WriteLine("ySpeed" + ySpeed);
        }

    }
}
