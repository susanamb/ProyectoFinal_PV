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
    public partial class Gato : Form
    {
        char who = 'X';
        int mov = 0;
        int score = 0;

        public Gato()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.BackColor = Color.Aqua;
            mov = mov + 1;
            if (who == 'X')
            {
                button1.Text = "X";
                who = 'O';
            }
            else {
                button1.Text = "O";
                who = 'X';
            }
            if (button2.Text == button3.Text && button2.Text == button1.Text || button4.Text == button7.Text && button7.Text == button1.Text || button5.Text == button9.Text && button9.Text == button1.Text) {
                if (who == 'X') { who = 'O'; score = score - 50; }
                else { who = 'X'; score = score + 100; }
                
                string winner = "El ganador es " + who.ToString();
                MessageBox.Show(winner, "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tableLayoutPanel1.Enabled = false;
            }
            else if (mov == 9) {
                MessageBox.Show("EMPATEEE", "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                score = score - 30;
            }
            label2.Text = score.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button2.BackColor = Color.Aqua;
            mov = mov + 1;
            if (who == 'X')
            {
                button2.Text = "X";
                who = 'O';
            }
            else
            {
                button2.Text = "O";
                who = 'X';
            }
            if (button2.Text == button3.Text && button2.Text == button1.Text || button5.Text == button8.Text && button8.Text == button2.Text)
            {
                if (who == 'X') { who = 'O'; score = score - 50; }
                else { who = 'X'; score = score + 100; }
                string winner = "El ganador es " + who.ToString();
                MessageBox.Show(winner, "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tableLayoutPanel1.Enabled = false;
            }
            else if (mov == 9)
            {
                MessageBox.Show("EMPATEEE", "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                score = score - 30;
            }
            label2.Text = score.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button3.BackColor = Color.Aqua;
            mov = mov + 1;
            if (who == 'X')
            {
                button3.Text = "X";
                who = 'O';
            }
            else
            {
                button3.Text = "O";
                who = 'X';
            }
            if (button2.Text == button3.Text && button2.Text == button1.Text || button6.Text == button9.Text && button9.Text == button3.Text || button5.Text == button7.Text && button7.Text == button3.Text)
            {
                if (who == 'X') { who = 'O'; score = score - 50; }
                else { who = 'X'; score = score + 100; }
                string winner = "El ganador es " + who.ToString();
                MessageBox.Show(winner, "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tableLayoutPanel1.Enabled = false;
            }
            else if (mov == 9)
            {
                MessageBox.Show("EMPATEEE", "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                score = score - 30;
            }
            label2.Text = score.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button4.BackColor = Color.Aqua;
            mov = mov + 1;
            if (who == 'X')
            {
                button4.Text = "X";
                who = 'O';
            }
            else
            {
                button4.Text = "O";
                who = 'X';
            }
            if (button1.Text == button7.Text && button4.Text == button1.Text || button5.Text == button6.Text && button6.Text == button4.Text)
            {
                if (who == 'X') { who = 'O'; score = score - 50; }
                else { who = 'X'; score = score + 100; }
                string winner = "El ganador es " + who.ToString();
                MessageBox.Show(winner, "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tableLayoutPanel1.Enabled = false;
            }
            else if (mov == 9)
            {
                MessageBox.Show("EMPATEEE", "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                score = score - 30;
            }
            label2.Text = score.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button5.BackColor = Color.Aqua;
            mov = mov + 1;
            if (who == 'X')
            {
                button5.Text = "X";
                who = 'O';
            }
            else
            {
                button5.Text = "O";
                who = 'X';
            }
            if (button5.Text == button4.Text && button4.Text == button6.Text || button5.Text == button9.Text && button9.Text == button1.Text || button5.Text == button7.Text && button7.Text == button3.Text || button2.Text == button5.Text && button5.Text == button8.Text )
            {
                if (who == 'X') { who = 'O'; score = score - 50; }
                else { who = 'X'; score = score + 100; }
                string winner = "El ganador es " + who.ToString();
                MessageBox.Show(winner, "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tableLayoutPanel1.Enabled = false;
            }
            else if (mov == 9)
            {
                MessageBox.Show("EMPATEEE", "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                score = score - 30;
            }
            label2.Text = score.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            button6.BackColor = Color.Aqua;
            mov = mov + 1;
            if (who == 'X')
            {
                button6.Text = "X";
                who = 'O';
            }
            else
            {
                button6.Text = "O";
                who = 'X';
            }
            if (button9.Text == button3.Text && button6.Text == button3.Text || button5.Text == button4.Text && button4.Text == button6.Text)
            {
                if (who == 'X') { who = 'O'; score = score - 50; }
                else { who = 'X'; score = score + 100; }
                string winner = "El ganador es " + who.ToString();
                MessageBox.Show(winner, "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tableLayoutPanel1.Enabled = false;
            }
            else if (mov == 9)
            {
                MessageBox.Show("EMPATEEE", "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                score = score - 30;
            }
            label2.Text = score.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            button7.BackColor = Color.Aqua;
            mov = mov + 1;
            if (who == 'X')
            {
                button7.Text = "X";
                who = 'O';
            }
            else
            {
                button7.Text = "O";
                who = 'X';
            }
            if (button4.Text == button1.Text && button4.Text == button7.Text || button8.Text == button9.Text && button7.Text == button8.Text || button5.Text == button3.Text && button3.Text == button7.Text)
            {
                if (who == 'X') { who = 'O'; score = score - 50; }
                else { who = 'X'; score = score + 100; }
                string winner = "El ganador es " + who.ToString();
                MessageBox.Show(winner, "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tableLayoutPanel1.Enabled = false;
            }
            else if (mov == 9)
            {
                MessageBox.Show("EMPATEEE", "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                score = score - 30;
            }
            label2.Text = score.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button8.BackColor = Color.Aqua;
            mov = mov + 1;
            if (who == 'X')
            {
                button8.Text = "X";
                who = 'O';
            }
            else
            {
                button8.Text = "O";
                who = 'X';
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text || button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (who == 'X') { who = 'O'; score = score - 50; }
                else { who = 'X'; score = score + 100; }
                string winner = "El ganador es " + who.ToString();
                MessageBox.Show(winner, "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tableLayoutPanel1.Enabled = false;
            }
            else if (mov == 9)
            {
                MessageBox.Show("EMPATEEE", "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                score = score - 30;
            }
            label2.Text = score.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            button9.BackColor = Color.Aqua;
            mov = mov + 1;
            if (who == 'X')
            {
                button9.Text = "X";
                who = 'O';
            }
            else
            {
                button9.Text = "O";
                who = 'X';
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text || button8.Text == button9.Text && button7.Text == button8.Text || button5.Text == button1.Text && button1.Text == button9.Text)
            {
                if (who == 'X') { who = 'O'; score = score - 50; }
                else { who = 'X'; score = score + 100; }
                string winner = "El ganador es " + who.ToString();
                MessageBox.Show(winner, "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tableLayoutPanel1.Enabled = false;
            }
            else if (mov == 9)
            {
                MessageBox.Show("EMPATEEE", "FIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                score = score - 30;
            }
            label2.Text = score.ToString();
        }

        private void nuevoJuegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            who = 'X';
            mov = 0;
            button1.Enabled = true; button1.Text = " "; button1.BackColor = Color.Gray;
            button2.Enabled = true; button2.Text = " "; button2.BackColor = Color.Gray;
            button3.Enabled = true; button3.Text = " "; button3.BackColor = Color.Gray;
            button4.Enabled = true; button4.Text = " "; button4.BackColor = Color.Gray;
            button5.Enabled = true; button5.Text = " "; button5.BackColor = Color.Gray;
            button6.Enabled = true; button6.Text = " "; button6.BackColor = Color.Gray;
            button7.Enabled = true; button7.Text = " "; button7.BackColor = Color.Gray;
            button8.Enabled = true; button8.Text = " "; button8.BackColor = Color.Gray;
            button9.Enabled = true; button9.Text = " "; button9.BackColor = Color.Gray;
            tableLayoutPanel1.Enabled = true;

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
