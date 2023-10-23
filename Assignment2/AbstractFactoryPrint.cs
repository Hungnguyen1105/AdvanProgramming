using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.Assignment2
{
    public interface AbstractFactoryPrint
    {
        public AbstractPrint CreatePrint();

        public AbstractCopy CreateCopy(); 
    }
}
