﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Theme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void whiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void colorGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Yoa Checjed the box1");
            }
            if (checkBox2.Checked)
            {
                MessageBox.Show("Yoa Checjed the box2");
            }
            if (checkBox3.Checked)
            {
                MessageBox.Show("Yoa Checjed the box3");
            }
        }
    }
}
