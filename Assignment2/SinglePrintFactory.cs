using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.Assignment2
{
    public class SinglePrintFactory : AbstractFactoryPrint
    {
        public AbstractPrint CreatePrint()
        {
            return new SinglePrint();
        }

        public AbstractCopy CreateCopy()
        {
            return new SingleCopy();
        }
    }
}
