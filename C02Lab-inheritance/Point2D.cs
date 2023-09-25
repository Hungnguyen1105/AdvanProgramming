using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C02Lab_inheritance
{
    public class Point2D
    {
        public int x = 0;
        public int y = 0;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }


        public  Point2D()
        {    
        }
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }


        public override string ToString()
        {
            return "(" +X +", " +Y +")";
        }
    }
}
