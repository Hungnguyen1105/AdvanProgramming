using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C04
{
    public class Temperature
    {
        public double ftemp {  get; set; }

        public Temperature(double fahrenheit) 
        {
            ftemp = fahrenheit;

        }
        public void SetFahrenheit(double fahrenheit)
        {
            ftemp = fahrenheit;
        }                
        public double getFahrenheit()
        {
            return ftemp;
        }
        public double getKelvin()
        {
            return ftemp;
        }
        public double GetCelsius()
        {
            return 5.0 / 9.0 * (ftemp - 32);
        }
        public double GetKelvin()
        {
            return (5.0/9.0  * (ftemp - 32)) + 273;
        }       
    }
}
