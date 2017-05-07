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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Form_Circuit fcurcuit = new Form_Circuit();
            fcurcuit.Show();
            this.Hide();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закончить работу?", "Завершение работы",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
