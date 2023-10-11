using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.DesignPattern_Structural.Decorator.PizzaSize
{
    public class LargePizza : Pizza
    {
        public LargePizza()
        {
            Description = "Large Pizza";
        }
        public override string GetDescription()
        {
            return Description;
        }
        public override double CalculateCost()
        {
            return 9.00;
        }

    }
    
}
