using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takvim.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void buttonUyeOl_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();

        }

        private void buttonOgrenciGiris_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Hide();
        }

        private void buttonAdminGiris_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
