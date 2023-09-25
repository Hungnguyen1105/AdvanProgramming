using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C03_Lab_AbstractandInterface
{
    public class Cat: Animal,IPet
    {
        public string Name { get; set; }
      
        public Cat(string name, int legs) : base(legs)
        {
            Name = name;
        }
        public void Play()
        {
            Console.WriteLine("Play with you");
        }
        public override void Eat()
        {
            Console.WriteLine("Vap deu");
        }
    }
}
