using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.Assignment2.Copy
{
    public abstract class Copies 
    {
        private string color {  get; set; }
        private float capacity { get; set; }
        private string brand { get; set; }

        public abstract void Scan();
        public void Fax()
        {
            Console.WriteLine("Fax" + color);

        }
        public void Copy()
        {
            Console.WriteLine("Copy" + color);
        }
    }
}
