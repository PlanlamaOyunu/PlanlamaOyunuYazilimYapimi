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
    public partial class SaticiMenuFrm : Form
    {
        public SaticiMenuFrm()
        {
            InitializeComponent();

        }
        SaticiSorgulari saticiSorgulari = new SaticiSorgulari();
        TextBoxKisitlama tbk = new TextBoxKisitlama();
        List<Urun> urnlr = new List<Urun>();
        List<SatinAlim> sprslr = new List<SatinAlim>();
        Urun selectedUrn = new Urun();


        private void SaticiMenuFrm_Load(object sender, EventArgs e)
        {
            urnlr = saticiSorgulari.urunlerim();
            dataGridViewUrunListele(urnlr, dtGrdViewYeniUrun);
            urnlr.Clear();
            urnlr = saticiSorgulari.onayliUrunlerim();
            dataGridViewUrunListele(urnlr, dtGrdViewUrunlerim);
            sprslr = saticiSorgulari.siparisler();
            dataGridViewSiparisListele(sprslr, dtGrdViewSiparisler);
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
        public void dataGridViewUrunListele(List<Urun> urnlr, DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < urnlr.Count; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = urnlr[i].urunID;
                dgv.Rows[i].Cells[1].Value = urnlr[i].urunAdi;
                dgv.Rows[i].Cells[2].Value = urnlr[i].urunKg;
                dgv.Rows[i].Cells[3].Value = urnlr[i].urunFiyati;
                dgv.Rows[i].Cells[4].Value = urnlr[i].urunOnay;
            }
        }
        public void dataGridViewSiparisListele(List<SatinAlim> sprslr, DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < sprslr.Count; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = sprslr[i].satinAlimID;
                dgv.Rows[i].Cells[1].Value = sprslr[i].aliciAdi;
                dgv.Rows[i].Cells[2].Value = sprslr[i].islemTarihi;
                dgv.Rows[i].Cells[3].Value = sprslr[i].islemDetay;
                dgv.Rows[i].Cells[4].Value = sprslr[i].islemTutari;
                dgv.Rows[i].Cells[5].Value = sprslr[i].urunBirimFiyati;
            }
        }

        private void btnUrunTalep_Click(object sender, EventArgs e)
        {
            if (cmbBoxUrunIsmi.Text == "" || txtBoxUrunKgFiyat.Text.Trim() == "" || txtBoxUrunKilo.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen boş kutucuk bırakmayınız!");
            }
            else
            {
                if (txtBoxUrunIsmi.Visible == true)
                {
                    saticiSorgulari.YeniUrunSatici(txtBoxUrunIsmi.Text, Convert.ToInt32(txtBoxUrunKilo.Text), Convert.ToDouble(txtBoxUrunKgFiyat.Text));
                }
                else
                {
                    saticiSorgulari.YeniUrunSatici(cmbBoxUrunIsmi.Text, Convert.ToInt32(txtBoxUrunKilo.Text), Convert.ToDouble(txtBoxUrunKgFiyat.Text));
                }
                urnlr.Clear();
                urnlr = saticiSorgulari.urunlerim();
                dataGridViewUrunListele(urnlr, dtGrdViewYeniUrun);
            }
        }

        private void cmbBoxUrunIsmi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxUrunIsmi.Text == "Diğer")
            {
                txtBoxUrunIsmi.Visible = true;
            }
            else
            {
                txtBoxUrunIsmi.Visible = false;
            }
        }

        private void btnSiparisListeYenile_Click(object sender, EventArgs e)
        {
            sprslr = saticiSorgulari.siparisler();
            dataGridViewSiparisListele(sprslr, dtGrdViewSiparisler);
        }

        private void btnUrunKaldir_Click(object sender, EventArgs e)
        {
            saticiSorgulari.UrunKaldir(selectedUrn.urunID);
            urnlr.Clear();
            urnlr = saticiSorgulari.urunlerim();
            dataGridViewUrunListele(urnlr, dtGrdViewYeniUrun);
            urnlr.Clear();
            urnlr = saticiSorgulari.onayliUrunlerim();
            dataGridViewUrunListele(urnlr, dtGrdViewUrunlerim);
        }

        private void dtGrdViewUrunlerim_SelectionChanged(object sender, EventArgs e)
        {
            if (dtGrdViewUrunlerim.SelectedRows.Count > 0)
            {
                if (dtGrdViewUrunlerim.CurrentRow.Cells[0].Value != null)
                {
                    selectedUrn.urunID = Convert.ToInt32(dtGrdViewUrunlerim.SelectedRows[0].Cells["urunId"].Value);
                }
            }
        }
    }
}




