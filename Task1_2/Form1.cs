﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StringLibrary;

namespace Task1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var helloMessage = new HelloMessage();
            var message = helloMessage.GetHelloMessage(_textBoxName.Text);
            _buttonResult.Text = helloMessage.GetHelloMessage(_textBoxName.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
