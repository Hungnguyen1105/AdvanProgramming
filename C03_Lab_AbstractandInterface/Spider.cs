using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C03_Lab_AbstractandInterface
{
    public class Spider: Animal
    {
        public Spider() : base(8) { }
        

        public override void Eat()
        {
            Console.WriteLine("Nhen an di");
        }
    }
}
