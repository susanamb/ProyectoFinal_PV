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

        private void ahorcadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ahorcado form1 = new Ahorcado();
            form1.Text = "Ahorcado";
            form1.WindowState = FormWindowState.Normal;
            form1.MdiParent = this;
            form1.Show();
        }
    }
}
