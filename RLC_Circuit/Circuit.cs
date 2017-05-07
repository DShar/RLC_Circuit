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

        public Complex Resistance1;
        public Complex Resistance2;
        public Complex Resistance3;

        public Power I1;
        public Power I2;
        public Power I3;

        Power E;

        public Power Contour1;
        public Power Contour2;



        public Circuit()
        {
            for (int i = 0; i < 8; i++)
            {
                elements[i] = new Element();
            }

        }

        public void setVoltage(Power vol)
        {
            this.E = vol;
        }

        public Power getVoltage()
        {
            return this.E;
        }

    }
}
