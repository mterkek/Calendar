using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace Takvim.Forms
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        Classes.SqlBaglantisi sql = new Classes.SqlBaglantisi();

        private void buttonUyeOl_Click(object sender, System.EventArgs e)
        {

            // burada kullanıcının verilen bilgileri eksik girip girmediği kontrol ediliyor
            if (textBoxAd.Text == "" || textBoxSoyad.Text == "" || textBoxKulAd.Text == "" || textBoxMail.Text == "" || textBoxSifre.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
            }
            else
            {
                // eğer tüm bilgileri girmişse bu bilgiler veritabanına kaydediliyor
                string sorgu = "insert into users(name,surname,username,password,tc,phone,email,adres)values(@name,@surname,@username,@password,@tc,@phone,@email,@adres)";
                SqlCommand komut = new SqlCommand(sorgu, sql.baglan());

                komut.Parameters.AddWithValue("@name", textBoxAd.Text);
                komut.Parameters.AddWithValue("@surname", textBoxSoyad.Text);
                komut.Parameters.AddWithValue("@username", textBoxKulAd.Text);
                komut.Parameters.AddWithValue("@password", textBoxSifre.Text);
                komut.Parameters.AddWithValue("@tc", textBoxTc.Text);
                komut.Parameters.AddWithValue("@phone", textBoxTelefon.Text);
                komut.Parameters.AddWithValue("@email", textBoxMail.Text);
                komut.Parameters.AddWithValue("@adres", textBoxAdres.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız başarıyla oluşturulmuştur.");
            }
        }

        private void buttonCikis_Click(object sender, System.EventArgs e)
        {
            Application.Exit();

        }

        private void buttonGirisYap_Click(object sender, System.EventArgs e)
        {
            UserLogin giris = new UserLogin();
            giris.Show();
            this.Hide();
        }

        private void checkBoxGoster_CheckedChanged(object sender, System.EventArgs e)
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
