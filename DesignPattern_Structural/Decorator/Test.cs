using C01AP.AdvanProgramming.DesignPattern_Structural.Decorator.PizzaSize;
using C01AP.AdvanProgramming.DesignPattern_Structural.Decorator.Topping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.DesignPattern_Structural.Decorator
{
    internal class Test
    {
        public static void Main(string[] args)
        {
            Pizza myPizza = new LargePizza();
            myPizza = new Cheese(myPizza);
            myPizza = new Ham(myPizza);
            myPizza = new Pepper(myPizza);
            myPizza = new Cheese(myPizza);

            Console.WriteLine(myPizza.GetDescription());
            Console.WriteLine("{0:C2}", myPizza.CalculateCost());
            Console.ReadKey();
        }
    }
}
