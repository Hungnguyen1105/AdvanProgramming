using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.Assignment2
{
    internal class SinglePrint : AbstractPrint
    {
        private string color = "black, white";
        private string model;

        public string Model
        {
            get => model;
            set
            {
                this.model = value;
            }
        }
        public SinglePrint()
        {
        }
        public SinglePrint(string color, string model)
        {
            this.color = color;
            this.model = model;
        }


        public override void ShowInfo()
        {

        }
        public override void PrintColor()
        {
            string color = "black, white";
        }
        public override void SidedPrint() { }

    }
}
