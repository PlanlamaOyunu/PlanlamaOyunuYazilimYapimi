using PlanlamaOyunuYazilimYapimi.Entitys;
using PlanlamaOyunuYazilimYapimi.Functions;
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

namespace PlanlamaOyunuYazilimYapimi.Forms
{
    public partial class AliciMenuFrm : Form
    {
        public AliciMenuFrm()
        {
            InitializeComponent();
        }
        AliciSorgulari aliciSorgulari = new AliciSorgulari();
        TextBoxKisitlama tbk = new TextBoxKisitlama();
        Urun selectedUrn = new Urun();
        List<Urun> urnlr = new List<Urun>();
        List<Talep> bkytlplr = new List<Talep>();
        List<SatinAlim> sprslr = new List<SatinAlim>();
        public Kullanici alici = new Kullanici();
        private void AliciMenuFrm_Load(object sender, EventArgs e)
        {
            urnlr = aliciSorgulari.urunler();
            dataGridViewUrunListele(urnlr, dtGrdViewUrunler);
            bkytlplr = aliciSorgulari.bakiyeTalepleri();
            dataGridViewBakiyeTalepListele(bkytlplr, dtGrdViewBakiyeOnay);
            sprslr = aliciSorgulari.gecmisSiparisler();
            dataGridViewSiparisListele(sprslr, dtGrdViewGecmisSiparisler);
            alici.bakiye = aliciSorgulari.bakiyeSorgulama();
            lblBakiyeParaEkleme.Text = alici.bakiye.ToString() + " TL";
            lblBakiyeSatinAlma.Text = alici.bakiye.ToString() + " TL";
        }
        private void txtBox_Enter(object sender, EventArgs e)
        {
            tbk.txtBox_Enter(sender, e);
        }
        private void txtBox_Leave(object sender, EventArgs e)
        {
            tbk.txtBox_Leave(sender, e);
        }
        public void onlyFloatValue(object sender, KeyPressEventArgs e)
        {
            tbk.onlyFloatValue(sender, e);
        }
        /*
         * ÜRÜN SATIN ALMA
         */
        private void btnUrunListeYenile_Click(object sender, EventArgs e)
        {
            urnlr = aliciSorgulari.urunler();
            dataGridViewUrunListele(urnlr, dtGrdViewUrunler);
        }
        private void dataGridViewUrunListele(List<Urun> urnlr, DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < urnlr.Count; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = urnlr[i].urunID;
                dgv.Rows[i].Cells[1].Value = urnlr[i].urunAdi;
                dgv.Rows[i].Cells[2].Value = urnlr[i].urunKg;
                dgv.Rows[i].Cells[3].Value = urnlr[i].urunFiyati;
            }
        }
        private void dtGrdViewUrunler_SelectionChanged(object sender, EventArgs e)
        {
            if (dtGrdViewUrunler.SelectedRows.Count > 0)
            {
                if (dtGrdViewUrunler.CurrentRow.Cells[3].Value != null)
                {
                    selectedUrn.urunID = Convert.ToInt32(dtGrdViewUrunler.SelectedRows[0].Cells["urunID"].Value);
                    selectedUrn.urunKg = Convert.ToDouble(dtGrdViewUrunler.SelectedRows[0].Cells["urunKg"].Value);
                    selectedUrn.urunFiyati = Convert.ToDouble(dtGrdViewUrunler.SelectedRows[0].Cells["urunBirimFiyat"].Value);
                    lblUrunKgFiyati.Text = selectedUrn.urunFiyati.ToString() + " TL";
                    txtBoxAlinacakMiktar_TextChanged(null, null);
                }
            }
        }
        double tutar = 0;
        private void txtBoxAlinacakMiktar_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxAlinacakMiktar.Text.Trim() != "," && txtBoxAlinacakMiktar.Text.Trim() != "")
            {
                tutar = Math.Round((Convert.ToDouble(txtBoxAlinacakMiktar.Text.Trim()) * selectedUrn.urunFiyati), 2);
                lblOdenecekTutar.Text = tutar.ToString() + " TL";
            }
        }
        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            double stok = Convert.ToDouble(dtGrdViewUrunler.SelectedRows[0].Cells["urunKg"].Value);
            if (stok >= Convert.ToDouble(txtBoxAlinacakMiktar.Text) && Convert.ToDouble(txtBoxAlinacakMiktar.Text) > 0)
            {
                aliciSorgulari.satinAlim(selectedUrn.urunID, tutar, Convert.ToDouble(txtBoxAlinacakMiktar.Text), selectedUrn.urunFiyati);
                lblBakiyeParaEkleme.Text = (Convert.ToDouble(lblBakiyeParaEkleme.Text.Split(' ')[0]) - tutar).ToString() + " TL";
                lblBakiyeSatinAlma.Text = (Convert.ToDouble(lblBakiyeSatinAlma.Text.Split(' ')[0]) - tutar).ToString() + " TL";
                urnlr = aliciSorgulari.urunler();
                dataGridViewUrunListele(urnlr, dtGrdViewUrunler);
                sprslr = aliciSorgulari.gecmisSiparisler();
                dataGridViewSiparisListele(sprslr, dtGrdViewGecmisSiparisler);
            }
            else
            {
                MessageBox.Show("Talep ettiğiniz ürün miktarı stokta mevcut değil veya geçerli bir miktar girmediniz!\nLütfen geçerli bir miktar giriniz.");
            }
        }
        /*
         * PARA EKLEME
         */
        private void btnParaEkle_Click(object sender, EventArgs e)
        {
            if (txt_ekleBakiye.Text == "0" || txt_ekleBakiye.Text.Trim() == "")
            {
                MessageBox.Show("Geçerli Bir Değer Giriniz!");
            }
            else
            {
                aliciSorgulari.bakiyeTalep(Convert.ToDouble(txt_ekleBakiye.Text));
                bkytlplr = aliciSorgulari.bakiyeTalepleri();
                dataGridViewBakiyeTalepListele(bkytlplr, dtGrdViewBakiyeOnay);
            }
        }
        private void dataGridViewBakiyeTalepListele(List<Talep> bkytlplr, DataGridView dgv1)
        {
            dgv1.Rows.Clear();
            for (int i = 0; i < bkytlplr.Count; i++)
            {
                dgv1.Rows.Add();
                dgv1.Rows[i].Cells[0].Value = bkytlplr[i].talepId;
                dgv1.Rows[i].Cells[1].Value = bkytlplr[i].talepTarihi;
                dgv1.Rows[i].Cells[2].Value = bkytlplr[i].talepMiktari;
            }
        }
        /*
         * GEÇMİŞ SİPARİŞLERİM
         */
        private void dataGridViewSiparisListele(List<SatinAlim> sprslr, DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < sprslr.Count; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = sprslr[i].satinAlimID;
                dgv.Rows[i].Cells[1].Value = sprslr[i].saticiAdi;
                dgv.Rows[i].Cells[2].Value = sprslr[i].islemTarihi;
                dgv.Rows[i].Cells[3].Value = sprslr[i].islemDetay;
                dgv.Rows[i].Cells[4].Value = sprslr[i].islemTutari;
                dgv.Rows[i].Cells[5].Value = sprslr[i].alicininKalanParasi;
                dgv.Rows[i].Cells[6].Value = sprslr[i].urunBirimFiyati;
            }
        }

       
    }
}