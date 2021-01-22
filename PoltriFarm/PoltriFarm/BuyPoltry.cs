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
    public partial class BuyPoltry : Form
    {
        public BuyPoltry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //calBill cal = new calBill(button1.Text);
            //cal.Show();
            //Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //calBill cal = new calBill(button2.Text);
            //cal.Show();
            //Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Visible = true;
                comboBox2.SelectedIndex = 0;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Visible = true;
                comboBox2.SelectedIndex = 0;
            }
        }

        private void BuyPoltry_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            sound.soundPlay();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                if (comboBox2.SelectedIndex == 1)
                {
                    label2.Text = "Per kilo price : 150 tk";
                    label1.Text = "kg :";
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    label2.Text = "Per piece price : 25 tk";
                    label1.Text = "Piece :";
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (comboBox2.SelectedIndex == 1)
                {
                    label2.Text = "Per kilo price : 130 tk";
                    label1.Text = "kg :";
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    label2.Text = "Per piece price : 15 tk";
                    label1.Text = "Piece :";
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                Cock cock = new Cock(comboBox2.Text, double.Parse(textBox1.Text));
                if (comboBox2.SelectedIndex == 1)
                {
                    textBox2.Text = cock.buyHen().ToString() + " tk";
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    textBox2.Text = cock.buyChick(int.Parse(textBox1.Text)).ToString() + " tk";
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Broylar broylar = new Broylar(comboBox2.Text, double.Parse(textBox1.Text));
                if (comboBox2.SelectedIndex == 1)
                {
                    textBox2.Text = broylar.buyHen().ToString() + " tk";
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    textBox2.Text = broylar.buyChick(int.Parse(textBox1.Text)).ToString() + " tk";
                }
            }
        }
    }
}
