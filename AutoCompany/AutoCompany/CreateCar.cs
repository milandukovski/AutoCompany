using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoCompany
{
    public partial class CreateCar : Form
    {
        public CreateCar()
        {
            InitializeComponent();



        }
        public void logIn(string user)
        {
            logLabel.Text = "User logged in: " + user;
        }

        private void CanselBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Slika
            String pic = PictureBox.Text;
            //Tezina
            int weight;
            int.TryParse(WeightBox.Text, out weight);
            //potrosuvacka
            int spend;
                int.TryParse(SpendBox.Text,out spend);
            //godina
                int year;
                int.TryParse(YearBox.Text, out year);
            //dimenzii
                string dimenz = DimensionBox.Text;
            //topspeed
                int topSpeed;
                int.TryParse(SpeedBox.Text, out topSpeed);
            //cena
                int cena;
                int.TryParse(PriceBox.Text, out cena);
                AddCar createCar = new AddCar();
                createCar.add(pic, weight, spend, year, dimenz, topSpeed,cena,ModelBox.Text);
            
            this.Close();
        }

        

        
    }
}
