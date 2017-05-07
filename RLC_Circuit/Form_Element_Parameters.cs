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
    public partial class Form_Element_Parameters : Form
    {
        protected int element_type;
        protected int element_number;

        protected bool isCorrect = false;
        protected bool isTooBig = false;

        public Form_Element_Parameters(int number, int type)
        {
            InitializeComponent();

            element_number = number;
            element_type = type;

            Form_Circuit mainForm = (Form_Circuit)this.Owner;

            switch (type)
            {
                case 1:
                    label.Text = "R = ";
                    break;
                case 2:
                    label.Text = "L = ";
                    break;
                case 3:
                    label.Text = "C = ";
                    break;
            }
            this.textBox1.Select();
        }

        public void setParameters(Form_Circuit mainForm)
        {
            double result;

            if (Double.TryParse(this.textBox1.Text, out result))
            {
                
                switch (element_type)
                {
                    case 1:
                        if (textBox1.Text != "")
                        {
                            mainForm.circuit.elements[element_number - 1].setValue(1,Double.Parse(textBox1.Text));
                            isCorrect = true;
                            if (Double.Parse(textBox1.Text) > 100)
                            {
                                isTooBig = true;
                            }
                            else
                            {
                                isTooBig = false;
                            }
                        }
                        break;
                    case 2:
                        if (textBox1.Text != "")
                        {
                            mainForm.circuit.elements[element_number - 1].setValue(2, Double.Parse(textBox1.Text));
                            isCorrect = true;
                            if (Double.Parse(textBox1.Text) > 1)
                            {
                                isTooBig = true;
                            }
                            else
                            {
                                isTooBig = false;
                            }
                        }
                        break;
                    case 3:
                        if (textBox1.Text != "")
                        {
                            mainForm.circuit.elements[element_number - 1].setValue(3, Double.Parse(textBox1.Text));
                            isCorrect = true;
                            if (Double.Parse(textBox1.Text) > 1)
                            {
                                isTooBig = true;
                            }
                            else
                            {
                                isTooBig = false;
                            }
                        }
                        break;
                }
            }
            else
            {
                isCorrect = false;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Circuit mainForm = (Form_Circuit)this.Owner;

            this.setParameters(mainForm);

            if(isCorrect && !isTooBig)
            {
                switch (element_type)
                {
                    case 1:
                        mainForm.parameters_labels[element_number - 1].Text = mainForm.circuit.elements[element_number - 1].getActiveResistance() + " Ом";
                        break;
                    case 2:
                        mainForm.parameters_labels[element_number - 1].Text = mainForm.circuit.elements[element_number - 1].getInductance() + " Гн";
                        break;
                    case 3:
                        mainForm.parameters_labels[element_number - 1].Text = mainForm.circuit.elements[element_number - 1].getCapacity() + " Ф";
                        break;
                }
                this.Close();
            }
            else
            {
                if(isTooBig)
                {
                    MessageBox.Show("You wrote very big number.Please, Enter a smaller one!");
                }
                else
                {
                    MessageBox.Show("Incorrect data! Please enter a number!");
                }
            }

        }
    }
}
