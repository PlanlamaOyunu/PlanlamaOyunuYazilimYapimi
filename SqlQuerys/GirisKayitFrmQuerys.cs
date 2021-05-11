using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanlamaOyunuYazilimYapimi.SqlQuerys
{
    public class GirisKayitFrmQuerys
    {
        public static string connectionSource = Properties.Settings.Default.SqlString;//properties bölümünden veritabanı bağlantı stringini alıyor
        SqlConnection baglanti = new SqlConnection(connectionSource);//sql bağlantısını tanımlıyoruz
        /*
         * GİRİŞ SORGULARI
         */
        public string girisKontrol(string kullaniciAdi, string sifre)
        {
            string yetki = null;
            try
            {
                baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                SqlCommand komut = new SqlCommand("Select * from tblKullanici where kullaniciAdi = @KullaniciAdi and sifre = @Sifre", baglanti);//sorgumuz
                komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);//parametreler
                komut.Parameters.AddWithValue("@Sifre", sifre);
                SqlDataReader read = komut.ExecuteReader();//sorgudan dönen değerleri okuyor
                while (read.Read())//eğer gönderdiğimiz kullanıcı adı ve sifresine sahip birisi var ise yetki değişkenini dolduruyor. yoksa yetki null kalıyor
                {
                    Properties.Settings.Default.kullaniciID = Convert.ToInt32(read["kullaniciID"]);//kullanıcıID yi diğer ekranlarda kullanmak için properties kısmına kaydettim
                    yetki = read["yetki"].ToString();
                }
                baglanti.Close();//veritabanı ile olan bağlantıyı kapatıyor
                return yetki;//yetki değişkenini ilk çağırdığımız yere döndürüyor
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }
        /*
         * KAYIT SORGULARI
         */
        public bool kayitKontrol(string kullaniciAdi, string tcNo, string telefonNo, string email)
        {
            bool izin = true;
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from tblKullanici where kullaniciAdi = @KullaniciAdi or tcNo = @tcNo or telefonNo = @telefonNo" +
                    " or email = @email", baglanti);
                komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                komut.Parameters.AddWithValue("@tcNo", tcNo);
                komut.Parameters.AddWithValue("@telefonNo", telefonNo);
                komut.Parameters.AddWithValue("@email", email);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    izin = false;
                }
                baglanti.Close();
                return izin;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                throw;
            }
        }

        public void kayitOl(string ad, string soyad, string kullaniciAdi, string sifre, string tcNo, string telefonNo, string email, string adres, string yetki)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO tblKullanici (ad,soyad,kullaniciAdi,sifre,tcNo,telefonNo,email,adres,yetki,bakiye) VALUES " +
                    "(@ad,@soyad,@kullaniciAdi,@sifre,@tcNo,@telefonNo,@email,@adres,@yetki,0)", baglanti);
                //sql sorgusuna parametre degerlerini yolluyoruz
                komut.Parameters.AddWithValue("@ad", ad);
                komut.Parameters.AddWithValue("@soyad", soyad);
                komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", sifre);
                komut.Parameters.AddWithValue("@tcNo", tcNo);
                komut.Parameters.AddWithValue("@telefonNo", telefonNo);
                komut.Parameters.AddWithValue("@email", email);
                komut.Parameters.AddWithValue("@adres", adres);
                komut.Parameters.AddWithValue("@yetki", yetki);
                komut.ExecuteNonQuery();//sogruyu execute ediyoruz
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Oluşturulmuştur.");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
