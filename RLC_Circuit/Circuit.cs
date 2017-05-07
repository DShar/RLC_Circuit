using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLC_Circuit
{
    public partial class Circuit
    {
        public Element[] elements = new Element[8];

        Complex Resistance1;
        Complex Resistance2;
        Complex Resistance3;

        Power I1;
        Power I2;
        Power I3;

        Power E;

        Power Contour1;
        Power Contour2;

        public Circuit()
        {
            for (int i = 0; i < 8; i++)
            {
                elements[i] = new Element();
            }

        }



    }
}
