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
    public struct Single_Element
    {
        public int number;
        public int type;   // R=1;L=2;C=3
    }

    public partial class Form_Circuit : Form
    {

        public Label[] parameters_labels = new Label[9];

        //Установлены ли параметры элементов
        public bool[] isElementSet = new bool[8];
        public bool isPowerSet = false;

        public Circuit circuit = new Circuit();

        public LinkedList<Single_Element> selected_elements = new LinkedList<Single_Element>();

        public Form_Circuit()
        {
            InitializeComponent();

            Image img_res = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\voltage.png");
            pictureBox_elementPower.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_elementPower.Image = img_res;

            comboBox_element1.SelectedIndexChanged += comboBox_element1_SelectedIndexChanged;
            comboBox_element2.SelectedIndexChanged += comboBox_element2_SelectedIndexChanged;
            comboBox_element3.SelectedIndexChanged += comboBox_element3_SelectedIndexChanged;
            comboBox_element4.SelectedIndexChanged += comboBox_element4_SelectedIndexChanged;
            comboBox_element5.SelectedIndexChanged += comboBox_element5_SelectedIndexChanged;
            comboBox_element6.SelectedIndexChanged += comboBox_element6_SelectedIndexChanged;
            comboBox_element7.SelectedIndexChanged += comboBox_element7_SelectedIndexChanged;
            comboBox_element8.SelectedIndexChanged += comboBox_element8_SelectedIndexChanged;

            parameters_labels[0] = this.label_element1;
            parameters_labels[1] = this.label_element2;
            parameters_labels[2] = this.label_element3;
            parameters_labels[3] = this.label_element4;
            parameters_labels[4] = this.label_element5;
            parameters_labels[5] = this.label_element6;
            parameters_labels[6] = this.label_element7;
            parameters_labels[7] = this.label_element8;
            parameters_labels[8] = this.label_elementPower;

            for(int i=0; i<8; i++)
            {
                isElementSet[i] = false;
            }
        }

        private void comboBox_element1_SelectedIndexChanged(object sender, EventArgs e)
        {
            parameters_labels[0].Text = "";

            bool flag = false;
            int count = 0;

            Single_Element el = new Single_Element();

            string selectedType = comboBox_element1.SelectedItem.ToString();
            switch (selectedType)
            {
                case "R":
                    Image img_res = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\first.png");
                    pictureBox_element1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element1.Image = img_res;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 1)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("Где-то лоханулась!(Добавлено несколько элементов с номером " + el.number + ")");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 1;
                                selected_elements.AddFirst(el);
                            }
                        }
                        else
                        {
                            el.number = 1;
                            el.type = 1;
                            selected_elements.AddFirst(el);
                        }
                    }
                    else
                    {
                        el.number = 1;
                        el.type = 1;
                        selected_elements.AddFirst(el);
                    }
                    break;
                case "L":
                    //MessageBox.Show("Inductance");
                    Image img_ind = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\inductor.png");
                    pictureBox_element1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element1.Image = img_ind;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 1)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("Где-то лоханулась!(Добавлено несколько элементов с номером " + el.number + ")");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 2;
                                selected_elements.AddFirst(el);
                            }
                        }
                        else
                        {
                            el.number = 1;
                            el.type = 2;
                            selected_elements.AddFirst(el);
                        }
                    }
                    else
                    {
                        el.number = 1;
                        el.type = 2;
                        selected_elements.AddFirst(el);
                    }
                    break;
                case "C":
                    //MessageBox.Show("Capacitor");
                    Image img_cap = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\capacitor.png");
                    pictureBox_element1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element1.Image = img_cap;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 1)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("Где-то лоханулась!(Добавлено несколько элементов с номером " + el.number + ")");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 3;
                                selected_elements.AddFirst(el);
                            }
                        }
                        else
                        {
                            el.number = 1;
                            el.type = 3;
                            selected_elements.AddFirst(el);
                        }
                    }
                    else
                    {
                        el.number = 1;
                        el.type = 3;
                        selected_elements.AddFirst(el);
                    }
                    break;
                default:
                    MessageBox.Show("Loser!");
                    break;
            }
        }

        private void comboBox_element2_SelectedIndexChanged(object sender, EventArgs e)
        {
            parameters_labels[1].Text = "";

            bool flag = false;
            int count = 0;

            Single_Element el = new Single_Element();

            string selectedType = comboBox_element2.SelectedItem.ToString();
            switch (selectedType)
            {
                case "R":
                    //MessageBox.Show("Resistor");
                    Image img_res = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\first.png");
                    pictureBox_element2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element2.Image = img_res;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 2)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("(Добавлено несколько элементов с номером 2");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 1;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 2;
                            el.type = 1;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 2;
                        el.type = 1;
                        selected_elements.AddFirst(el);
                    }
                    break;
                case "L":
                    // MessageBox.Show("Inductance");
                    Image img_ind = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\inductor.png");
                    pictureBox_element2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element2.Image = img_ind;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 2)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("(Добавлено несколько элементов с номером 2");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 2;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 2;
                            el.type = 2;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 2;
                        el.type = 2;
                        selected_elements.AddFirst(el);
                    }
                    break;
                case "C":
                    //MessageBox.Show("Capacitor");
                    Image img_cap = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\capacitor.png");
                    pictureBox_element2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element2.Image = img_cap;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 2)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("(Добавлено несколько элементов с номером 2");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 3;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 2;
                            el.type = 3;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 2;
                        el.type = 3;
                        selected_elements.AddFirst(el);
                    }
                    break;
                default:
                    MessageBox.Show("Loser!");
                    break;


            }
        }

        private void comboBox_element3_SelectedIndexChanged(object sender, EventArgs e)
        {
            parameters_labels[2].Text = "";

            bool flag = false;
            int count = 0;

            Single_Element el = new Single_Element();

            string selectedType = comboBox_element3.SelectedItem.ToString();
            switch (selectedType)
            {
                case "R":
                    //MessageBox.Show("Resistor");
                    Image img_res = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\first.png");
                    pictureBox_element3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element3.Image = img_res;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 3)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("(Добавлено несколько элементов с номером 3");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 1;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 3;
                            el.type = 1;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 3;
                        el.type = 1;
                        selected_elements.AddFirst(el);
                    }
                    break;
                case "L":
                    //MessageBox.Show("Inductance");
                    Image img_ind = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\inductor.png");
                    pictureBox_element3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element3.Image = img_ind;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 3)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("(Добавлено несколько элементов с номером 3");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 2;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 3;
                            el.type = 2;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 3;
                        el.type = 2;
                        selected_elements.AddFirst(el);
                    }
                    break;
                case "C":
                    //MessageBox.Show("Capacitor");
                    Image img_cap = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\capacitor.png");
                    pictureBox_element3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element3.Image = img_cap;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 3)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("(Добавлено несколько элементов с номером 3");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 3;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 3;
                            el.type = 3;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 3;
                        el.type = 3;
                        selected_elements.AddFirst(el);
                    }
                    break;
                default:
                    MessageBox.Show("Loser!");
                    break;


            }
        }

        private void comboBox_element4_SelectedIndexChanged(object sender, EventArgs e)
        {
            parameters_labels[3].Text = "";

            bool flag = false;
            int count = 0;

            Single_Element el = new Single_Element();

            string selectedType = comboBox_element4.SelectedItem.ToString();
            switch (selectedType)
            {
                case "R":
                    //MessageBox.Show("Resistor");
                    Image img_res = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\resistor3.png");
                    pictureBox_element4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element4.Image = img_res;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 4)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("(Добавлено несколько элементов с номером 4");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 1;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 4;
                            el.type = 1;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 4;
                        el.type = 1;
                        selected_elements.AddFirst(el);
                    }
                    break;
                case "L":
                    // MessageBox.Show("Inductance");
                    Image img_ind = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\inductor3.png");
                    pictureBox_element4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element4.Image = img_ind;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 4)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("(Добавлено несколько элементов с номером 4");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 2;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 4;
                            el.type = 2;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 4;
                        el.type = 2;
                        selected_elements.AddFirst(el);
                    }
                    break;
                case "C":
                    //MessageBox.Show("Capacitor");
                    Image img_cap = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\capacitor3.png");
                    pictureBox_element4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element4.Image = img_cap;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 4)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("(Добавлено несколько элементов с номером 4");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 3;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 4;
                            el.type = 3;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 4;
                        el.type = 3;
                        selected_elements.AddFirst(el);
                    }
                    break;
                default:
                    MessageBox.Show("Loser!");
                    break;
            }
        }

        private void comboBox_element5_SelectedIndexChanged(object sender, EventArgs e)
        {
            parameters_labels[4].Text = "";

            bool flag = false;
            int count = 0;
            Single_Element el = new Single_Element();

            string selectedType = comboBox_element5.SelectedItem.ToString();
            switch (selectedType)
            {
                case "R":
                    //MessageBox.Show("Resistor");
                    Image img_res = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\resistor3.png");
                    pictureBox_element5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element5.Image = img_res;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 5)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("(Добавлено несколько элементов с номером 5");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 1;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 5;
                            el.type = 1;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 5;
                        el.type = 1;
                        selected_elements.AddFirst(el);
                    }
                    break;
                case "L":
                    // MessageBox.Show("Inductance");
                    Image img_ind = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\inductor3.png");
                    pictureBox_element5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element5.Image = img_ind;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 5)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("(Добавлено несколько элементов с номером 5");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 2;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 5;
                            el.type = 2;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 5;
                        el.type = 2;
                        selected_elements.AddFirst(el);
                    }
                    break;
                case "C":
                    //MessageBox.Show("Capacitor");
                    Image img_cap = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\capacitor3.png");
                    pictureBox_element5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element5.Image = img_cap;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 5)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("Где-то лоханулась!(Добавлено несколько элементов с номером 5");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 3;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 5;
                            el.type = 3;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 5;
                        el.type = 3;
                        selected_elements.AddFirst(el);
                    }
                    break;
                default:
                    MessageBox.Show("Loser!");
                    break;


            }
        }

        private void comboBox_element6_SelectedIndexChanged(object sender, EventArgs e)
        {
            parameters_labels[5].Text = "";

            bool flag = false;
            int count = 0;
            Single_Element el = new Single_Element();

            string selectedType = comboBox_element6.SelectedItem.ToString();
            switch (selectedType)
            {
                case "R":
                    //MessageBox.Show("Resistor");
                    Image img_res = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\resistor2.png");
                    pictureBox_element6.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element6.Image = img_res;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 6)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("(Добавлено несколько элементов с номером 6");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 1;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 6;
                            el.type = 1;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 6;
                        el.type = 1;
                        selected_elements.AddFirst(el);
                    }
                    break;
                case "L":
                    // MessageBox.Show("Inductance");
                    Image img_ind = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\inductor2.png");
                    pictureBox_element6.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element6.Image = img_ind;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 6)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("Где-то лоханулась!(Добавлено несколько элементов с номером 6");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 2;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 6;
                            el.type = 2;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 6;
                        el.type = 2;
                        selected_elements.AddFirst(el);
                    }
                    break;
                case "C":
                    //MessageBox.Show("Capacitor");
                    Image img_cap = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\capacitor2.png");
                    pictureBox_element6.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element6.Image = img_cap;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 6)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("(Добавлено несколько элементов с номером 6");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 3;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 6;
                            el.type = 3;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 6;
                        el.type = 3;
                        selected_elements.AddFirst(el);
                    }
                    break;
                default:
                    MessageBox.Show("Loser!");
                    break;
            }
        }

        private void comboBox_element7_SelectedIndexChanged(object sender, EventArgs e)
        {
            parameters_labels[6].Text = "";

            bool flag = false;
            int count = 0;
            Single_Element el = new Single_Element();

            string selectedType = comboBox_element7.SelectedItem.ToString();
            switch (selectedType)
            {
                case "R":
                    //MessageBox.Show("Resistor");
                    Image img_res = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\resistor2.png");
                    pictureBox_element7.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element7.Image = img_res;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 7)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("(Добавлено несколько элементов с номером 7");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 1;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 7;
                            el.type = 1;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 7;
                        el.type = 1;
                        selected_elements.AddFirst(el);
                    }
                    break;
                case "L":
                    // MessageBox.Show("Inductance");
                    Image img_ind = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\inductor2.png");
                    pictureBox_element7.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element7.Image = img_ind;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 7)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("(Добавлено несколько элементов с номером 7");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 2;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 7;
                            el.type = 2;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 7;
                        el.type = 2;
                        selected_elements.AddFirst(el);
                    }
                    break;
                case "C":
                    //MessageBox.Show("Capacitor");
                    Image img_cap = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\capacitor2.png");
                    pictureBox_element7.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element7.Image = img_cap;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 7)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("Где-то лоханулась!(Добавлено несколько элементов с номером 7");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 3;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 7;
                            el.type = 3;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 7;
                        el.type = 3;
                        selected_elements.AddFirst(el);
                    }
                    break;
                default:
                    MessageBox.Show("Loser!");
                    break;
            }
        }

        private void comboBox_element8_SelectedIndexChanged(object sender, EventArgs e)
        {
            parameters_labels[7].Text = "";

            bool flag = false;
            int count = 0;
            Single_Element el = new Single_Element();

            string selectedType = comboBox_element8.SelectedItem.ToString();
            switch (selectedType)
            {
                case "R":
                    //MessageBox.Show("Resistor");
                    Image img_res = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\first.png");
                    pictureBox_element8.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element8.Image = img_res;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 8)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("(Добавлено несколько элементов с номером 8");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 1;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 8;
                            el.type = 1;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 8;
                        el.type = 1;
                        selected_elements.AddFirst(el);
                    }
                    break;
                case "L":
                    // MessageBox.Show("Inductance");
                    Image img_ind = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\inductor.png");
                    pictureBox_element8.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element8.Image = img_ind;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 8)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("(Добавлено несколько элементов с номером 8");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 2;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 8;
                            el.type = 2;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 8;
                        el.type = 2;
                        selected_elements.AddFirst(el);
                    }
                    break;
                case "C":
                    //MessageBox.Show("Capacitor");
                    Image img_cap = Image.FromFile(@"C:\Users\Дарья\Documents\Visual Studio 2015\Projects\RLC_Circuit\RLC_Circuit\images\capacitor.png");
                    pictureBox_element8.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox_element8.Image = img_cap;
                    if (selected_elements.First != null)
                    {
                        //Был ли добавлен этот элемент
                        foreach (var iterator in selected_elements)
                        {
                            if (iterator.number == 8)
                            {
                                el = iterator;
                                count++;
                                flag = true;
                            }
                        }
                        if (flag)
                        {
                            //нужно изменить значение в списке
                            if (count > 1)
                            {
                                MessageBox.Show("(Добавлено несколько элементов с номером 8");
                            }
                            else
                            {
                                selected_elements.Remove(selected_elements.Find(el));
                                el.type = 3;
                                selected_elements.AddLast(el);
                            }
                        }
                        else
                        {
                            el.number = 8;
                            el.type = 3;
                            selected_elements.AddLast(el);
                        }
                    }
                    else
                    {
                        el.number = 8;
                        el.type = 3;
                        selected_elements.AddFirst(el);
                    }
                    break;
                default:
                    MessageBox.Show("Loser!");
                    break;
            }
        }



        private void Form_Circuit_Load(object sender, EventArgs e)
        {

        }

        private void опцииToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закончить работу?", "Завершение работы",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
        }


        private void pictureBox_element1_DoubleClick(object sender, EventArgs e)
        {
            int element_type = 0;
            
            bool flag = false;      //Добавлен элемент или нет
            if (selected_elements.First != null)
            {
                foreach (var element in selected_elements)
                {
                    if (element.number == 1)
                    {
                        flag = true;
                        element_type = element.type;
                    }
                }
                if (flag)
                {
                    Form_Element_Parameters fparam = new Form_Element_Parameters(1,element_type);
                    fparam.Owner = this;
                    fparam.Show();
                }
                else
                {
                    MessageBox.Show("Выберите элемент из выпадающего списка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void pictureBox_element2_DoubleClick(object sender, EventArgs e)
        {
            int element_type = 0;
            bool flag = false;
            if (selected_elements.First != null)
            {
                foreach (var element in selected_elements)
                {
                    if (element.number == 2)
                    {
                        flag = true;
                        element_type = element.type;
                    }
                }
                if (flag)
                {
                    Form_Element_Parameters fparam = new Form_Element_Parameters(2, element_type);
                    fparam.Owner = this;
                    fparam.Show();
                }
                else
                {
                    MessageBox.Show("Выберите элемент из выпадающего списка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void pictureBox_element3_DoubleClick(object sender, EventArgs e)
        {
            int element_type = 0;
            bool flag = false;
            if (selected_elements.First != null)
            {
                foreach (var element in selected_elements)
                {
                    if (element.number == 3)
                    {
                        flag = true;
                        element_type = element.type;
                    }
                }
                if (flag)
                {
                    Form_Element_Parameters fparam = new Form_Element_Parameters(3, element_type);
                    fparam.Owner = this;
                    fparam.Show();
                }
                else
                {
                    MessageBox.Show("Выберите элемент из выпадающего списка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void pictureBox_element4_DoubleClick(object sender, EventArgs e)
        {
            int element_type = 0;
            bool flag = false;
            if (selected_elements.First != null)
            {
                foreach (var element in selected_elements)
                {
                    if (element.number == 4)
                    {
                        flag = true;
                        element_type = element.type;
                    }
                }
                if (flag)
                {
                    Form_Element_Parameters fparam = new Form_Element_Parameters(4, element_type);
                    fparam.Owner = this;
                    fparam.Show();
                }
                else
                {
                    MessageBox.Show("Выберите элемент из выпадающего списка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void pictureBox_element5_DoubleClick(object sender, EventArgs e)
        {
            int element_type = 0;
            bool flag = false;
            if (selected_elements.First != null)
            {
                foreach (var element in selected_elements)
                {
                    if (element.number == 5)
                    {
                        flag = true;
                        element_type = element.type;
                    }
                }
                if (flag)
                {
                    Form_Element_Parameters fparam = new Form_Element_Parameters(5, element_type);
                    fparam.Owner = this;
                    fparam.Show();
                }
                else
                {
                    MessageBox.Show("Выберите элемент из выпадающего списка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void pictureBox_element6_DoubleClick(object sender, EventArgs e)
        {
            int element_type = 0;
            bool flag = false;
            if (selected_elements.First != null)
            {
                foreach (var element in selected_elements)
                {
                    if (element.number == 6)
                    {
                        flag = true;
                        element_type = element.type;
                    }
                }
                if (flag)
                {
                    Form_Element_Parameters fparam = new Form_Element_Parameters(6, element_type);
                    fparam.Owner = this;
                    fparam.Show();
                }
                else
                {
                    MessageBox.Show("Выберите элемент из выпадающего списка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void pictureBox_element7_DoubleClick(object sender, EventArgs e)
        {
            int element_type = 0;
            bool flag = false;
            if (selected_elements.First != null)
            {
                foreach (var element in selected_elements)
                {
                    if (element.number == 7)
                    {
                        flag = true;
                        element_type = element.type;
                    }
                }
                if (flag)
                {
                    Form_Element_Parameters fparam = new Form_Element_Parameters(7, element_type);
                    fparam.Owner = this;
                    fparam.Show();
                }
                else
                {
                    MessageBox.Show("Выберите элемент из выпадающего списка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void pictureBox_element8_DoubleClick(object sender, EventArgs e)
        {
            int element_type = 0;
            bool flag = false;
            if (selected_elements.First != null)
            {
                foreach (var element in selected_elements)
                {
                    if (element.number == 8)
                    {
                        flag = true;
                        element_type = element.type;
                    }
                }
                if (flag)
                {
                    Form_Element_Parameters fparam = new Form_Element_Parameters(8, element_type);
                    fparam.Owner = this;
                    fparam.Show();
                }
                else
                {
                    MessageBox.Show("Выберите элемент из выпадающего списка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void pictureBox_elementPower_DoubleClick(object sender, EventArgs e)
        {
            Form_Power_Parameters fparam = new Form_Power_Parameters();
            fparam.Owner = this;
            fparam.Show();
        }

        private void расчитатьТокиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isSet = false;
            for (int i = 0; i < 8; i++)
            {
                if (!isElementSet[i])
                {
                    isSet = false;
                    MessageBox.Show("Set parameters of element № " + (++i));
                    break;
                }
                else
                {
                    isSet = true;
                }
            }

            if (!isPowerSet)
            {
                MessageBox.Show("Set voltage, please! ");
            }
            else
            {
                if (selected_elements.Count != 8)
                {
                    MessageBox.Show("Установите все элементы!", "Установка параметров", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(isSet)
                    {
                        //Установка сопроивлений элементам
                        for(int i=0;i<8;i++)
                        {
                           // MessageBox.Show("W = " + circuit.getVoltage().W());
                            circuit.elements[i].setResistance(circuit.getVoltage().W(), circuit.elements[i].getType());
                            //MessageBox.Show("Resistance № "+(i+1)+" = " + circuit.elements[i].getResistance().ToString());
                        }

                        Results fresults = new Results(this.circuit);
                        fresults.Owner = this;
                        fresults.Show();
                    }  
                }
                
            }
                        
        }
    }
}
