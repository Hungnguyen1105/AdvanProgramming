using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C02Lab_inheritance
{
    public class Rectangle: Shape
    {
        public virtual double Width { get; set; } = 1.0;
        public virtual double Length { get; set; } = 1.0;

        public Rectangle()
        {
        }

        public  Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public  Rectangle(double width, double length, string color, bool filled)
            : base(color, filled)
        {
            Width = width;
            Length = length;
        }

        public virtual double GetArea()
        {
            return Width * Length;
        }

        public virtual double GetPerimeter()
        {
            return  (Width + Length) *2 ;
        }

        public override string ToString()
        {
            return "Rectangle[Area = " + GetArea() + ", Perimeter = " + GetPerimeter() + ", " + base.ToString() + "]";
        }
    }
}
