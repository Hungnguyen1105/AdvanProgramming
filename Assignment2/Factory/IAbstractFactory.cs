﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.Assignment2.Factory
{
    internal interface IAbstractFactory
    {
        IAbstractFactory createPrint();
        IAbstractFactory createCopy();
    }
}