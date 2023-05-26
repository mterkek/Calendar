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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        // Burada Sql baglantısını kurmak için Classlar klasöründen SqlBaglantisi sınıfını çalışıtırıyoruz
        Classes.SqlBaglantisi sql = new Classes.SqlBaglantisi();
        //Burda giriş yapan kullanıcının bilgilerini Classlar klasöründekiki Bilgiler sınıfına kaydediyoruz ki sonra lazım olursa oradan çekelim
        public Classes.KullaniciBilgileri bilgiler = new Classes.KullaniciBilgileri();

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            if (textBoxKulAd.Text == "" || textBoxSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş geçilmez.");
            }
            else
            {
                DataSet ds = new DataSet();
                string sql2 = "select * from users where username = '" + textBoxKulAd.Text + "'and password = '" + textBoxSifre.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql2, sql.baglan());
                ds = new DataSet();
                da.Fill(ds, "KULLANICIDENEME");
                //con.Close();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    // burada giren kullanıcının bilgilerini veritabnından çekiyoruz
                    string userIdtxt = ds.Tables[0].Rows[0]["userId"].ToString();
                    string nametxt = ds.Tables[0].Rows[0]["name"].ToString();
                    string surnametxt = ds.Tables[0].Rows[0]["surname"].ToString();
                    string usernametxt = ds.Tables[0].Rows[0]["username"].ToString();
                    string passwordtxt = ds.Tables[0].Rows[0]["password"].ToString();
                    string tctxt = ds.Tables[0].Rows[0]["tc"].ToString();
                    string phonetxt = ds.Tables[0].Rows[0]["phone"].ToString();
                    string emailtxt = ds.Tables[0].Rows[0]["email"].ToString();
                    string userTypetxt = ds.Tables[0].Rows[0]["userType"].ToString();
                    string adrestxt = ds.Tables[0].Rows[0]["adres"].ToString();

                    // burada veritabanından çektiğimiz bilgileri class'a ekliyoruz
                    Classes.KullaniciBilgileri.userId = Convert.ToInt32(userIdtxt);
                    Classes.KullaniciBilgileri.name = nametxt;
                    Classes.KullaniciBilgileri.surname = surnametxt;
                    Classes.KullaniciBilgileri.username = usernametxt;
                    Classes.KullaniciBilgileri.password = passwordtxt;
                    Classes.KullaniciBilgileri.tc = tctxt;
                    Classes.KullaniciBilgileri.phone = phonetxt;
                    Classes.KullaniciBilgileri.email = emailtxt;
                    Classes.KullaniciBilgileri.adres = adrestxt;

                    //////burada öğrenci anasayfasına yönlendiriyoruz
                     Calendar calendar = new Calendar();
                    calendar.Show();
                      this.Hide();
                    //Kontrol kont = new Kontrol();
                    //kont.Show();
                    //this.Hide();

                }

                else
                {
                    //burada kullanıcı eğer yanlış bir bir kayıt girdiyse uyarı veriyoruz
                    MessageBox.Show("Kullanıcı  adı veya şifresi yanlış");
                    textBoxKulAd.Clear();
                    textBoxSifre.Clear();

                }
            }
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
