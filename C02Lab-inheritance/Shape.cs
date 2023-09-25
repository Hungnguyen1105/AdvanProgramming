using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C02Lab_inheritance
{
    public class Shape
    {
        public string Color { get; set; } = "red";
        public bool Filled { get; set; } = true;

        public Shape()
        {
        }

        public Shape(string color, bool filled)
        {
            Color = color;
            Filled = filled;
        }

        public override string ToString()
        {
            return "Shape[color = {Color}, filled = {Filled}]";
        }


    }
}
