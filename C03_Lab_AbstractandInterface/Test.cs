using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C03_Lab_AbstractandInterface
{
    public  class Test
    {
        public static void Main(string[] args)
        {
            Animal a = new Fish("dop dop dop dop", 0);
            a.Eat();
            a.Walk();
            Cat c = new Cat("meomeo", 4);
            c.Play();
            c.Eat();
            Fish d = new Fish("fluffy", 0);
            d.Play();
            d.Eat();
            Animal e = new Spider();
            e.Eat();
            IPet p = new Cat("Meo meo tra lai tam tri toi day", 4);
            p.Play();
            


        }
    }
}
