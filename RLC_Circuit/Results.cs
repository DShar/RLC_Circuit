using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RLC_Circuit
{
    public partial class Results : Form
    {
        protected Circuit Circuit = new Circuit();

        public Label[] results_labels = new Label[8];

        public Results(Circuit circuit)
        {
            InitializeComponent();

            results_labels[0] = this.label1;
            results_labels[1] = this.label2;
            results_labels[2] = this.label3;
            results_labels[3] = this.label4;
            results_labels[4] = this.label5;
            results_labels[5] = this.label6;
            results_labels[6] = this.label7;
            results_labels[7] = this.label8;

            for (int i = 0; i < 8; i++)
            {
                this.Circuit.elements[i] = new Element(circuit.elements[i].getResistance());
                this.results_labels[i].Text = "X" + (i + 1) + " = " + this.Circuit.elements[i].getResistance().ToString();
            }

            this.Circuit.setVoltage(circuit.getVoltage());
            this.label_Power.Text = "E = " + this.Circuit.getVoltage().ToString();

            this.WriteResults();
        }

        public void WriteResults()
        { 
            //Эквивалентное сопротивление 1
            this.Circuit.Resistance1 = ((Complex.Sum(this.Circuit.elements[0].getResistance(), this.Circuit.elements[1].getResistance()))
                * this.Circuit.elements[2].getResistance()) / 
                (Complex.Sum(this.Circuit.elements[0].getResistance(), this.Circuit.elements[1].getResistance(), this.Circuit.elements[2].getResistance()));

            //Эквивалентное сопротивление 2
            this.Circuit.Resistance2 = ((this.Circuit.elements[3].getResistance() * this.Circuit.elements[4].getResistance()) /
               ( this.Circuit.elements[3].getResistance() + this.Circuit.elements[4].getResistance()));

            //Эквивалентное сопротивление 3
            this.Circuit.Resistance3 = ((this.Circuit.elements[6].getResistance() + this.Circuit.elements[7].getResistance()) * this.Circuit.elements[5].getResistance()) /
                (this.Circuit.elements[6].getResistance() + this.Circuit.elements[7].getResistance() + this.Circuit.elements[5].getResistance());


            this.label1.Text = "Resistance1 = " + this.Circuit.Resistance1.ToString();
            this.label2.Text = "Resistance2 = " + this.Circuit.Resistance2.ToString();
            this.label3.Text = "Resistance3 = " + this.Circuit.Resistance3.ToString();

            //Расчёт амплитуды контурных токов
            //I(I)max = E / Zэкв  Zэкв - tempResistance1
            //I(II)max = E / Zдел Zдел - tempResistance2

            Complex tempResistance1 = new Complex();
            tempResistance1 = this.Circuit.Resistance3 + this.Circuit.Resistance1 +
                ((this.Circuit.Resistance1 * this.Circuit.Resistance3) / this.Circuit.Resistance2);

            Complex tempResistance2 = new Complex();
            Complex Constant1 = new Complex(1, 0);  // 1 в виде комплексного числа (1+0i)
            tempResistance2 = (this.Circuit.Resistance1 + this.Circuit.Resistance2) / (Constant1 + (this.Circuit.Resistance2 / tempResistance1));
            //this.label5.Text = "Zэкв = " + tempResistance1.ToString();

            double Emax = this.Circuit.getVoltage().getAmplitude();

            //Ток вo 2 контуре
            this.Circuit.I3 = new Power(Emax/Complex.Abs(tempResistance1),this.Circuit.getVoltage().W()/(2*System.Math.PI),this.Circuit.getVoltage().getPhase()+System.Math.Atan2(tempResistance1.Imaginary(),tempResistance1.Real()));
            this.label4.Text = "I3 = " + this.Circuit.I3.ToString();

            //Ток в первом контуре
            this.Circuit.I1 = new Power(Emax / Complex.Abs(tempResistance2), this.Circuit.getVoltage().W() / (2 * System.Math.PI), this.Circuit.getVoltage().getPhase() + System.Math.Atan2(tempResistance2.Imaginary(), tempResistance2.Real()));
            this.label5.Text = "I1 = " + this.Circuit.I1.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
