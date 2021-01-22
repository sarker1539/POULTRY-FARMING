using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace PoltriFarm
{
    abstract class Poultry
    {
        public string type;
        public double weight;
        public Poultry(string type, double weight)
        {
            this.type = type;
            this.weight = weight;
        }

        public abstract double buyHen();
        public abstract double buyChick(int piece);
        public abstract double SellHen();
    }

    class Cock : Poultry
    {
        public Cock(string type, double weight)
            : base(type, weight)
        {

        }

        public override double buyHen()
        {
            return weight * 150;
        }

        public override double buyChick(int piece)
        {
            return piece * 25;
        }

        public override double SellHen()
        {
            return weight * 200;
        }
    }

    class Broylar : Poultry
    {
        public Broylar(string type, double weight)
            : base(type, weight)
        {

        }

        public override double buyHen()
        {
            return weight * 130;
        }

        public override double buyChick(int piece)
        {
            return piece * 20;
        }

        public override double SellHen()
        {
            return weight * 150;
        }
    }

    class Food_and_Vaccine
    {
        public string name;
        public double price;
        public Food_and_Vaccine(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public double calCost(List<Food_and_Vaccine> food, List<Food_and_Vaccine> vaccine)
        {
            double foodCost = 0;
            double vaccineCost = 0;
            foreach(var a in food)
            {
                foodCost += a.price;
            }
            foreach (var a in vaccine)
            {
                vaccineCost += a.price;
            }
            return (foodCost + vaccineCost);
        }
    }

    class sound
    {
        public static void soundPlay()
        {
            SoundPlayer play = new SoundPlayer();
            play.SoundLocation = "cock.wav";
            play.Load();
            play.Play();
        }
    }
}
