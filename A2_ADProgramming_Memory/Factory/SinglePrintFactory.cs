using C01AP.AdvanProgramming.A2_ADProgramming_Memory.Copy;
using C01AP.AdvanProgramming.A2_ADProgramming_Memory.Print;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.A2_ADProgramming_Memory.Factory
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
