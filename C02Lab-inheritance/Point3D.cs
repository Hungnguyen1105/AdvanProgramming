using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C02Lab_inheritance
{
   
    
    public class Point3D : Point2D
    {
        public int z = 0;
        public int Z { get => z; set => z = value; }

        public Point3D()
        {
        }
        public Point3D(int X, int Y, int z): base(X,Y)
        {
            this.X = X;
            this.Y = Y;
            this.Z = z;

        }

        public override string ToString()
        {
            return "(" + X + ", " + Y + " , " + Z + ")";
        }
    }
}
