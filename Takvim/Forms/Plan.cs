using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System;

namespace Takvim.Forms
{
    public partial class Plan : Form
    {


        public Plan()
        {
            InitializeComponent();
            // Güncel saati al
            DateTime currentDate = DateTime.Now;
            Classes.SqlBaglantisi sql = new Classes.SqlBaglantisi();

            // TextBox kontrolüne güncel tarihi yaz
            textBoxZaman.Text = currentDate.ToString("dd.MM.yyyy");

            DataSet ds = new DataSet();
            string sql2 = "select * from calendar where day = '" + Classes.Calendar.day + "'and userId = '" + Classes.KullaniciBilgileri.userId + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql2, sql.baglan());
            ds = new DataSet();
            da.Fill(ds, "KULLANICIDENEME");
            //con.Close();

            if (ds.Tables[0].Rows.Count > 0)
            {
                // burada giren kullanıcının bilgilerini veritabnından çekiyoruz
                string dateTimetxt = ds.Tables[0].Rows[0]["dateTime"].ToString();
                string startHourtxt = ds.Tables[0].Rows[0]["startHour"].ToString();
                string endHourtxt = ds.Tables[0].Rows[0]["endHour"].ToString();
                string eventTypetxt = ds.Tables[0].Rows[0]["eventType"].ToString();
                string detailstxt = ds.Tables[0].Rows[0]["details"].ToString();
                string tanimtxt = ds.Tables[0].Rows[0]["tanim"].ToString();


                // burada veritabanından çektiğimiz bilgileri class'a ekliyoruz
                textBoxZaman.Text = dateTimetxt;
                textBoxBaslangic.Text = startHourtxt;
                textBoxbitis.Text = endHourtxt;
                textBoxTanım.Text = tanimtxt;
                textBoxDetay.Text = eventTypetxt;
                textBoxTip.Text = eventTypetxt;



            }
        }

            private void buttonOk_Click(object sender, EventArgs e)
        {
            Classes.SqlBaglantisi sql = new Classes.SqlBaglantisi();


            // eğer tüm bilgileri girmişse bu bilgiler veritabanına kaydediliyor
            string sorgu = "insert into calendar(dateTime,startHour,endHour,eventType,details,userId,day)values(@dateTime,@startHour,@endHour,@eventType,@details,@userId,@day)";
                SqlCommand komut = new SqlCommand(sorgu, sql.baglan());

                komut.Parameters.AddWithValue("@dateTime", textBoxZaman.Text);
                komut.Parameters.AddWithValue("@startHour", textBoxBaslangic.Text);
                komut.Parameters.AddWithValue("@endHour", textBoxbitis.Text);
                komut.Parameters.AddWithValue("@eventType", textBoxTip.Text);
                komut.Parameters.AddWithValue("@details", textBoxTanım.Text);
                komut.Parameters.AddWithValue("@userId", Classes.KullaniciBilgileri.userId);
                komut.Parameters.AddWithValue("@day", Classes.Calendar.day);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız başarıyla oluşturulmuştur.");

            }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
            this.Hide();
        }

        private void buttonOk_Click_1(object sender, EventArgs e)
        {
            Classes.SqlBaglantisi sql = new Classes.SqlBaglantisi();


            // eğer tüm bilgileri girmişse bu bilgiler veritabanına kaydediliyor
            string sorgu = "insert into calendar(dateTime,startHour,endHour,eventType,details,userId,day,tanim)values(@dateTime,@startHour,@endHour,@eventType,@details,@userId,@day,@tanim)";
            SqlCommand komut = new SqlCommand(sorgu, sql.baglan());

            komut.Parameters.AddWithValue("@dateTime", textBoxZaman.Text);
            komut.Parameters.AddWithValue("@startHour", textBoxBaslangic.Text);
            komut.Parameters.AddWithValue("@endHour", textBoxbitis.Text);
            komut.Parameters.AddWithValue("@eventType", textBoxTip.Text);
            komut.Parameters.AddWithValue("@details", textBoxDetay.Text);
            komut.Parameters.AddWithValue("@userId", Classes.KullaniciBilgileri.userId);
            komut.Parameters.AddWithValue("@day", Classes.Calendar.day);
            komut.Parameters.AddWithValue("@tanim", textBoxTanım.Text);


            komut.ExecuteNonQuery();
            MessageBox.Show("Kaydınız başarıyla oluşturulmuştur.");
        }

        private void labelMail_Click(object sender, EventArgs e)
        {

        }
    }
    }

