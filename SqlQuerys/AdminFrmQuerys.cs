using PlanlamaOyunuYazilimYapimi.Entitys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanlamaOyunuYazilimYapimi.SqlQuerys
{
    public class AdminFrmQuerys
    {
        public static string connectionSource = Properties.Settings.Default.SqlString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        List<Urun> urnlr = new List<Urun>();//ürün listesi
        List<Talep> prTlplr = new List<Talep>();//para talepleri listesi

        /*
         * ÜRÜN SORGULARI
         */
        public List<Urun> getUrunByUrunOnay(bool onay)//onay parametresine göre ürünleri döndürüyor
        {
            try
            {
                baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                SqlCommand komut = new SqlCommand("getUrunByUrunOnay", baglanti);//sorgumuz(stored prosedure kullandım)
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("onayDurumu", onay);
                SqlDataReader read = komut.ExecuteReader();//sorgudan dönen değerleri okuyor
                urnlr.Clear();
                while (read.Read())
                {
                    Urun urn = new Urun();
                    urn.urunID = Convert.ToInt32(read["urunID"]);
                    urn.kullaniciID = Convert.ToInt32(read["kullaniciID"]);
                    urn.kullaniciAdi = read["kullaniciAdi"].ToString();
                    urn.urunAdi = read["urunAdi"].ToString();
                    urn.urunKg = Convert.ToDouble(read["urunKg"]);
                    urn.urunFiyati = Convert.ToDouble(read["urunFiyati"]);
                    urn.urunOnay = Convert.ToBoolean(read["urunOnay"]);
                    urnlr.Add(urn);
                }
                baglanti.Close();
                return urnlr;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString(), "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public List<Urun> getAllUrun()//bütün ürünleri çekiyor
        {
            try
            {
                baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                SqlCommand komut = new SqlCommand("SELECT U.*,K.kullaniciAdi FROM tblUrun U LEFT JOIN " +
                    "tblKullanici K ON U.kullaniciID = K.kullaniciID", baglanti);//sorgumuz
                SqlDataReader read = komut.ExecuteReader();//sorgudan dönen değerleri okuyor
                urnlr.Clear();
                while (read.Read())
                {
                    Urun urn = new Urun();
                    urn.urunID = Convert.ToInt32(read["urunID"]);
                    urn.kullaniciID = Convert.ToInt32(read["kullaniciID"]);
                    urn.kullaniciAdi = read["kullaniciAdi"].ToString();
                    urn.urunAdi = read["urunAdi"].ToString();
                    urn.urunKg = Convert.ToDouble(read["urunKg"]);
                    urn.urunFiyati = Convert.ToDouble(read["urunFiyati"]);
                    urn.urunOnay = Convert.ToBoolean(read["urunOnay"]);
                    urnlr.Add(urn);
                }
                baglanti.Close();
                return urnlr;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString(), "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public void changeUrunOnay(int urunId, bool urunOnay)//parametre olarak gönderilen ürünId li ürünün parametre olarak gönderilen ürünOnayına göre veritabanında değişiklik yapılıyor
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE tblUrun SET urunOnay = @urunOnay where urunID = @urunId", baglanti);
                komut.Parameters.AddWithValue("@urunId", urunId);
                komut.Parameters.AddWithValue("@urunOnay", urunOnay);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString(), "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        /*
         * PARA TALEP SORGULARI
         */
        public List<Talep> getAllParaTalep()//bütün para taleplerini döndürüyor
        {
            try
            {
                baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                SqlCommand komut = new SqlCommand("SELECT T.*,K.kullaniciAdi FROM tblTalep T LEFT JOIN " +
                    "tblKullanici K ON T.kullaniciID = K.kullaniciID", baglanti);//sorgumuz
                SqlDataReader read = komut.ExecuteReader();//sorgudan dönen değerleri okuyor
                urnlr.Clear();
                while (read.Read())
                {
                    Talep prTlp = new Talep();
                    prTlp.talepId = Convert.ToInt32(read["talepId"]);
                    prTlp.kullaniciId = Convert.ToInt32(read["kullaniciID"]);
                    prTlp.kullaniciAdi = read["kullaniciAdi"].ToString();
                    prTlp.talepMiktari = Convert.ToDouble(read["talepMiktari"]);
                    prTlplr.Add(prTlp);
                }
                baglanti.Close();
                return prTlplr;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString(), "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public void confirmParaTalep(int talepId, string kullaniciAdi, double talepMiktari)//para talebi onaylama işlemleri
        {
            try
            {
                baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                SqlCommand komut = new SqlCommand("UPDATE tblKullanici SET bakiye = " +
                    "((SELECT bakiye FROM tblKullanici WHERE kullaniciAdi = @kullaniciAdi)+@talepMiktari) where kullaniciAdi = @kullaniciAdi", baglanti);//kullanıcının talep ettiği para kullanıcı bakiyesine ekleniyor
                komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                komut.Parameters.AddWithValue("@talepMiktari", talepMiktari);
                komut.ExecuteNonQuery();

                komut = new SqlCommand("DELETE FROM tblTalep WHERE talepID = @talepId", baglanti);//onaylanan talep talepler tablosundan siliniyor
                komut.Parameters.AddWithValue("@talepId", talepId);
                komut.ExecuteNonQuery();

                MessageBox.Show("Talep Onaylanmıştır.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString(), "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public void deleteParaTalepByTalepId(int talepId)//para talebi silme işlemi
        {
            try
            {
                baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                SqlCommand komut = new SqlCommand("DELETE FROM tblTalep WHERE talepID = @talepId", baglanti);//onaylanmayan para talebini siliyor
                komut.Parameters.AddWithValue("@talepId", talepId);
                komut.ExecuteNonQuery();
                MessageBox.Show("Talep Reddedilmiştir.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString(), "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
