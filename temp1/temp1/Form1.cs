﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temp1
{
    public partial class form1 : Form
    {
        Program po = new Program();
        public form1()
        {
            InitializeComponent();
            numericUpDown1.DecimalPlaces = 5;
            numericUpDown1.ThousandsSeparator = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            po.setQuantum(numericUpDown1.Value);
        }

        private void btnInicia_Click(object sender, EventArgs e)
        {
            Console.WriteLine(po.getQuatum().ToString());
            po.iniciaProceso();
        }
    }
}
