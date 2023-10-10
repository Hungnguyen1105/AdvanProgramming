using C01AP.AdvanProgramming.DesignPattern_Structural.Bridge.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C01AP.AdvanProgramming.DesignPattern_Structural.Bridge.Appointment
{
    public abstract class Appointment
    {
        public Service Service { get; set; }
        public IServiceWorker ServiceWorker { get; set; }
        public DateTime ArrivalTime {  get; set; }
        public Appointment(Service service, IServiceWorker sw)
        {
            Service = service;
            ServiceWorker = sw;
        }
        public abstract DateTime EstimateCompleteTime();
    }
}
