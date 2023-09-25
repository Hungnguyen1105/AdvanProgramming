using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C03Lab_abtractInterface
{
    public  class Rectangle : Shape
    {
        private int length;
        private int width;

        public Rectangle(string color, int length, int width) : base(color)
        {
            this.length = length;
            this.width = width;
        }
        public override double GetArea()
        {
            return length * width;
        }
        public override string ToString()
        {
            return "Rectangle[Area= " + GetArea() + ", " + base.ToString() + "]";
        }



    }
}
