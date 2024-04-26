using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RISYNOK6
{
    public class cube : Figura
    {
        public cube(int nX) : base(nX)
        {

        }
        public override double S()
        {
            return x * x * x;
        }
        public override string ToString()
        {
            return "Куб " + S();
        }
    }
}
    

