using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RISYNOK6
{
    public class cylinder : Figura
    {
        public int y;
        public cylinder(int nX, int nY) : base(nX)
        {
            y = nY;
        }

        public override double S()
        {
            return 1.0 * y * (x * x) * 3.14;
        }
        public override string ToString()
        {
            return "Цилиндр " + S();
        }
    }
    
}
    

