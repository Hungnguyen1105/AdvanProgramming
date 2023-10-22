using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.Assignment2.Factory
{
    class SingleFactory : IAbstractFactory
    {
        public IAbstractFactory createCopy()
        {
            return new SingleFactory();
        }

        public IAbstractFactory createPrint()
        {
            return new SingleFactory();
        }
    }
}
