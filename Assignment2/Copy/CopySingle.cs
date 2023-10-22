using C01AP.AdvanProgramming.Assignment2.Copy;
using C01AP.AdvanProgramming.Assignment2.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.Assignment2.Copy
{
    public class CopySingle : Copies
    {
        public override string Capacity
        {
            get { return base.Capacity; }
            set { base.Capacity = value; }
        }
        public override string Color
        {
            get { return base.Color}
            set { base.Color = value; }
        }
        private string Model;

        public override void Scan()
        {
            Console.WriteLine("Scan" + Color);
        }
            
   
    }
}
