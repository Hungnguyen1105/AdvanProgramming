using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.C01.Lab01
{
    class Circle1
    {
        private double radius = 1.0;

        public Circle1()
        {
            // mặc định đề bài cho bk là 1
        }
        public Circle1(double radius)
        {
            this.radius = radius;
        }// ham khoi tao ban kinh duoc chi dinh
        public double Radius
        {
            get { return radius; }// tra ve gia tri hien tai cua bk
            set { radius = value; }// cho phep dat gia tri moi ben ngoai lop circle
        }
        public double Area()
        {
            double PI = Math.PI;
            return PI * Math.Pow(radius, 2);
        }
        public double Circumference()
        {
            double PI = Math.PI;
            return 2 * PI * Radius;
        }
        public override string ToString()
        {
            return "Circle[Radius= {Radius}]";
            //String interpo
        }



    }

}
