﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.DesignPattern_Structural.Decorator
{
    public abstract class Pizza
    {
        public string Description {  get; set; }
        public abstract string GetDescription();
        public abstract double CalculateCost();
    }
}
