using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.Assignment2.Factory
{
    class MultifunctionFactory : IAbstractFactory
    {
        public IAbstractFactory createCopy()
        {
            return new MultifunctionFactory();
        }

        public IAbstractFactory createPrint() 
        {
            return new MultifunctionFactory();

        }
        

    }
}
