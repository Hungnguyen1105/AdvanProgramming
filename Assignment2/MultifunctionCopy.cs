using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.Assignment2
{
    public class MultifunctionCopy : AbstractCopy
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

        public override void ShowInfo(){}

        public void Fax(string color) { }
        public void Copy(string color) { }
        public void CopyMultiSided(string color) { }
        
        public override void Fax()
        {
            throw new NotImplementedException();
        }

        public override void Copy()
        {
            throw new NotImplementedException();
        }

        public override void Scan()
        {
            throw new NotImplementedException();
        }
    }
}
