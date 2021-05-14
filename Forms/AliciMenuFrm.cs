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

        private void InitializeComponent()
        {
            this.tabCntrlAliciFrm = new System.Windows.Forms.TabControl();
            this.tabPageUrunAlim = new System.Windows.Forms.TabPage();
            this.btnUrunListeYenile = new System.Windows.Forms.Button();
            this.lblUrunKgFiyati = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtGrdViewUrunler = new System.Windows.Forms.DataGridView();
            this.urunID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBakiyeSatinAlma = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblOdenecekTutar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxAlinacakMiktar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageParaEkleme = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dtGrdViewBakiyeOnay = new System.Windows.Forms.DataGridView();
            this.talepID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talepTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talepMiktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnParaEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ekleBakiye = new System.Windows.Forms.TextBox();
            this.lblBakiyeParaEkleme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageGecmisIslemler = new System.Windows.Forms.TabPage();
            this.dtGrdViewGecmisSiparisler = new System.Windows.Forms.DataGridView();
            this.siparisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saticiAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemDetay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemTutari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alicininKalanParasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBirimFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCntrlAliciFrm.SuspendLayout();
            this.tabPageUrunAlim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewUrunler)).BeginInit();
            this.tabPageParaEkleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewBakiyeOnay)).BeginInit();
            this.tabPageGecmisIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewGecmisSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCntrlAliciFrm
            // 
            this.tabCntrlAliciFrm.Controls.Add(this.tabPageUrunAlim);
            this.tabCntrlAliciFrm.Controls.Add(this.tabPageParaEkleme);
            this.tabCntrlAliciFrm.Controls.Add(this.tabPageGecmisIslemler);
            this.tabCntrlAliciFrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCntrlAliciFrm.Location = new System.Drawing.Point(0, 0);
            this.tabCntrlAliciFrm.Margin = new System.Windows.Forms.Padding(4);
            this.tabCntrlAliciFrm.Name = "tabCntrlAliciFrm";
            this.tabCntrlAliciFrm.SelectedIndex = 0;
            this.tabCntrlAliciFrm.Size = new System.Drawing.Size(1249, 550);
            this.tabCntrlAliciFrm.TabIndex = 1;
            // 
            // tabPageUrunAlim
            // 
            this.tabPageUrunAlim.AutoScroll = true;
            this.tabPageUrunAlim.Controls.Add(this.btnUrunListeYenile);
            this.tabPageUrunAlim.Controls.Add(this.lblUrunKgFiyati);
            this.tabPageUrunAlim.Controls.Add(this.label10);
            this.tabPageUrunAlim.Controls.Add(this.dtGrdViewUrunler);
            this.tabPageUrunAlim.Controls.Add(this.lblBakiyeSatinAlma);
            this.tabPageUrunAlim.Controls.Add(this.label9);
            this.tabPageUrunAlim.Controls.Add(this.lblOdenecekTutar);
            this.tabPageUrunAlim.Controls.Add(this.label7);
            this.tabPageUrunAlim.Controls.Add(this.txtBoxAlinacakMiktar);
            this.tabPageUrunAlim.Controls.Add(this.label6);
            this.tabPageUrunAlim.Controls.Add(this.btnSatinAl);
            this.tabPageUrunAlim.Controls.Add(this.label5);
            this.tabPageUrunAlim.Location = new System.Drawing.Point(4, 25);
            this.tabPageUrunAlim.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageUrunAlim.Name = "tabPageUrunAlim";
            this.tabPageUrunAlim.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageUrunAlim.Size = new System.Drawing.Size(1241, 521);
            this.tabPageUrunAlim.TabIndex = 0;
            this.tabPageUrunAlim.Text = "Ürün Satın Alma";
            this.tabPageUrunAlim.UseVisualStyleBackColor = true;
            // 
            // btnUrunListeYenile
            // 
            this.btnUrunListeYenile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunListeYenile.ImageKey = "synchronize_96px(mavi).png";
            this.btnUrunListeYenile.Location = new System.Drawing.Point(995, 4);
            this.btnUrunListeYenile.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunListeYenile.Name = "btnUrunListeYenile";
            this.btnUrunListeYenile.Size = new System.Drawing.Size(48, 36);
            this.btnUrunListeYenile.TabIndex = 12;
            this.btnUrunListeYenile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunListeYenile.UseVisualStyleBackColor = true;
            // 
            // lblUrunKgFiyati
            // 
            this.lblUrunKgFiyati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrunKgFiyati.AutoSize = true;
            this.lblUrunKgFiyati.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrunKgFiyati.Location = new System.Drawing.Point(1090, 81);
            this.lblUrunKgFiyati.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrunKgFiyati.Name = "lblUrunKgFiyati";
            this.lblUrunKgFiyati.Size = new System.Drawing.Size(19, 21);
            this.lblUrunKgFiyati.TabIndex = 11;
            this.lblUrunKgFiyati.Text = "0";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(844, 81);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ürün Kg Fiyatı:";
            // 
            // dtGrdViewUrunler
            // 
            this.dtGrdViewUrunler.AllowUserToAddRows = false;
            this.dtGrdViewUrunler.AllowUserToDeleteRows = false;
            this.dtGrdViewUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunID,
            this.urunAdi,
            this.urunKg,
            this.urunBirimFiyat});
            this.dtGrdViewUrunler.Location = new System.Drawing.Point(15, 42);
            this.dtGrdViewUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.dtGrdViewUrunler.Name = "dtGrdViewUrunler";
            this.dtGrdViewUrunler.ReadOnly = true;
            this.dtGrdViewUrunler.RowHeadersWidth = 51;
            this.dtGrdViewUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewUrunler.Size = new System.Drawing.Size(806, 473);
            this.dtGrdViewUrunler.TabIndex = 9;
            // 
            // urunID
            // 
            this.urunID.HeaderText = "Ürün ID";
            this.urunID.MinimumWidth = 6;
            this.urunID.Name = "urunID";
            this.urunID.ReadOnly = true;
            // 
            // urunAdi
            // 
            this.urunAdi.HeaderText = "Ürün Adı";
            this.urunAdi.MinimumWidth = 6;
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.ReadOnly = true;
            // 
            // urunKg
            // 
            this.urunKg.HeaderText = "Stoktaki Ürün Miktarı (Kg)";
            this.urunKg.MinimumWidth = 6;
            this.urunKg.Name = "urunKg";
            this.urunKg.ReadOnly = true;
            // 
            // urunBirimFiyat
            // 
            this.urunBirimFiyat.HeaderText = "Ürün Kg Fiyatı (TL)";
            this.urunBirimFiyat.MinimumWidth = 6;
            this.urunBirimFiyat.Name = "urunBirimFiyat";
            this.urunBirimFiyat.ReadOnly = true;
            // 
            // lblBakiyeSatinAlma
            // 
            this.lblBakiyeSatinAlma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBakiyeSatinAlma.AutoSize = true;
            this.lblBakiyeSatinAlma.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBakiyeSatinAlma.Location = new System.Drawing.Point(928, 4);
            this.lblBakiyeSatinAlma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBakiyeSatinAlma.Name = "lblBakiyeSatinAlma";
            this.lblBakiyeSatinAlma.Size = new System.Drawing.Size(38, 19);
            this.lblBakiyeSatinAlma.TabIndex = 8;
            this.lblBakiyeSatinAlma.Text = "0 TL";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(844, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Bakiye:";
            // 
            // lblOdenecekTutar
            // 
            this.lblOdenecekTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOdenecekTutar.AutoSize = true;
            this.lblOdenecekTutar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdenecekTutar.Location = new System.Drawing.Point(1090, 119);
            this.lblOdenecekTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdenecekTutar.Name = "lblOdenecekTutar";
            this.lblOdenecekTutar.Size = new System.Drawing.Size(19, 21);
            this.lblOdenecekTutar.TabIndex = 6;
            this.lblOdenecekTutar.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(844, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ödenecek Tutar:";
            // 
            // txtBoxAlinacakMiktar
            // 
            this.txtBoxAlinacakMiktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAlinacakMiktar.Location = new System.Drawing.Point(1094, 41);
            this.txtBoxAlinacakMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAlinacakMiktar.Name = "txtBoxAlinacakMiktar";
            this.txtBoxAlinacakMiktar.Size = new System.Drawing.Size(132, 22);
            this.txtBoxAlinacakMiktar.TabIndex = 4;
            this.txtBoxAlinacakMiktar.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(844, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Alınacak ürün miktarı (Kg):";
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSatinAl.Location = new System.Drawing.Point(1094, 154);
            this.btnSatinAl.Margin = new System.Windows.Forms.Padding(4);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(133, 28);
            this.btnSatinAl.TabIndex = 2;
            this.btnSatinAl.Text = "Satın Al";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(11, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ürünler:";
            // 
            // tabPageParaEkleme
            // 
            this.tabPageParaEkleme.Controls.Add(this.label4);
            this.tabPageParaEkleme.Controls.Add(this.dtGrdViewBakiyeOnay);
            this.tabPageParaEkleme.Controls.Add(this.btnParaEkle);
            this.tabPageParaEkleme.Controls.Add(this.label3);
            this.tabPageParaEkleme.Controls.Add(this.txt_ekleBakiye);
            this.tabPageParaEkleme.Controls.Add(this.lblBakiyeParaEkleme);
            this.tabPageParaEkleme.Controls.Add(this.label1);
            this.tabPageParaEkleme.Location = new System.Drawing.Point(4, 25);
            this.tabPageParaEkleme.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageParaEkleme.Name = "tabPageParaEkleme";
            this.tabPageParaEkleme.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageParaEkleme.Size = new System.Drawing.Size(1226, 635);
            this.tabPageParaEkleme.TabIndex = 1;
            this.tabPageParaEkleme.Text = "Para Ekleme";
            this.tabPageParaEkleme.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(97, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Beklenen Para Talepleri:";
            // 
            // dtGrdViewBakiyeOnay
            // 
            this.dtGrdViewBakiyeOnay.AllowUserToAddRows = false;
            this.dtGrdViewBakiyeOnay.AllowUserToDeleteRows = false;
            this.dtGrdViewBakiyeOnay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewBakiyeOnay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.talepID,
            this.talepTarihi,
            this.talepMiktari});
            this.dtGrdViewBakiyeOnay.Location = new System.Drawing.Point(101, 182);
            this.dtGrdViewBakiyeOnay.Margin = new System.Windows.Forms.Padding(4);
            this.dtGrdViewBakiyeOnay.Name = "dtGrdViewBakiyeOnay";
            this.dtGrdViewBakiyeOnay.ReadOnly = true;
            this.dtGrdViewBakiyeOnay.RowHeadersWidth = 51;
            this.dtGrdViewBakiyeOnay.Size = new System.Drawing.Size(900, 330);
            this.dtGrdViewBakiyeOnay.TabIndex = 5;
            // 
            // talepID
            // 
            this.talepID.HeaderText = "Talep ID";
            this.talepID.MinimumWidth = 6;
            this.talepID.Name = "talepID";
            this.talepID.ReadOnly = true;
            this.talepID.Width = 125;
            // 
            // talepTarihi
            // 
            this.talepTarihi.HeaderText = "Talep Tarihi";
            this.talepTarihi.MinimumWidth = 6;
            this.talepTarihi.Name = "talepTarihi";
            this.talepTarihi.ReadOnly = true;
            this.talepTarihi.Width = 125;
            // 
            // talepMiktari
            // 
            this.talepMiktari.HeaderText = "Talep Miktarı";
            this.talepMiktari.MinimumWidth = 6;
            this.talepMiktari.Name = "talepMiktari";
            this.talepMiktari.ReadOnly = true;
            this.talepMiktari.Width = 125;
            // 
            // btnParaEkle
            // 
            this.btnParaEkle.Location = new System.Drawing.Point(493, 110);
            this.btnParaEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnParaEkle.Name = "btnParaEkle";
            this.btnParaEkle.Size = new System.Drawing.Size(123, 25);
            this.btnParaEkle.TabIndex = 4;
            this.btnParaEkle.Text = "Ekle";
            this.btnParaEkle.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(97, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Eklenecek Tutar:";
            // 
            // txt_ekleBakiye
            // 
            this.txt_ekleBakiye.Location = new System.Drawing.Point(324, 110);
            this.txt_ekleBakiye.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ekleBakiye.Name = "txt_ekleBakiye";
            this.txt_ekleBakiye.Size = new System.Drawing.Size(132, 22);
            this.txt_ekleBakiye.TabIndex = 2;
            this.txt_ekleBakiye.Text = "0";
            // 
            // lblBakiyeParaEkleme
            // 
            this.lblBakiyeParaEkleme.AutoSize = true;
            this.lblBakiyeParaEkleme.Location = new System.Drawing.Point(320, 78);
            this.lblBakiyeParaEkleme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBakiyeParaEkleme.Name = "lblBakiyeParaEkleme";
            this.lblBakiyeParaEkleme.Size = new System.Drawing.Size(16, 17);
            this.lblBakiyeParaEkleme.TabIndex = 1;
            this.lblBakiyeParaEkleme.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mevcut Bakiyeniz(TL):";
            // 
            // tabPageGecmisIslemler
            // 
            this.tabPageGecmisIslemler.Controls.Add(this.dtGrdViewGecmisSiparisler);
            this.tabPageGecmisIslemler.Location = new System.Drawing.Point(4, 25);
            this.tabPageGecmisIslemler.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageGecmisIslemler.Name = "tabPageGecmisIslemler";
            this.tabPageGecmisIslemler.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageGecmisIslemler.Size = new System.Drawing.Size(1226, 635);
            this.tabPageGecmisIslemler.TabIndex = 2;
            this.tabPageGecmisIslemler.Text = "Geçmiş Siparişlerim";
            this.tabPageGecmisIslemler.UseVisualStyleBackColor = true;
            // 
            // dtGrdViewGecmisSiparisler
            // 
            this.dtGrdViewGecmisSiparisler.AllowUserToAddRows = false;
            this.dtGrdViewGecmisSiparisler.AllowUserToDeleteRows = false;
            this.dtGrdViewGecmisSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewGecmisSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewGecmisSiparisler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siparisId,
            this.saticiAdi,
            this.islemTarihi,
            this.islemDetay,
            this.islemTutari,
            this.alicininKalanParasi,
            this.urunBirimFiyati});
            this.dtGrdViewGecmisSiparisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrdViewGecmisSiparisler.Location = new System.Drawing.Point(4, 4);
            this.dtGrdViewGecmisSiparisler.Margin = new System.Windows.Forms.Padding(4);
            this.dtGrdViewGecmisSiparisler.MultiSelect = false;
            this.dtGrdViewGecmisSiparisler.Name = "dtGrdViewGecmisSiparisler";
            this.dtGrdViewGecmisSiparisler.ReadOnly = true;
            this.dtGrdViewGecmisSiparisler.RowHeadersWidth = 51;
            this.dtGrdViewGecmisSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewGecmisSiparisler.Size = new System.Drawing.Size(1218, 627);
            this.dtGrdViewGecmisSiparisler.TabIndex = 0;
            // 
            // siparisId
            // 
            this.siparisId.HeaderText = "Sipariş ID";
            this.siparisId.MinimumWidth = 6;
            this.siparisId.Name = "siparisId";
            this.siparisId.ReadOnly = true;
            // 
            // saticiAdi
            // 
            this.saticiAdi.HeaderText = "Satıcı adı";
            this.saticiAdi.MinimumWidth = 6;
            this.saticiAdi.Name = "saticiAdi";
            this.saticiAdi.ReadOnly = true;
            // 
            // islemTarihi
            // 
            this.islemTarihi.HeaderText = "İşlem tarihi";
            this.islemTarihi.MinimumWidth = 6;
            this.islemTarihi.Name = "islemTarihi";
            this.islemTarihi.ReadOnly = true;
            // 
            // islemDetay
            // 
            this.islemDetay.HeaderText = "Detay";
            this.islemDetay.MinimumWidth = 6;
            this.islemDetay.Name = "islemDetay";
            this.islemDetay.ReadOnly = true;
            // 
            // islemTutari
            // 
            this.islemTutari.HeaderText = "İşlem tutarı";
            this.islemTutari.MinimumWidth = 6;
            this.islemTutari.Name = "islemTutari";
            this.islemTutari.ReadOnly = true;
            // 
            // alicininKalanParasi
            // 
            this.alicininKalanParasi.HeaderText = "Kalan para";
            this.alicininKalanParasi.MinimumWidth = 6;
            this.alicininKalanParasi.Name = "alicininKalanParasi";
            this.alicininKalanParasi.ReadOnly = true;
            // 
            // urunBirimFiyati
            // 
            this.urunBirimFiyati.HeaderText = "Ürün kg fiyatı (TL)";
            this.urunBirimFiyati.MinimumWidth = 6;
            this.urunBirimFiyati.Name = "urunBirimFiyati";
            this.urunBirimFiyati.ReadOnly = true;
            // 
            // AliciMenuFrm
            // 
            this.ClientSize = new System.Drawing.Size(1249, 550);
            this.Controls.Add(this.tabCntrlAliciFrm);
            this.Name = "AliciMenuFrm";
            this.tabCntrlAliciFrm.ResumeLayout(false);
            this.tabPageUrunAlim.ResumeLayout(false);
            this.tabPageUrunAlim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewUrunler)).EndInit();
            this.tabPageParaEkleme.ResumeLayout(false);
            this.tabPageParaEkleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewBakiyeOnay)).EndInit();
            this.tabPageGecmisIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewGecmisSiparisler)).EndInit();
            this.ResumeLayout(false);

        }
    }
}