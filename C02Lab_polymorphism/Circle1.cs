using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C02Lab_polymorphism
{
    public class Circle1
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            private set { _radius = value; }
        }

        public Circle1()
        {
            this.Radius = 0;
        }

        public Circle1(double radius)
        {
            this.Radius = radius;
        }

        public virtual double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle {Radius = " + Radius + "}";
        }
    }
}
