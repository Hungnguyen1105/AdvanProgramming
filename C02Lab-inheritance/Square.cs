using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C02Lab_inheritance
{
    public class Square : Rectangle
    {
        public double side;

        public double Side { get => side; set => side = value; }

        public Square(double side)
        {
            Side = side;
        }
        public override double Width
        {
            get => base.Width;
            set
            {
                base.Width = value;
                base.Length = value; // Ghi đè giá trị của Length cùng với Width để đảm bảo chúng luôn giống nhau trong hình vuông.
            }
        }
        public override double Length
        {
            get => base.Length;
            set
            {
                base.Length = value;
                base.Width = value; // Ghi đè giá trị của Width cùng với Length để đảm bảo chúng luôn giống nhau trong hình vuông.
            }
        }
        public override string ToString()
        {
            return "Square[Side = " + Side + ", Width = " + Width + ", Length = " + Length + ", " + base.ToString() + "]";
        }

    }
}
