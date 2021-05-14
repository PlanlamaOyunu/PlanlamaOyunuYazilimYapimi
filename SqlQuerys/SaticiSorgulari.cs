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
    public class SaticiSorgulari
    {
        public static string connectionSource = Properties.Settings.Default.SqlString;
        SqlConnection baglanti = new SqlConnection(connectionSource);

        public void YeniUrunSatici(string urunİsmi, int urunKilosu, double kgFiyati)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT tblUrun (kullaniciID,urunAdi,urunKg,urunFiyati,urunOnay) VALUES " + " (@kullaniciID,@urunAdi, @urunKg, @urunFiyati, 0)", baglanti);
            komut.Parameters.AddWithValue("@urunAdi", urunİsmi);
            komut.Parameters.AddWithValue("@urunKg", urunKilosu);
            komut.Parameters.AddWithValue("@urunFiyati", kgFiyati);
            komut.Parameters.AddWithValue("@kullaniciID", Properties.Settings.Default.kullaniciID);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarıyla Oluşturulmuştur.");
        }
        public void UrunKaldir(int urunId)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from tblUrun where urunID = @urunId", baglanti);
            komut.Parameters.AddWithValue("@urunId", urunId);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Silinmiştir.");
        }

        public List<Urun> urunlerim()
        {
            List<Urun> urnlr = new List<Urun>();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from tblUrun Where kullaniciID = @kullaniciId", baglanti);
                komut.Parameters.AddWithValue("kullaniciId", Properties.Settings.Default.kullaniciID);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Urun urn = new Urun();
                    urn.urunID = Convert.ToInt32(read["urunID"]);
                    urn.kullaniciID = Convert.ToInt32(read["kullaniciID"]);
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

        public List<Urun> onayliUrunlerim()
        {
            List<Urun> urnlr = new List<Urun>();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from tblUrun Where kullaniciID = @kullaniciId and urunOnay = 1", baglanti);
                komut.Parameters.AddWithValue("kullaniciId", Properties.Settings.Default.kullaniciID);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Urun urn = new Urun();
                    urn.urunID = Convert.ToInt32(read["urunID"]);
                    urn.kullaniciID = Convert.ToInt32(read["kullaniciID"]);
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
        public List<SatinAlim>siparisler()
        {
            List<SatinAlim> sprslr = new List<SatinAlim>();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT S.*,K.kullaniciAdi FROM tblSatinAlim S INNER JOIN" +
                    " tblKullanici K ON S.aliciID = K.kullaniciID and saticiID = @saticiId", baglanti);
                komut.Parameters.AddWithValue("saticiId", Properties.Settings.Default.kullaniciID);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    SatinAlim sprs = new SatinAlim();
                    sprs.satinAlimID = Convert.ToInt32(read["satinAlimID"]);
                    sprs.islemTarihi = read["islemTarihi"].ToString();
                    sprs.islemDetay = read["islemDetay"].ToString();
                    sprs.islemTutari = Convert.ToDouble(read["islemTutari"]);
                    sprs.islemDetay = read["islemDetay"].ToString();
                    sprs.urunBirimFiyati = Convert.ToDouble(read["urunBirimFiyati"]);
                    sprs.aliciAdi = read["kullaniciAdi"].ToString();
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
    }
}
