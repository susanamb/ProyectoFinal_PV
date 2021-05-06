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
    public partial class Ahorcado : Form
    {
        string[] words = { "tacos", "quesadillas", "pozole", "tostadas", "pastel", "menudo", "tortas", "burritos", "chilaquiles" };
        int vidas = 6;

        string[] lnes = new string[20];
        Random random = new Random();
        public Ahorcado()
        {
            InitializeComponent();
        }
        private void pic(int vidas)
        {
            if (vidas == 5)
            {
                pictureBox1.Visible = true;
            }
            else if (vidas == 4)
            {
                pictureBox2.Visible = true;
            }
            else if (vidas == 3)
            {
                pictureBox3.Visible = true;
            }
            else if (vidas == 2)
            {
                pictureBox4.Visible = true;
            }
            else if (vidas == 1)
            {
                pictureBox5.Visible = true;
            }
            else if (vidas == 0)
            {
                pictureBox6.Visible = true;
                label1.Visible = false;
                label2.Text = "Haz Perdido!";
                label2.Visible = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;
                button25.Enabled = false;
                button26.Enabled = false;
                button27.Enabled = false;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;

            label2.Visible = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int num = random.Next(words.Length);
            string palabra = words[num];
            label2.Text = palabra;
            char[] word = palabra.ToCharArray();


            for (int i = 0; i < word.Length; i++)
            {
                lnes[i] = "__";
            }

            label1.Text = string.Join(" ", lnes);
            button28.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    lnes[i] = " a";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button1.Enabled = false;
        }


        private void button4_Click(object sender, EventArgs e)//C
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'c')
                {
                    lnes[i] = " c";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button4.Enabled = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'b')
                {
                    lnes[i] = " b";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'd')
                {
                    lnes[i] = " d";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button3.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'e')
                {
                    lnes[i] = " e";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button8.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'f')
                {
                    lnes[i] = " f";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button7.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'g')
                {
                    lnes[i] = " g";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button6.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'h')
                {
                    lnes[i] = " h";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button5.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'i')
                {
                    lnes[i] = " i";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button16.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'j')
                {
                    lnes[i] = " j";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button15.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'k')
                {
                    lnes[i] = " k";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button14.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'l')
                {
                    lnes[i] = " l";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button13.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'm')
                {
                    lnes[i] = " m";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button12.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'n')
                {
                    lnes[i] = " n";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button11.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'o')
                {
                    lnes[i] = " o";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button9.Enabled = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'p')
                {
                    lnes[i] = " p";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button24.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'q')
                {
                    lnes[i] = " q";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button23.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'r')
                {
                    lnes[i] = " r";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button22.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 's')
                {
                    lnes[i] = " s";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button21.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 't')
                {
                    lnes[i] = " t";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button20.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'u')
                {
                    lnes[i] = " u";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button19.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'v')
                {
                    lnes[i] = " v";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button18.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'y')
                {
                    lnes[i] = " y";
                    //label2.Visible = true;
                    flag = true;

                }
            }
            if (!flag)
            {
                vidas = vidas - 1;
                pic(vidas);
            }
            label1.Text = string.Join(" ", lnes);
            button26.Enabled = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            label2.Visible = false;
            vidas = 6;
            int num = random.Next(words.Length);
            string palabra = words[num];
            label2.Text = palabra;
            char[] word = palabra.ToCharArray();


            for (int i = 0; i < word.Length; i++)
            {
                lnes[i] = "__";
            }

            label1.Text = string.Join(" ", lnes);
            button28.Visible = false;
        }
    }

}