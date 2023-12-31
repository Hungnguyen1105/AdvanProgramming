﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.DesignPattern_Structural.Decorator.PizzaSize
{
    public class SmallPizza : Pizza
    {
        public SmallPizza() 
        {
            Description = "Small Pizza";
        }
        public override string GetDescription()
        {
            return Description;
        }
        public override double CalculateCost()
        {
            return 3.00;
        }
    }
}
