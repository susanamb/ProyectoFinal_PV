﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void ahorcadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ahorcado form2 = new Ahorcado();
            form2.Text = "Ahorcado";
            form2.WindowState = FormWindowState.Normal;
            form2.MdiParent = this;
            form2.Show();
        }

        private void gatoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Gato form2 = new Gato();
            form2.Text = "Gato";
            form2.WindowState = FormWindowState.Normal;
            form2.MdiParent = this;
            form2.Show();
        }

        private void memoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Memoria form2 = new Memoria();
            form2.Text = "Memoria";
            form2.WindowState = FormWindowState.Normal;
            form2.MdiParent = this;
            form2.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
