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
    public partial class Lab2c : Form
    {
        public Lab2c()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String name;
            name = txtName.Text;
            lstStudents.Items.Add(name);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            lstStudents.Items.Add("Mary Chu");
            lstStudents.Items.Add("Peter Lee");
            lstStudents.Items.Add("Johnson Chan");
            lstStudents.Items.Add("Alex Leung");

        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
            
        }


        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void lstStudents_DoubleClick(object sender, EventArgs e)
        {
            lblMessage.Text = $"The following item is deleted: {lstStudents.SelectedItem}";
            lstStudents.Items.Remove(lstStudents.SelectedItem);
        }
    }
}
