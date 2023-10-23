using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.Assignment2
{
    public class Multifunctionprint : AbstractPrint
    {
        private string color;
        int papertray;
        int scanningslot;
        public string Color
        {
            get => color;
            set
            {
                this.color = value;
            }
        }
        public int Papertray
        {
            get => papertray;
            set
            {
                this.papertray = value;
            }
        }
        public int Scanningslot
        {
            get => scanningslot;
            set
            {
                this.scanningslot = value;
            }
        }

        public Multifunctionprint() { }
        public Multifunctionprint(string color, int papertray, int scanningslot)
        {
            this.color = color;
            this.papertray = papertray;
            this.scanningslot = scanningslot;
        }

        public override void ShowInfo()
        {

        }
        public void PrintingColor(string color) { }
        public void MultisidedPrint(string color) { }

        public override void SidedPrint()
        {
            throw new NotImplementedException();
        }

        public override void PrintColor()
        {
            throw new NotImplementedException();
        }
    }
}
