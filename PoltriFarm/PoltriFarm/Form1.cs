using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace PoltriFarm
{
    public partial class Form1 : Form
    {
        SoundPlayer play = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuyPoltry by = new BuyPoltry();
            by.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sellPoltry sell = new sellPoltry();
            sell.Show();
            Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            sound.soundPlay();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                BuyPoltry by = new BuyPoltry();
                by.Show();
                Visible = false;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Food_and_V food = new Food_and_V();
                food.Show();
                Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            exit ex = new exit();
            ex.Show();
            Visible = false;
        }
    }
}
