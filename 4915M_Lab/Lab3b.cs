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
    public partial class Lab3b : Form
    {
        

        public Lab3b()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(txtAmount.Text);
            double rate = Convert.ToDouble(txtRate.Text);
            double total = amount;
            for(int i = 0; i <10; i++)
            {
                total = total * (1 + rate);
            }
            lblValue2.Text = total.ToString();
            int year;
            for(year = 0, total = amount; total <1000000; year++)
            {
                total = total * (1 + rate);
            }
            lblMillion2.Text = year.ToString();
           
           
            
        }
    }
}
