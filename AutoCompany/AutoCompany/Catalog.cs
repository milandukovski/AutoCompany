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
    public partial class Catalog : Form
    {

        public GetCarInfo car;
        public List<String> list;
        public int max;
        public int i;
        public Catalog()
        {
            InitializeComponent();
            i = 0;
            car = new GetCarInfo();
            list = new List<string>();
            list = car.make_connection();
            max = list.Count;
            String[] s = list[i].Split(' ');
            CarPicture.ImageLocation = s[0];
            int k = 1;
            for (int j = 1; j < s.Length; j++)
            {
                
                if (s[j].Trim().Length != 0)
                {
                    insertToBox(k);
                    CarSpecifics.Text += s[j] + "\n";
                    k++;
                }
            }

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            i++;
            if (i == max) i = 0;
            CarSpecifics.Text = "";
            String[] s = list[i].Split(' ');
            CarPicture.ImageLocation = s[0];
            int k = 1;
            for (int j = 1; j < s.Length; j++)
            {
                
                if (s[j].Trim().Length != 0)
                {
                    insertToBox(k);
                    CarSpecifics.Text += s[j] + "\n";
                    k++;
                }
            }
        }

        private void PervBtn_Click(object sender, EventArgs e)
        {
            i--;
            if (i <0) i = max-1;
            CarSpecifics.Text = "";
            String[] s = list[i].Split(' ');
            CarPicture.ImageLocation = s[0];
            int k = 1;
            for (int j = 1; j < s.Length; j++)
            {
                if (s[j].Trim().Length != 0)
                {
                    insertToBox(k);
                    CarSpecifics.Text += s[j] + "\n";
                    k++;
                }
            }
        }
        public void insertToBox(int k)
        {
            if (k == 1) CarSpecifics.Text += "Марка: ";
            if (k == 2) CarSpecifics.Text += "Модел: ";
            if (k == 3) CarSpecifics.Text += "Тежина: ";
            if (k == 4) CarSpecifics.Text += "Потрошувачка: ";
            if (k == 5) CarSpecifics.Text += "Година: ";
            if (k == 6) CarSpecifics.Text += "Димензии: ";
            if (k == 7) CarSpecifics.Text += "TopSpeed: ";
            if (k == 8) CarSpecifics.Text += "Price: ";
        }


    }
}
