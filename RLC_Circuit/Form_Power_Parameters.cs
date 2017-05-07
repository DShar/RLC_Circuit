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
    public partial class Form_Power_Parameters : Form
    {
        protected Power voltage = new Power();

        protected bool isCorrectAmplitude = false;
        protected bool isCorrectFrequency = false;
        protected bool isCorrectPhase = false;

        public Form_Power_Parameters()
        {
            InitializeComponent();
        }

        public void setParameters(Form_Circuit mainForm)
        {
            double result;

            if (Double.TryParse(this.textBox_Amplitude.Text, out result))
            {
                if (textBox_Amplitude.Text != "")
                {
                    voltage.setAmplitude(Double.Parse(textBox_Amplitude.Text));
                    isCorrectAmplitude = true;
                    if (Double.Parse(textBox_Amplitude.Text) < 0 || Double.Parse(textBox_Amplitude.Text) > 50)
                    {
                        isCorrectAmplitude = false;
                    }
                    else
                    {
                        isCorrectAmplitude = true;
                    }
                }
                else
                {
                    isCorrectAmplitude = false;
                }
            }
            else
            {
                isCorrectAmplitude = false;
            }

            if(Double.TryParse(this.textBox_Frequency.Text, out result))
            {
                if (textBox_Frequency.Text != "")
                {
                    voltage.setFrequency(Double.Parse(textBox_Frequency.Text));
                    isCorrectFrequency = true;
                    if (Double.Parse(textBox_Frequency.Text) < 0)
                    {
                        isCorrectFrequency = false;
                    }
                    else
                    {
                        isCorrectFrequency = true;
                    }
                }
                else
                {
                    isCorrectFrequency = false;
                }
            }
            else
            {
                isCorrectFrequency = false;
            }

            if (Double.TryParse(this.textBox_Phase.Text, out result))
            {
                if (textBox_Phase.Text != "")
                {
                    voltage.setPhase(Double.Parse(textBox_Phase.Text));
                    isCorrectPhase = true;
                    if (Double.Parse(textBox_Phase.Text) < 0 || Double.Parse(textBox_Phase.Text) > 360) 
                    {
                        isCorrectPhase = false;
                    }
                    else
                    {
                        isCorrectPhase = true;
                    }
                }
                else
                {
                    isCorrectPhase = true;
                    voltage.setPhase(0);
                }
            }
            else
            {
                isCorrectPhase = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Circuit mainForm = (Form_Circuit)this.Owner;

            this.setParameters(mainForm);

            if(isCorrectAmplitude && isCorrectFrequency && isCorrectPhase)
            {
                mainForm.circuit.setVoltage(this.voltage);
                mainForm.isPowerSet = true;
                mainForm.parameters_labels[8].Text = mainForm.circuit.getVoltage().ToString();
                this.Close();
            }
            else
            {
                if(!isCorrectAmplitude)
                {
                    MessageBox.Show("The amplitude value is not correct!");
                }
                if(!isCorrectFrequency)
                {
                    MessageBox.Show("The frequency value is not correct!");
                }
                if(!isCorrectPhase)
                {
                    MessageBox.Show("The phase value is not correct!");
                }
            }
        }
    }
}
