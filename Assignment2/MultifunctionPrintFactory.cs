using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.Assignment2
{
    public class MultifunctionPrintFactory : AbstractFactoryPrint
    {
        public AbstractPrint CreatePrint()
        {
            return new Multifunctionprint();
        }

        public AbstractCopy CreateCopy()
        {
            return new MultifunctionCopy();
        }
    }
}
