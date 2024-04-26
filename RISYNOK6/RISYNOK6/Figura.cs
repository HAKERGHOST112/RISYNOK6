using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RISYNOK6
{
    public class Figura
    {
        public int x;
        public Figura(int nX)
        {
            x = nX;
        }
        public virtual double S() { return 0; }
    }
}
