using PlanlamaOyunuYazilimYapimi.Forms;
using PlanlamaOyunuYazilimYapimi.SqlQuerys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanlamaOyunuYazilimYapimi
{
    public partial class GirisKayitFrm : Form
    {
        public GirisKayitFrm()
        {
            InitializeComponent();
        }

        GirisKayitFrmQuerys grsKytFrmQrys = new GirisKayitFrmQuerys();
        /*
         * GİRİŞ KISMI
         */
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtBoxGirisKullaniciAdi.Text.Trim() != "" && txtBoxGirisSifre.Text.Trim() != "")
            {
                try
                {
                    string yetki;
                    yetki = grsKytFrmQrys.girisKontrol(txtBoxGirisKullaniciAdi.Text.Trim(), txtBoxGirisSifre.Text.Trim());//giris kontrole gönderilen kullanıcı adı ve şifresine sahip kullanıcı var mı diye veritabanında sorgu yaptırıyoruz
                    if (yetki != null)//sorgudan bir sonuç çıkarsa if e giriyor
                    {
                        if (yetki == "ALICI")
                        {
                            //alıcı formuna yönlendirilecek
                            this.Hide();
                            AliciMenuFrm aliciMenuFrm = new AliciMenuFrm();
                            aliciMenuFrm.StartPosition = FormStartPosition.CenterScreen;
                            aliciMenuFrm.alici.kullaniciAdi = txtBoxGirisKullaniciAdi.Text;
                            aliciMenuFrm.Closed += (s, args) => this.Close();
                            aliciMenuFrm.Show();
                        }
                        else if (yetki == "SATICI")
                        {
                            //satıcı formuna yönlendirilecek
                            this.Hide();
                            SaticiMenuFrm saticiMenuFrm = new SaticiMenuFrm();
                            saticiMenuFrm.StartPosition = FormStartPosition.CenterScreen;
                            saticiMenuFrm.Closed += (s, args) => this.Close();
                            saticiMenuFrm.Show();
                        }
                        else if (yetki == "ADMİN")
                        {
                            //admin formuna yönlendirilecek
                            this.Hide();
                            AdminMenuFrm adminMenuFrm = new AdminMenuFrm();
                            adminMenuFrm.StartPosition = FormStartPosition.CenterScreen;
                            adminMenuFrm.Closed += (s, args) => this.Close();
                            adminMenuFrm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir kullanıcı mevcut değil veya şifreniz yanlış!", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.ToString());
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş kutucuk bırakmayınız.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /*
         * KAYIT KISMI
         */
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (txtBoxKayitAd.Text.Trim() == "" || txtBoxKayitSoyad.Text.Trim() == "" || txtBoxKayitKullaniciAdi.Text.Trim() == "" ||
                txtBoxKayitSifre.Text.Trim() == "" || txtBoxKayitTcNo.Text.Trim() == ""
                 || txtBoxKayitTelefonNo.Text.Trim() == "" || txtBoxKayitEmail.Text.Trim() == "" || txtBoxKayitAdres.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen boş kutucuk bırakmayınız!");
            }
            else
            {
                kayitOl();
            }
        }
        public void kayitOl()
        {

            if (grsKytFrmQrys.kayitKontrol(txtBoxKayitKullaniciAdi.Text.Trim(), txtBoxKayitTcNo.Text.Trim(), txtBoxKayitTelefonNo.Text.Trim(), txtBoxKayitEmail.Text.Trim()))//parametre olarak gönderilenler başka kullanıcıda aynı mı diye kontrol ediyor
            {
                string yetki = "";
                if (rBtnAlici.Checked)//alıcı olarak kayıt yapacaksak yetkiyi alıcı diye kaydediyor
                {
                    yetki = "ALICI";

                }
                else if (rBtnSatici.Checked)//satıcı olarak kayıt yapacaksak yetkiyi satıcı diye kaydediyor
                {
                    yetki = "SATICI";
                }
                //kayıt işlemi yaptırılıyor
                grsKytFrmQrys.kayitOl(txtBoxKayitAd.Text.Trim(), txtBoxKayitSoyad.Text.Trim(), txtBoxKayitKullaniciAdi.Text.Trim(), txtBoxKayitSifre.Text.Trim(),
                        txtBoxKayitTcNo.Text.Trim(), txtBoxKayitTelefonNo.Text.Trim(), txtBoxKayitEmail.Text.Trim(), txtBoxKayitAdres.Text.Trim(), yetki);
            }
            else
            {
                MessageBox.Show("Aynı Kullanıcı adı, TC No, Telefon No veya Email'e sahip kullanıcı mevcuttur.");
            }
        }
    }
}
