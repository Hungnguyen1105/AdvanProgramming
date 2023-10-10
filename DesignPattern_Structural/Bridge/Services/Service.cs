using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C01AP.AdvanProgramming.DesignPattern_Structural.Bridge.Services;

namespace C01AP.AdvanProgramming.DesignPattern_Structural.Bridge.Services
{
    public abstract class Service
    {
        public double Duration {  get; set; }

    }
    public class Haircut : Service { }
    public class VitalCare : Service { }
    
}
