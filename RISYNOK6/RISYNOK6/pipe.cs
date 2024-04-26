using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RISYNOK6
{
    public class pipe: Figura
    {
        public int R;
        public int r;
        public pipe(int nX, int nR, int nr) : base(nX)
        {
            R = nR;
            r = nr;
        }

        public override double S()
        {
            return 1.0 * x * (R * R - r * r) * 3.14;
        }
        public override string ToString()
        {
            return "Туба " + S();
        }
    }
}
    

