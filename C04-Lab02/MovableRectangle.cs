using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C04_Lab02
{
    public class MovableRectangle : IMovable
    {
        private MovablePoint topLeft;
        private MovablePoint bottomRight;

        public MovableRectangle(int x1, int y1, int x2, int y2, int xSpeed, int ySpeed)
        {
            topLeft = new MovablePoint(x1, y1, xSpeed, ySpeed);
            bottomRight = new MovablePoint(x2, y2, xSpeed, ySpeed);
        }
        public override string ToString()
        {
            return "MovableRectangle: TopLeft=" + topLeft + ", BottomRight=" + bottomRight;
        }
        public void moveUp()
        {
            topLeft.moveUp();
            bottomRight.moveUp();
        }
        public void moveDown()
        {
            topLeft.moveDown();
            bottomRight.moveDown();
        }
        public void moveLeft()
        {
            topLeft.moveLeft();
            bottomRight.moveLeft();
        }
        public void moveRight()
        {
            topLeft.moveRight();
            bottomRight.moveRight();    
        }
    }
}
