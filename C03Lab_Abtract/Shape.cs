using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C03Lab_abtractInterface
{
    public abstract class Shape
    {
        private string color;

        public Shape(string color)
        {
            this.color = color;
        }

        public abstract double GetArea() ;
        

        public override string ToString()
        {
            return "Shape[color =  " + color +"]" ;
        }


    }
    
}
