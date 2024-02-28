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
    public partial class Lab2a : Form
    {
        private int price;
        private string payment;
        public Lab2a()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            price = 250;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            price = 180;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            price = 75;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            payment = "VISA";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            payment = "MasterCard";
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(textBoxQty.Text) * price;
            lblResult.Text = "Total price: " + total + ", Payment Method: " + payment;
            lblResult.Text = $"Total price: {total}, Payment Method: {payment}";
        }

        private void Lab2_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton4.Checked = true;
        }
    }
}
