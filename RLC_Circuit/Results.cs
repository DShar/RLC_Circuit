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

            //this.WriteResults();
           // this.Circuit = circuit;
        }

        public void WriteResults()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
