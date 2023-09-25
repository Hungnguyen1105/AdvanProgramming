using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C02Lab_polymorphism
{
    public class Shape
    {
        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public Shape()
        {
            this.Color = "Unknow";
        }

        public Shape(string color)
        {
            this.Color = color;
        }

        public virtual double GetArea()
        {
            return 0;
        }

        public override string ToString()
        {
            return "Shape {Color = " + Color + "}";
        }
    }
}
