using System;
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
            pictureBox1.Visible = false;
            Ahorcado form2 = new Ahorcado();
            form2.Text = "Ahorcado";
            form2.WindowState = FormWindowState.Normal;
            form2.MdiParent = this;
            form2.Show();
        }

        private void gatoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            Gato form2 = new Gato();
            form2.Text = "Gato";
            form2.WindowState = FormWindowState.Normal;
            form2.MdiParent = this;
            form2.Show();
        }

        private void memoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
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

        private void piedraPapelTijeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            ppt form2 = new ppt();
            form2.Text = "Piedra Papel Tijera";
            form2.WindowState = FormWindowState.Normal;
            form2.MdiParent = this;
            form2.Show();
        }

        private void piedraPapelTijeraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            ppt form2 = new ppt();
            form2.Text = "Piedra Papel Tijera";
            form2.WindowState = FormWindowState.Normal;
            form2.MdiParent = this;
            form2.Show();
        }

    }
}
