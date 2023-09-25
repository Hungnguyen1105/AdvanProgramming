using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C03Lab_abtractInterface
{
    public class Triangle : Shape
    {
        private int base1;
        private int height;

        public Triangle(string color,int base1, int height) : base (color)
        {
            this.base1 = base1;
            this.height = height;
        }
        public override double GetArea()
        {
            return base1 * height * 0.5;
        }
        public override string ToString()
        {
            return "Triangle[Area= " + GetArea() + ", "+ base.ToString()+"]";
        }
    }
}
