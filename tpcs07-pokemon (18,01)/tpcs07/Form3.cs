using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tpcs07
{
    public partial class Form3 : Form
    {
        Pokemon j1;
        Pokemon j2;

        Pokemon vide;
        Pokemon p1;
        Pokemon p2;
        Pokemon p3;
        Pokemon p4;
        Pokemon p5;
        Pokemon p6;

        public Form3(Pokemon vide,Pokemon p1, Pokemon p2, Pokemon p3, Pokemon p4, Pokemon p5, Pokemon p6)
        {
            this.j1 = vide;
            this.j2 = vide;

            this.vide = vide;
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
            this.p6 = p6;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            j1 = p1;
            label5.Text = "Pikachu";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            j1 = p2;
            label5.Text = "Dracaufeu";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            j1 = p3;
            label5.Text = "Lockhlass";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            j1 = p4;
            label5.Text = "Smogogo";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            j1 = p5;
            label5.Text = "Spectrum";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            j1 = p6;
            label5.Text = "Aquali";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            j2 = p1;
            label6.Text = "Pikachu";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            j2 = p2;
            label6.Text = "Dracaufeu";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            j2 = p3;
            label6.Text = "Lockhlass";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            j2 = p4;
            label6.Text = "Smogogo";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            j2 = p5;
            label6.Text = "Spectrum";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            j2 = p6;
            label6.Text = "Aquali";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (j1 == vide || j2 == vide)
            {
                MessageBox.Show("All players have to choose one pokemon.", "Error");
            }
            else if (j1 == j2)
            {
                MessageBox.Show("All players have to choose different pokemon.", "Error");
            }
            else
            {
                Arena arena = new Arena(j1, j2);
                Form1 test = new Form1(arena);
                test.ShowDialog(this);
            }
        }
    }
}
