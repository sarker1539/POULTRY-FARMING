using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PoltriFarm
{
    public partial class sellPoltry : Form
    {
        public sellPoltry()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void sellPoltry_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            sound.soundPlay();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                label2.Text = "Per kilo price : 200 tk";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label2.Text = "Per kilo price : 150 tk";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                Cock cock = new Cock("hen",int.Parse(textBox1.Text));
                textBox2.Text = cock.SellHen().ToString() + " tk";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Broylar boylar = new Broylar("hen", int.Parse(textBox1.Text));
                textBox2.Text = boylar.SellHen().ToString() + " tk";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            Visible = false;
        }
    }
}
