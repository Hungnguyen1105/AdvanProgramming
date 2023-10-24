using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.Assignment2
{
    //public class MultifunctionCopy : AbstractCopy
    //{
    //    private string color;
    //    int papertray;
    //    int scanningslot;

    //    public string Color
    //    {
    //        get => color;
    //        set
    //        {
    //            this.color = value;
    //        }


    //    }
    //    public int Papertray
    //    {
    //        get => papertray;
    //        set
    //        {
    //            this.papertray = value;
    //        }
    //    }
    //    public int Scanningslot
    //    {
    //        get => scanningslot;
    //        set
    //        {
    //            this.scanningslot = value;
    //        }
    //    }
    //    public MultifunctionCopy(string color, int papertray, int scanningslot) 
    //    {
    //        this.color=color;
    //        this.papertray=papertray;
    //        this.scanningslot=scanningslot;
    //    }

    //    public MultifunctionCopy()
    //    {
    //    }

    //    public override void Scan() { }
    //    public override void Fax() { }
    //    public override void Copy() { }
    //    public override void ShowInfo(){}




    //}

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
        public MultifunctionCopy(string color, int papertray, int scanningslot)
        {
            this.color = color;
            this.papertray = papertray;
            this.scanningslot = scanningslot;
        }

        public MultifunctionCopy()
        {
        }

        public override void Scan() { }
        public override void Fax() { }
        public override void Copy() { }
        public override void ShowInfo() { }




    }
}
