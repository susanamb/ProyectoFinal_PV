using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Ahorcado : Form
    {
        string[] words = { "tacos", "quesadillas", "pozole", "tostadas", "pastel", "menudo", "tortas", "burritos", "chilaquiles" };
        int vidas = 6;
        int score = 0;
        Stopwatch tm = new Stopwatch();

        string[] lnes = new string[20];
        Random random = new Random();
        public Ahorcado()
        {
            InitializeComponent();
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
        private void ganador() {
            int cont = 0;
            for (int i = 0; i < lnes.Length; i++) {
                if (lnes[i] != "__") {
                    cont = cont + 1;
                }
            }
            if (cont == lnes.Length) {
                tm.Stop();
                label1.Visible = false;
                label2.Text = "Haz Ganado! :D";
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

                int ts = 60 - Convert.ToInt32(label7.Text);
                score = score + ts;
                string tscore = " + " + ts.ToString() + " x tiempo";
                label9.Text = tscore;
                label9.Visible = true;
                
            }

            label4.Text = score.ToString();
        }
        private void pic(int vidas)
        {
            if (vidas == 5)
            {
                pictureBox1.Visible = true;
                score = score - 30;
            }
            else if (vidas == 4)
            {
                pictureBox2.Visible = true;
                score = score - 35;
            }
            else if (vidas == 3)
            {
                pictureBox3.Visible = true;
                score = score - 40;
            }

            else if (vidas == 2)
            {
                pictureBox4.Visible = true;
                score = score - 45;
            }
            else if (vidas == 1)
            {
                pictureBox5.Visible = true;
                score = score - 50;
            }
            else if (vidas == 0)
            {
                score = score - 55;
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
            label2.Visible = false;
            char[] word = palabra.ToCharArray();
            tm.Start();
            timer1.Enabled = true;
            label9.Visible = false;

            for (int i = 0; i < word.Length; i++)
            {
                lnes[i] = "__";
            }

            label1.Text = string.Join(" ", lnes);
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
            button28.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)//A
        {

            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    lnes[i] = " a";
                    score = score + 100;

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
            ganador();
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
                    score = score + 100;

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
            ganador();

        }


        private void button2_Click(object sender, EventArgs e)//B
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'b')
                {
                    score = score + 100;
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
            ganador();

            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)//D
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'd')
                {
                    score = score + 100;
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
            ganador();

            button3.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)//E
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'e')
                {
                    score = score + 100;
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
            ganador();

            button8.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)//F
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'f')
                {
                    score = score + 100;
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
            ganador();

            button7.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)//G
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'g')
                {
                    lnes[i] = " g";
                    score = score + 100;
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

        private void button5_Click(object sender, EventArgs e)//H
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'h')
                {
                    score = score + 100;
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
            ganador();

            button5.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)//I
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'i')
                {
                    score = score + 100;
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
            ganador();

            button16.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)//J
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'j')
                {
                    score = score + 100;
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
            ganador();

            button15.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)//K
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'k')
                {
                    score = score + 100;
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
            ganador();

            button14.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)//L
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'l')
                {
                    score = score + 100;
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
            ganador();

            button13.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)//M
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'm')
                {
                    score = score + 100;
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
            ganador();

            button12.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)//N
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'n')
                {
                    score = score + 100;
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
            ganador();

            button11.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)//O
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'o')
                {
                    score = score + 100;
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
            ganador();
            button9.Enabled = false;
        }

        private void button24_Click(object sender, EventArgs e)//P
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'p')
                {
                    score = score + 100;
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
            ganador();
            button24.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)//Q
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'q')
                {
                    lnes[i] = " q";
                    score = score + 100;
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
            ganador();
            button23.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)//R
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'r')
                {
                    score = score + 100;
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
            ganador();
            button22.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)//S
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 's')
                {
                    lnes[i] = " s";
                    score = score + 100;
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
            ganador();
            button21.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)///T
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 't')
                {
                    score = score + 100;
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
            ganador();
            button20.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)//U
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'u')
                {
                    lnes[i] = " u";
                    score = score + 100;
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
            ganador();
            button19.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)//V
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'v')
                {
                    lnes[i] = " v";
                    score = score + 100;
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
            ganador();
            button18.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)//Y
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'y')
                {
                    lnes[i] = " y";
                    score = score + 100;
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
            ganador();
            button26.Enabled = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            score = 0;
            label4.Text = score.ToString();
            label9.Visible = false;
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
            tm.Start();


            for (int i = 0; i < word.Length; i++)
            {
                lnes[i] = "__";
            }
            
            label1.Text = string.Join(" ", lnes);
            label1.Visible = true;
            button28.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)//X
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'x')
                {
                    lnes[i] = " x";
                    score = score + 100;
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
            ganador();
            button19.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)//W
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'w')
                {
                    score = score + 100;
                    lnes[i] = " w";
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
            ganador();
            button19.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)//Z
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'z')
                {
                    score = score + 100;
                    lnes[i] = " z";
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
            ganador();
            button19.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)//ñ
        {
            string palabra = label2.Text;
            bool flag = false;
            char[] word = palabra.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'ñ')
                {
                    lnes[i] = " ñ";
                    score = score + 100;
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
            ganador();
            button19.Enabled = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)tm.ElapsedMilliseconds);
            label7.Text = ts.Seconds.ToString();
            label5.Text = ts.Milliseconds.ToString();
        }
    }

}