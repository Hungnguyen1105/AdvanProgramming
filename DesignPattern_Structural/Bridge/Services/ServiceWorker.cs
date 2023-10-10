using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C01AP.AdvanProgramming.DesignPattern_Structural.Bridge.Services
{
    public interface IServiceWorker
    {
        double TimeTaken(Service service);
        //ở đây dùng interface là hợp  dồng làm việc 
        // nếu có 1 sẻvice làm bao nhiêu thời gian 
    }
    public class JuniorWorker : IServiceWorker
    {
        public double TimeTaken(Service service)
        {
            return service.Duration + 0.75;
        }
        
    }
    public class SeniorWorker : IServiceWorker
    {
        public double TimeTaken(Service service)
        {
            return service.Duration - 0.5;
        }
    }
}
