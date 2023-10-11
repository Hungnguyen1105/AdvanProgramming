using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.DesignPattern_Structural.Decorator.PizzaSize
{
    public class MediumPizza : Pizza
    {
        public MediumPizza() 
        {
            Description = "Meidum Pizza";
        }
        public override string GetDescription()
        {
            return Description;
        }
        public override double CalculateCost()
        {
            return 6.00;
        }
    }
}
