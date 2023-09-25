using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C02Lab_inheritance
{
    public class Circle : Shape
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public Circle() : base()
        {
            this.Radius = 1.0;
        }

        public Circle(double radius) : base()
        {
            this.Radius = radius;
        }

        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            this.Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return "Circle radius = " + Radius + ",  " + base.ToString();
        }
    }
}
