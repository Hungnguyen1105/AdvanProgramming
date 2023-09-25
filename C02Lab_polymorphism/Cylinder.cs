using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C02Lab_polymorphism
{
    public class Cylinder : Circle1
    {
        private double _height;

        public double Height
        {
            get { return _height; }
            private set { _height = value; }
        }

        public Cylinder() : base()
        {
            this.Height = 0;
        }

        public Cylinder(double radius, double height) : base(radius)
        {
            this.Height = height;
        }

        public override double GetArea()
        {
            return (2 * Math.PI * Radius * Height) + (2 * base.GetArea());
        }

        public double GetVolume()
        {
            return base.GetArea() * Height;
        }

        public override string ToString()
        {
            return "Cylinder [Height = " + Height + ", " + base.ToString() + "]";
        }
    }
}
