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
    public partial class Food_and_V : Form
    {
        string[] vaccin = { "fowlpox", "chicken infectious anemia", "encephalomyelitis" };
        string[] food = { "laying hen pellets", "oyster shell and grit", "scrath grains" };
        List<Food_and_Vaccine> foodList = new List<Food_and_Vaccine>();
        List<Food_and_Vaccine> vaccineList = new List<Food_and_Vaccine>();
        public Food_and_V()
        {
            InitializeComponent();
        }

        private void Food_and_V_Load(object sender, EventArgs e)
        {
            sound.soundPlay();
        }
        int i = 0, j = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Text = food[i];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            label2.Text = vaccin[j];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            foodList.Add(new Food_and_Vaccine(label1.Text,double.Parse(textBox1.Text)));
            textBox1.Text = "";
            if (i == food.Length)
                panel1.Visible = false;
            else
                label1.Text = food[i];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            j++;
            vaccineList.Add(new Food_and_Vaccine(label2.Text, double.Parse(textBox2.Text)));
            textBox2.Text = "";
            if (j == vaccin.Length)
                panel2.Visible = false;
            else
                label2.Text = food[j];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Food_and_Vaccine fv = new Food_and_Vaccine("", 0);
            textBox3.Text = fv.calCost(foodList, vaccineList).ToString() + " tk";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            Visible = false;
        }
    }
}
