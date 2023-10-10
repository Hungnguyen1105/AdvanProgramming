using C01AP.AdvanProgramming.DesignPattern_Structural.Bridge.Appointment;
using C01AP.AdvanProgramming.DesignPattern_Structural.Bridge.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.DesignPattern_Structural.Bridge
{
    internal class TestBridge
    {
        public static void Main(string[] args)
        {
            var svc = new Haircut();
            var svc1 = new VitalCare();
            svc.Duration = 2;
            svc1.Duration = 3;

            var worker = new JuniorWorker();
            var worker1 = new JuniorWorker();
            var sappt = new Scheduled(svc, worker);
            var sappt1 = new Scheduled(svc1, worker);
            sappt.ArrivalTime = DateTime.Today + new TimeSpan(15, 0, 0);
            sappt1.ArrivalTime = DateTime.Today

            //+ new TimeSpan (15 0 0);
            + new TimeSpan(17, 0, 0);
            Console.WriteLine("Schedule: Estimated CompleteTime Haircut Junior:" + sappt.EstimateCompleteTime().ToString());
            Console.WriteLine("Schedule: Estimated CompleteTime Vitalcare Junior:" + sappt1.EstimateCompleteTime().ToString());


            var sworker = new SeniorWorker();
            var smoker1 = new SeniorWorker();
            var eappt = new Emergency(svc , sworker);
            var eappt1 = new Emergency(svc , smoker1);
            eappt.ArrivalTime = DateTime.Today + new TimeSpan(17, 0, 0);
            Console.WriteLine("Emagency: Estimated CompleteTime Haircut SeniorWorker: " + eappt.EstimateCompleteTime().ToString());
            Console.WriteLine("Emagency: Estimated CompleteTime Vitalcare SeniorWorker: " + eappt1.EstimateCompleteTime().ToString());


        }
    }
}
