using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4915M_Lab
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Lab1_Click(object sender, EventArgs e)
        {
            Lab1 lab1 = new Lab1();
            lab1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab2a lab2a = new Lab2a();
            lab2a.ShowDialog();
        }

        private void Lab2b_Click(object sender, EventArgs e)
        {
            Lab2b lab2b = new Lab2b();
            lab2b.ShowDialog();
        }

        private void Lab2c_Click(object sender, EventArgs e)
        {
            Lab2c lab2c = new Lab2c();
            lab2c.ShowDialog();
        }
    }
}
