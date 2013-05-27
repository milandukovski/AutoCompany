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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
           
        }
        public void RASE()
        {
            
        }

        private void CatalogBtn_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.ShowDialog();
        }
        
        private void Login_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            if (log.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string name = log.username;
                int pass = log.pass;
                StaffInterface staff = new StaffInterface();
                staff.setUserPass(name, pass);
                staff.ShowDialog();

            }


        }

        private void Login_MouseHover(object sender, EventArgs e)
        {
            Login.BackColor = Color.Aqua;
        }

        private void Login_MouseLeave(object sender, EventArgs e)
        {
            Login.BackColor = Color.White;
        }

        private void CatalogBtn_MouseHover(object sender, EventArgs e)
        {
            CatalogBtn.BackColor = Color.Aqua;
        }

        private void CatalogBtn_MouseLeave(object sender, EventArgs e)
        {
            CatalogBtn.BackColor = Color.White;
        }
    }
}
