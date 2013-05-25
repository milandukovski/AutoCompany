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
    public partial class LoginForm : Form
    {
        public LoginTo log;
        public String username;
        public int pass;
        public LoginForm()
        {
            InitializeComponent();
            log = new LoginTo();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            username = UserBox.Text;
            int.TryParse(PassBox.Text,out pass);
            if (log.LogIn(username, pass))
            {
                MessageBox.Show("Successful Login");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else MessageBox.Show("Loging Fail");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
