﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hello
{
    public partial class Form1 : Form
    {
	private string strTextToShow;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
		this.strTextToShow = this.textBox.Text;
		MessageBox.Show(this.strTextToShow + Environment.NewLine + this.textBox.Text);
        }
    }
}
