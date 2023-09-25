using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C03_Lab_AbstractandInterface
{
    public interface IPet
    {
        string Name { get; set; }

        public void Play();
        
    }
}
