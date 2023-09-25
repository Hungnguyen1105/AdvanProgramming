using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C02Lab_polymorphism
{
    public class Rectangle : Shape
    {
        private int _length;
        private int _width;

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public Rectangle() : base()
        {
            this.Length = 0;
            this.Width = 0;
        }

        public Rectangle(string color, int length, int width) : base(color)
        {
            this.Length = length;
            this.Width = width;
        }

        public override double GetArea()
        {
            return Length * Width;
        }

        public override string ToString()
        {
            return "Rectangle [Length = " + Length + ", Width = " + Width + ", " + base.ToString() + "]";
        }
    }
}
