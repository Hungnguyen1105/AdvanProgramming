using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C03_Lab_AbstractandInterface
{
    public abstract class Animal
    {
        public int Legs { get; private set; }
        protected Animal(int Legs) 
            //constructor con su dung conf lớp ngoài k sử dụng được 
        { 
            this.Legs = Legs;
        }
        public virtual void Walk()
        {

        }
        public abstract void Eat();

       
    }
}
