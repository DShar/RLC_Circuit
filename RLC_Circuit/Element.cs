using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLC_Circuit
{
    public partial class Element
    {
        Complex Resistance;

        double ActiveResistance;
        double Inductance;
        double Capacity;

        public Element()
        {
            this.Resistance = new Complex();
        }

        public Element(Complex z)
        {
            this.Resistance = new Complex(z.Real(), z.Imaginary());
        }

        //ElementType:  1 - if Resistor; 2 - if Inductor; 3 - if Capacitor
        public Element(int ElementType, double value, double w)  
        {
            switch (ElementType)
            {
                case 1:
                    this.Resistance = new Complex(value, 0);
                    this.ActiveResistance = value;
                    break;
                case 2:
                    this.Resistance = new Complex(0, w*value);
                    this.Inductance = value;
                    break;
                case 3:
                    this.Resistance = new Complex(0, (-1) / (w * value));
                    this.Capacity = value;
                    break;
            }
        }

        public void setValue(int ElementType, double value)
        {
            switch (ElementType)
            {
                case 1:
                    this.ActiveResistance = value;
                    break;
                case 2:
                    this.Inductance = value;
                    break;
                case 3:
                    this.Capacity = value;
                    break;
            }
        }

        public void setResistance(double w, int ElementType)
        {
            switch (ElementType)
            {
                case 1:
                    this.Resistance = new Complex(this.ActiveResistance, 0);
                    break;
                case 2:
                    this.Resistance = new Complex(0, w * this.Inductance);
                    break;
                case 3:
                    this.Resistance = new Complex(0, (-1) / (w * this.Capacity));
                    break;
            }
        }

        public void setResistance(Complex res)
        {
            this.Resistance = new Complex(res.Real(),res.Imaginary());
        }

        public Complex getResistance()
        {
            return this.Resistance;
        }

        public double getActiveResistance()
        {
            return this.ActiveResistance;
        }

        public double getInductance()
        {
            return this.Inductance;
        }

        public double getCapacity()
        {
            return this.Capacity;
        }

    }
}
