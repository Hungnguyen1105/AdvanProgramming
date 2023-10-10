using C01AP.AdvanProgramming.DesignPattern_Structural.Bridge.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C01AP.AdvanProgramming.DesignPattern_Structural.Bridge.Appointment
{
    public class Emergency : Appointment
    {
        public Emergency(Service service, IServiceWorker sw) : base(service, sw){ }
        
        public override DateTime EstimateCompleteTime()
        {
            double duration = ServiceWorker.TimeTaken(this.Service);
            return ArrivalTime.AddHours(duration);
        }
    }
}
