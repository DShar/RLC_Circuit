using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RLC_Circuit
{
    public partial class Power
    {
        double Amplitude;
        double w;
        double Phase;

        public Power()
        {
            this.Amplitude = 0;
            this.w = 0;
            this.Phase = 0;
        }

        public Power(double a, double f, double p)
        {
            this.Amplitude = a;
            this.w = 2*f*System.Math.PI;
            this.Phase = p;
        }

        public void setAmplitude(double amp)
        {
            this.Amplitude = amp;
        }

        public double getAmplitude()
        {
            return this.Amplitude;
        }

        public void setFrequency(double f)
        {
            this.w = 2 * f * System.Math.PI;
        }

        public double W()
        {
            return this.w;
        }

        public void setPhase(double ph)
        {
            this.Phase = ph;
        }

        public double getPhase()
        {
            return this.Phase;
        }

        public override string ToString()
        {
            if(this.Phase!=0)
            {
                if(this.Phase>0)
                {
                    return this.Amplitude.ToString() + "sin(" + this.w.ToString() + "t + " + this.Phase.ToString() + ")";
                }
                else
                {
                    return this.Amplitude.ToString() + "sin(" + this.w.ToString() + "t " + this.Phase.ToString() + ")";
                }       
            }
            else
            {
                return this.Amplitude.ToString() + "sin(" + this.w.ToString() + "t)";
            }
        }

    }
}
