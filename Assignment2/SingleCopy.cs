using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.AdvanProgramming.Assignment2
{
    internal class SingleCopy : AbstractCopy
    {
        private string color;
        private string model;
        public string Color
        {
            get => color; set => this.color = value;
        }
        public string Model
        {
            get => model; set => this.model = value;
        }
        public SingleCopy(string color, string model)
        {
            this.color = color;
            this.model = model;
        }

        public SingleCopy()
        {
        }

        public override void ShowInfo()
        {
        }
        public void CopyDocument(string color) { }

        public void CopyPicture(string color) { }

        public override void Copy()
        {
            throw new NotImplementedException();
        }
        public override void Fax()
        {
            throw new NotImplementedException();
        }
        public override void Scan()
        {
            throw new NotImplementedException();
        }

    }
}
