﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarpl
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public void Setform1(Form1 form1) {
            this.form1 = form1;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            form1.Show();
        }
    }
}
