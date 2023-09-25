using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01AP.C03Lab_Interface
{
    public interface IMovable
    {
        // Điều Khoản 
         void MoveUp ();
        void MoveDown ();
        void MoveLeft ();
        void MoveRight ();
    }
}
