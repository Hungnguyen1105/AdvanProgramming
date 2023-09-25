using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C03_Lab_AbstractandInterface
{
    public  class Fish: Animal,IPet

    {

        public string Name {  get; set; }

        public Fish(string name, int legs) :base(legs)
        {
            Console.WriteLine("chep chep");
        }
        public void Play()
        {
            Console.WriteLine("Con Ca vap di ");
        }

        public override void Eat() 
        {
            Console.WriteLine("an di ca");
        }
        public override void Walk()
        {
            Console.WriteLine("Boi di con");
        }
    }
}
