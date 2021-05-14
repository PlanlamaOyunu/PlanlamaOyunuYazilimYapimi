using PlanlamaOyunuYazilimYapimi.Entitys;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanlamaOyunuYazilimYapimi.SqlQuerys
{
    public class AliciSorgulari
    {
        public static string connectionSource = Properties.Settings.Default.SqlString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        public List<Urun> urunler()
        {
            List<Urun> urnlr = new List<Urun>();
            try
            {
                baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                SqlCommand komut = new SqlCommand("Select * from tblUrun where urunOnay = 1", baglanti);//sorgumuz
                SqlDataReader read = komut.ExecuteReader();//sorgudan dönen değerleri okuyor
                while (read.Read())
                {
                    Urun urn = new Urun();
                    urn.urunID = Convert.ToInt32(read["urunID"]);
                    urn.urunAdi = read["urunAdi"].ToString();
                    urn.urunKg = Convert.ToDouble(read["urunKg"]);
                    urn.urunFiyati = Convert.ToDouble(read["urunFiyati"]);
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

        public List<Talep> bakiyeTalepleri()
        {
            List<Talep> bkytlplr = new List<Talep>();
            try
            {
                baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                SqlCommand komut = new SqlCommand("SELECT T.*,K.kullaniciAdi FROM tblKullanici K INNER JOIN" +
                    " tblTalep T ON T.kullaniciID = K.kullaniciID AND T.kullaniciID = @kullaniciId", baglanti);//sorgumuz
                komut.Parameters.AddWithValue("kullaniciId", Properties.Settings.Default.kullaniciID);
                SqlDataReader read = komut.ExecuteReader();//sorgudan dönen değerleri okuyor

                while (read.Read())
                {
                    Talep bkytlp = new Talep();
                    bkytlp.talepId = Convert.ToInt32(read["talepId"]);
                    bkytlp.talepTarihi = read["talepTarihi"].ToString();
                    bkytlp.talepMiktari = Convert.ToDouble(read["talepMiktari"]);
                    bkytlplr.Add(bkytlp);
                }
                baglanti.Close();
                return bkytlplr;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString(), "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public double bakiyeSorgulama()
        {
            try
            {
                baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                SqlCommand komut = new SqlCommand("Select * From tblKullanici Where kullaniciID = @kullaniciId ", baglanti);//sorgumuz
                komut.Parameters.AddWithValue("kullaniciId", Properties.Settings.Default.kullaniciID);
                SqlDataReader read = komut.ExecuteReader();//sorgudan dönen değerleri okuyor
                read.Read();
                double bky = Convert.ToDouble(read["bakiye"]);
                baglanti.Close();
                return bky;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString(), "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        public void bakiyeTalep(double yeniBakiye)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT tblTalep (kullaniciID,talepMiktari,talepTarihi) VALUES " + "(@kullaniciId,@talepMiktari,GETDATE())", baglanti);
                komut.Parameters.AddWithValue("@talepMiktari", yeniBakiye);
                komut.Parameters.AddWithValue("@kullaniciId", Properties.Settings.Default.kullaniciID);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Başarıyla Oluşturulmuştur.");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString(), "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
        public List<SatinAlim> gecmisSiparisler()
        {
            List<SatinAlim> sprslr = new List<SatinAlim>();
            try
            {
                baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                SqlCommand komut = new SqlCommand("SELECT S.*,K.kullaniciAdi FROM tblSatinAlim S INNER JOIN" +
                    " tblKullanici K ON S.saticiID = K.kullaniciID and aliciID = @aliciId", baglanti);//sorgumuz
                komut.Parameters.AddWithValue("aliciId", Properties.Settings.Default.kullaniciID);
                SqlDataReader read = komut.ExecuteReader();//sorgudan dönen değerleri okuyor
                while (read.Read())
                {
                    SatinAlim sprs = new SatinAlim();
                    sprs.satinAlimID = Convert.ToInt32(read["satinAlimID"]);
                    sprs.islemTarihi = read["islemTarihi"].ToString();
                    sprs.islemDetay = read["islemDetay"].ToString();
                    sprs.islemTutari = Convert.ToDouble(read["islemTutari"]);
                    sprs.alicininKalanParasi = Convert.ToDouble(read["alicininKalanParasi"]);
                    sprs.urunBirimFiyati = Convert.ToDouble(read["urunBirimFiyati"]);
                    sprs.saticiAdi = read["kullaniciAdi"].ToString();
                    sprslr.Add(sprs);
                }
                baglanti.Close();
                return sprslr;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString(), "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void satinAlim(int urunId, double tutar, double alinanUrunMiktari, double urunBirimFiyati)
        {
            try
            {
                baglanti.Open();//veritabanı ile olan bağlantıyı açıyor
                SqlCommand komut = new SqlCommand("UPDATE tblUrun SET urunKg = " +
                    "((SELECT urunKg FROM tblUrun WHERE urunID = @urunId)-@alinanUrunMiktari) where urunID = @urunId", baglanti);//sorgumuz
                komut.Parameters.AddWithValue("@urunId", urunId);
                komut.Parameters.AddWithValue("@alinanUrunMiktari", alinanUrunMiktari);
                komut.ExecuteNonQuery();

                komut = new SqlCommand("UPDATE tblKullanici SET bakiye = " +
                    "((SELECT bakiye FROM tblKullanici WHERE kullaniciID = @kullaniciId)-@urunTutar) where kullaniciID = @kullaniciId", baglanti);//sorgumuz
                komut.Parameters.AddWithValue("@kullaniciId", Properties.Settings.Default.kullaniciID);
                komut.Parameters.AddWithValue("@urunTutar", tutar);
                komut.ExecuteNonQuery();

                komut = new SqlCommand("UPDATE tblKullanici SET bakiye = " +
                    "((SELECT bakiye FROM tblKullanici WHERE kullaniciID = (select kullaniciID From tblUrun where urunID = @urunId))+@urunTutar) " +
                    "where kullaniciID = (select kullaniciID From tblUrun where urunID = @urunId)", baglanti);//sorgumuz
                komut.Parameters.AddWithValue("@urunId", urunId);
                komut.Parameters.AddWithValue("@urunTutar", tutar);
                komut.ExecuteNonQuery();

                komut = new SqlCommand("INSERT tblSatinAlim (aliciID,saticiID,islemTarihi,islemDetay,islemTutari,alicininKalanParasi,urunBirimFiyati) VALUES " +
                    "(@aliciId, " +
                    "(select kullaniciID From tblUrun where urunID = @urunId), " +
                    "GETDATE(), " +
                    "((select kullaniciAdi From tblKullanici where kullaniciID = @aliciId) + ', ' + (SELECT kullaniciAdi FROM tblKullanici WHERE kullaniciID = (select kullaniciID From tblUrun where urunID = @urunId)) +' isimli kullanıcıdan ' + @alinanUrunMiktari + 'Kg ' + (select urunAdi from tblUrun where urunID = @urunId) +' almıştır. İşlem tutarı ' + @islemTutariString + 'TL dir.'), " +
                    "@islemTutari, " +
                    "(SELECT bakiye FROM tblKullanici WHERE kullaniciID = @aliciId), " +
                    "@urunBirimFiyati)", baglanti);
                komut.Parameters.AddWithValue("@aliciId", Properties.Settings.Default.kullaniciID);
                komut.Parameters.AddWithValue("@urunId", urunId);
                komut.Parameters.AddWithValue("@islemTutari", tutar);
                komut.Parameters.AddWithValue("@islemTutariString", tutar.ToString());
                komut.Parameters.AddWithValue("@alinanUrunMiktari", alinanUrunMiktari.ToString());
                komut.Parameters.AddWithValue("@urunBirimFiyati", urunBirimFiyati);
                komut.ExecuteNonQuery();

                MessageBox.Show("Satın alma başarıyla gerçekleşmiştir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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