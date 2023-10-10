using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C01AP.AdvanProgramming.DesignPattern_Structural.Bridge.Services;

namespace C01AP.AdvanProgramming.DesignPattern_Structural.Bridge.Appointment
{
    public class Scheduled : Appointment
    {
        public Scheduled(Service service, IServiceWorker sw) : base (service, sw) { }
        public override DateTime EstimateCompleteTime()
        {
            double duration = ServiceWorker.TimeTaken(Service);
            // thời gian nhân viên hoan thành nhiệm vụ 
            var completeTime = ArrivalTime.AddHours(duration);
            //thời gian đến cộng giờ hoàn thành 

            if(completeTime.TimeOfDay > new TimeSpan(18, 0, 0))
            {
                //sau 6h tối là nghỉ và chuyển đến 8h sáng ngày hôm sau
                ArrivalTime = ArrivalTime.AddDays(1).Date + new TimeSpan(8, 0, 0);

                completeTime = ArrivalTime.AddHours(duration);
            }
            return completeTime;

        }
    }
}
