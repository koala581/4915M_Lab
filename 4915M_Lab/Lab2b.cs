﻿using System;
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
            picCloudy.Visible = false;
            picRainy.Visible = true;
            picSnowy.Visible = false;
            picSunny.Visible = false;
            lblMessage.Text = "It’s going to be a cloudy day today, " + textBoxName.Text + ".";
        }

        private void radioCloudy_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = true;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            picSunny.Visible = false;
            lblMessage.Text = "It’s going to be a cloudy day today, " + textBoxName.Text + ".";

        }

        private void radioSnowy_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = true;
            picSunny.Visible = false;
            lblMessage.Text = "It’s going to be a cloudy day today, " + textBoxName.Text + ".";
        }

        private void radioSunny_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            picSunny.Visible = true;
            lblMessage.Text = "It’s going to be a cloudy day today, " + textBoxName.Text + ".";
        }
    }
}
