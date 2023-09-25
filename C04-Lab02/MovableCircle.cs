using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C04_Lab02
{
    public class MovableCircle : IMovable
    {
        private int radius;
        private MovablePoint center;

        public MovableCircle(int x, int y, int xSpeed, int ySpeed, int radius)
        {
            center = new MovablePoint(x, y, xSpeed, ySpeed);
            this.radius = radius;

        }
        public override string ToString()
        {
            return "MovablePoints: center=" + center;
        }
        public void moveUp()
        {
            center.moveUp();
        }
        public void moveDown()
        {
            center.moveDown();
        }
        public void moveLeft()
        {
            center.moveLeft();
        }
        public void moveRight()
        {
            center.moveRight();
        }
    }
}
