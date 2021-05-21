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
    public partial class ppt : Form
    {
        Random random = new Random();
        bool player = true;
        string j1;
        string j2;
        int score = 0;

        public ppt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//PIEDRA
        {
            pictureBox1.Image = global::ProyectoFinal.Properties.Resources.rock;
            j1 = "piedra";
            if (player)
            {
                ran();
                ganador();
            }
            else {
                pictureBox1.Visible = false;
                pl2();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)//PAPEL
        {
            j1 = "papel";
            pictureBox1.Image = global::ProyectoFinal.Properties.Resources.paper;
            if (player)
            {
                ran();
                ganador();
            }
            else
            {
                pictureBox1.Visible = false;
                pl2();
            }
        }

        private void button3_Click(object sender, EventArgs e)//TIJERA
        {
            j1 = "tijera";
            pictureBox1.Image = global::ProyectoFinal.Properties.Resources.tijera;
            if (player)
            {
                ran();
                ganador();
            }
            else
            {
                pictureBox1.Visible = false;
                pl2();
            }
        }

        private void dosJugadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            player = false;
            label2.Text = "Jugador 2";
            
        }
        private void ran() { 
            int n = random.Next(0, 6);
            if( n ==1 || n == 6){
                j2 = "piedra";
                pictureBox2.Image = global::ProyectoFinal.Properties.Resources.rock;
            }
            else if (n == 2 || n == 5) {
                j2 = "papel";
                pictureBox2.Image = global::ProyectoFinal.Properties.Resources.paper;
            }
            else if (n == 3 || n == 4 ) {
                j2 = "tijera";
                pictureBox2.Image = global::ProyectoFinal.Properties.Resources.tijera;
            }
        }

        private void pl2() {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
            {
                j2 = "piedra";
                pictureBox2.Image = global::ProyectoFinal.Properties.Resources.rock;
                pictureBox1.Visible = true;
                ganador();
            }
        private void button5_Click(object sender, EventArgs e)
            {
                j2 = "papel";
                pictureBox2.Image = global::ProyectoFinal.Properties.Resources.paper;
                pictureBox1.Visible = true;
                ganador();

            }

        private void button6_Click(object sender, EventArgs e)
            {
                j2 = "tijera";
                pictureBox2.Image = global::ProyectoFinal.Properties.Resources.tijera;
                pictureBox1.Visible = true;
                ganador();
            }

        private void ganador() {
            if (j1 == "piedra" && j2 == "tijera" || j1 == "papel" && j2 == "piedra" || j1 == "tijera" && j2 == "papel") {
                score = score + 100;
                MessageBox.Show("GANA JUGADOR 1", "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (j1 == j2)
            {
                score = score + 50;
                MessageBox.Show("EMPATE", "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                score = score - 50;
                MessageBox.Show("GANA JUGADOR 2", "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            label7.Text = score.ToString();
            button7.Visible = true;
            pictureBox1.Image = global::ProyectoFinal.Properties.Resources.rps;
            pictureBox2.Image = global::ProyectoFinal.Properties.Resources.rps;
        }
        private void nuevo() { 
            button7.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }

        private void dosJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player = true;
            label2.Text = "CPU";
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void unJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevo();
        }

   
        

    }
}
