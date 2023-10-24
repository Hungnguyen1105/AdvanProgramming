using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.Assignment2
{
    public class SingleCopy : AbstractCopy
    {
        private string color;
        private string model;
        private string capacity;
        public string Color
        {
            get => color; set => this.color = value;
        }
        private string Capacity
        {
            get => capacity; set => this.capacity = value;
        }
        
        public SingleCopy(string color, string model)
        {
            this.color = color;
            this.model = model;
        }

        public SingleCopy() {}

        public override void ShowInfo() {}

        public override void Copy() {}
        public override void Fax() {}
        public override void Scan() {}

    }
}
