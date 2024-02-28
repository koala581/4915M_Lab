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
    public partial class Lab2b : Form
    {
        public Lab2b()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void radioRainy_CheckedChanged(object sender, EventArgs e)
        {
            ResetPic("Rainy", picRainy);
            
        }

        private void radioCloudy_CheckedChanged(object sender, EventArgs e)
        {
            ResetPic("Cloudy", picCloudy);
            

        }

        private void radioSnowy_CheckedChanged(object sender, EventArgs e)
        {
            ResetPic("Snowy", picSnowy);
            
        }

        private void radioSunny_CheckedChanged(object sender, EventArgs e)
        {
            ResetPic("Sunny", picSunny);
            
        }

        private void ResetPic(String weather, PictureBox pic)
        {
            picCloudy.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            picSunny.Visible = false;
            pic.Visible = true;
            lblMessage.Text = $"It’s going to be a {weather} day today, {textBoxName.Text} .";
        }

        private void Lab2b_Load(object sender, EventArgs e)
        {

        }
    }
}
