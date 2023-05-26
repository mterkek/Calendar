using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Takvim.Forms
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        //burada veritabanı bağlantısı için Classlar klasöründen SqlBaglantis sınıfının nesnesini oluşturuyoruz
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-LNMPQIK9;Initial Catalog=takvim;Integrated Security=True");
        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            if (textBoxKulAd.Text == "" || textBoxSifre.Text == "") // burada adminin bilgilerini eksik girip girmediği kontrol ediyoruz, eksik girdiyse uyarı veriyoruz
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş geçilmez.");
            }
            else
            {

                SqlCommand komut = new SqlCommand("select * from admin where username='" + textBoxKulAd.Text + "'and password = '" + textBoxSifre.Text + "'", baglanti);
                baglanti.Open();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    AdminHome adminHome = new AdminHome();
                    adminHome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı  adı veya şifresi yanlış"); // admin şifresini yanlış girdiyse uyarı alıyor
                    textBoxKulAd.Clear();
                    textBoxSifre.Clear();

                }
            }
            baglanti.Close();
        }

        private void buttonAnasayfa_Click(object sender, EventArgs e)
        {
          AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGoster.CheckState == CheckState.Checked)
            {
                textBoxSifre.UseSystemPasswordChar = true;
                checkBoxGoster.Text = "Gizle";
            }
            else if (checkBoxGoster.CheckState == CheckState.Unchecked)
            {
                textBoxSifre.UseSystemPasswordChar = false;
                checkBoxGoster.Text = "Göster";
            }
        }
    }
}
