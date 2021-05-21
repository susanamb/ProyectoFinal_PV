using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Memoria : Form
    {
        Stopwatch tm = new Stopwatch();
        Random random = new Random();
        Button first, second;
        int score = 0;

        public Memoria()
        {
            InitializeComponent();
        }
        private void asignaricono() { //asignar un icono a cada boton
            List<char> icons = new List<char>(){ //lista de los iconos
            ',','b','e','t','p','l','h','l','p','b','m','h',',','t','m','e'
        };
            int rand;
            Button btn;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++) {
                
                    btn = (Button)tableLayoutPanel1.Controls[i];

                    rand = random.Next(0, icons.Count);
                    btn.Text = (icons[rand].ToString());
                    btn.ForeColor = Color.LightSeaGreen;
                    //btn.Text = i.ToString();
                    icons.RemoveAt(rand);

               
            }
           
        }


        private void Memoria_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
            asignaricono();
        }

        
        private void button_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;

            if(clicked.ForeColor == Color.Black)//no seleccionar la misma
                return;

            if (first != null && second != null) //no seleccionar mas de dos botones
                return;

            if (first == null)//guarda la primera seleccionada
            {
                first = clicked;
                clicked.ForeColor = Color.Black;
                return;
            }
            else { // guarda la segunda seleccionada
                second = clicked;
                clicked.ForeColor = Color.Black;

                ganador();

                if (first.Text == second.Text) //si ambas son iguales
                {
                    score = score + 100;
                    first = null;
                    second = null;
                }
                else // inicia contador para quitar imagenes
                {
                    score = score - 10;
                    timer1.Start();
                }
                label1.Text = score.ToString();
            }
            
        }

        private void ganador() {
            Button btn;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++) {
                btn = tableLayoutPanel1.Controls[i] as Button;

                if (btn != null && btn.ForeColor == btn.BackColor)
                    return;
            }
            tm.Stop();
            int ts = 60 - Convert.ToInt32(label4.Text);
            score = score + ts;
            string tscore = " + " + ts.ToString() + " x tiempo";
            label7.Text = tscore;
            label7.Visible = true;

            MessageBox.Show("GANASTE", "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            tableLayoutPanel1.Enabled = false;
            button17.Visible = true;
        }
         private void timer1_Tick(object sender, EventArgs e)
         {
             timer1.Stop();
             
             first.ForeColor = first.BackColor;//borra las imagenes
             second.ForeColor = second.BackColor; 

             first =null;
             second = null;
         }
         private void scoretimer() {
             tm.Start();
             timer2.Enabled = true;

         }


         private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
         {
             asignaricono();
             tableLayoutPanel1.Enabled = true;
         }

         private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
         {
               this.Close();
         }

         private void timer2_Tick(object sender, EventArgs e)
         {
             TimeSpan ts = new TimeSpan(0,0,0,0,(int)tm.ElapsedMilliseconds);
             label4.Text = ts.Seconds.ToString();
             label5.Text = ts.Milliseconds.ToString();
         }

         private void button17_Click(object sender, EventArgs e)
         {
             score = 0;
             label1.Text = score.ToString();
             label7.Visible = false;
             asignaricono();
             tableLayoutPanel1.Visible = true;
             scoretimer();
             tableLayoutPanel1.Enabled = true;
             button17.Visible = false;
         }


        }
}
    