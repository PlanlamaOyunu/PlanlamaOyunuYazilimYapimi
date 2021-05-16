
namespace PlanlamaOyunuYazilimYapimi.Forms
{

    partial class AliciMenuFrm
    {
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AliciMenuFrm));
            this.tabCntrlAliciFrm = new System.Windows.Forms.TabControl();
            this.tabPageUrunAlim = new System.Windows.Forms.TabPage();
            this.btnUrunListeYenile = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            this.tabCntrlAliciFrm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabCntrlAliciFrm.Location = new System.Drawing.Point(0, 0);
            this.tabCntrlAliciFrm.Margin = new System.Windows.Forms.Padding(4);
            this.tabCntrlAliciFrm.Name = "tabCntrlAliciFrm";
            this.tabCntrlAliciFrm.SelectedIndex = 0;
            this.tabCntrlAliciFrm.Size = new System.Drawing.Size(854, 411);
            this.tabCntrlAliciFrm.TabIndex = 1;
            // 
            // tabPageUrunAlim
            // 
            this.tabPageUrunAlim.AutoScroll = true;
            this.tabPageUrunAlim.BackColor = System.Drawing.Color.DarkSeaGreen;
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
            this.tabPageUrunAlim.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPageUrunAlim.Location = new System.Drawing.Point(4, 25);
            this.tabPageUrunAlim.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageUrunAlim.Name = "tabPageUrunAlim";
            this.tabPageUrunAlim.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageUrunAlim.Size = new System.Drawing.Size(846, 382);
            this.tabPageUrunAlim.TabIndex = 0;
            this.tabPageUrunAlim.Text = "Ürün Satın Alma";
            // 
            // btnUrunListeYenile
            // 
            this.btnUrunListeYenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunListeYenile.BackColor = System.Drawing.Color.Beige;
            this.btnUrunListeYenile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunListeYenile.ImageKey = "synchronize_96px(mavi).png";
            this.btnUrunListeYenile.ImageList = this.ımageList1;
            this.btnUrunListeYenile.Location = new System.Drawing.Point(424, 4);
            this.btnUrunListeYenile.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunListeYenile.Name = "btnUrunListeYenile";
            this.btnUrunListeYenile.Size = new System.Drawing.Size(48, 36);
            this.btnUrunListeYenile.TabIndex = 12;
            this.btnUrunListeYenile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunListeYenile.UseVisualStyleBackColor = false;
            this.btnUrunListeYenile.Click += new System.EventHandler(this.btnUrunListeYenile_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "synchronize_96px(mavi).png");
            this.ımageList1.Images.SetKeyName(1, "checkmark_96px.png");
            this.ımageList1.Images.SetKeyName(2, "delete_96px.png");
            // 
            // lblUrunKgFiyati
            // 
            this.lblUrunKgFiyati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUrunKgFiyati.AutoSize = true;
            this.lblUrunKgFiyati.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunKgFiyati.Location = new System.Drawing.Point(669, 75);
            this.lblUrunKgFiyati.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrunKgFiyati.Name = "lblUrunKgFiyati";
            this.lblUrunKgFiyati.Size = new System.Drawing.Size(15, 16);
            this.lblUrunKgFiyati.TabIndex = 11;
            this.lblUrunKgFiyati.Text = "0";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(480, 75);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Ürün Kg Fiyatı:";
            // 
            // dtGrdViewUrunler
            // 
            this.dtGrdViewUrunler.AllowUserToAddRows = false;
            this.dtGrdViewUrunler.AllowUserToDeleteRows = false;
            this.dtGrdViewUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdViewUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewUrunler.BackgroundColor = System.Drawing.Color.Beige;
            this.dtGrdViewUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunID,
            this.urunAdi,
            this.urunKg,
            this.urunBirimFiyat});
            this.dtGrdViewUrunler.Location = new System.Drawing.Point(4, 42);
            this.dtGrdViewUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.dtGrdViewUrunler.Name = "dtGrdViewUrunler";
            this.dtGrdViewUrunler.ReadOnly = true;
            this.dtGrdViewUrunler.RowHeadersWidth = 51;
            this.dtGrdViewUrunler.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtGrdViewUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewUrunler.Size = new System.Drawing.Size(468, 336);
            this.dtGrdViewUrunler.TabIndex = 9;
            this.dtGrdViewUrunler.SelectionChanged += new System.EventHandler(this.dtGrdViewUrunler_SelectionChanged);
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
            this.lblBakiyeSatinAlma.Location = new System.Drawing.Point(674, 0);
            this.lblBakiyeSatinAlma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBakiyeSatinAlma.Name = "lblBakiyeSatinAlma";
            this.lblBakiyeSatinAlma.Size = new System.Drawing.Size(31, 16);
            this.lblBakiyeSatinAlma.TabIndex = 8;
            this.lblBakiyeSatinAlma.Text = "0 TL";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(480, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Bakiye:";
            // 
            // lblOdenecekTutar
            // 
            this.lblOdenecekTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOdenecekTutar.AutoSize = true;
            this.lblOdenecekTutar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenecekTutar.Location = new System.Drawing.Point(669, 109);
            this.lblOdenecekTutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdenecekTutar.Name = "lblOdenecekTutar";
            this.lblOdenecekTutar.Size = new System.Drawing.Size(15, 16);
            this.lblOdenecekTutar.TabIndex = 6;
            this.lblOdenecekTutar.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(480, 109);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ödenecek Tutar:";
            // 
            // txtBoxAlinacakMiktar
            // 
            this.txtBoxAlinacakMiktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAlinacakMiktar.Location = new System.Drawing.Point(672, 39);
            this.txtBoxAlinacakMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAlinacakMiktar.Name = "txtBoxAlinacakMiktar";
            this.txtBoxAlinacakMiktar.Size = new System.Drawing.Size(132, 23);
            this.txtBoxAlinacakMiktar.TabIndex = 4;
            this.txtBoxAlinacakMiktar.Text = "0";
            this.txtBoxAlinacakMiktar.TextChanged += new System.EventHandler(this.txtBoxAlinacakMiktar_TextChanged);
            this.txtBoxAlinacakMiktar.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBoxAlinacakMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyFloatValue);
            this.txtBoxAlinacakMiktar.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(480, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Alınacak ürün miktarı (Kg):";
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSatinAl.BackColor = System.Drawing.Color.Beige;
            this.btnSatinAl.Location = new System.Drawing.Point(672, 139);
            this.btnSatinAl.Margin = new System.Windows.Forms.Padding(4);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(133, 28);
            this.btnSatinAl.TabIndex = 2;
            this.btnSatinAl.Text = "Satın Al";
            this.btnSatinAl.UseVisualStyleBackColor = false;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(4, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ürünler:";
            // 
            // tabPageParaEkleme
            // 
            this.tabPageParaEkleme.BackColor = System.Drawing.Color.DarkSeaGreen;
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
            this.tabPageParaEkleme.Size = new System.Drawing.Size(846, 382);
            this.tabPageParaEkleme.TabIndex = 1;
            this.tabPageParaEkleme.Text = "Para Ekleme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(8, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Beklenen Para Talepleri:";
            // 
            // dtGrdViewBakiyeOnay
            // 
            this.dtGrdViewBakiyeOnay.AllowUserToAddRows = false;
            this.dtGrdViewBakiyeOnay.AllowUserToDeleteRows = false;
            this.dtGrdViewBakiyeOnay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtGrdViewBakiyeOnay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewBakiyeOnay.BackgroundColor = System.Drawing.Color.Beige;
            this.dtGrdViewBakiyeOnay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewBakiyeOnay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.talepID,
            this.talepTarihi,
            this.talepMiktari});
            this.dtGrdViewBakiyeOnay.Location = new System.Drawing.Point(12, 97);
            this.dtGrdViewBakiyeOnay.Margin = new System.Windows.Forms.Padding(4);
            this.dtGrdViewBakiyeOnay.Name = "dtGrdViewBakiyeOnay";
            this.dtGrdViewBakiyeOnay.ReadOnly = true;
            this.dtGrdViewBakiyeOnay.RowHeadersWidth = 51;
            this.dtGrdViewBakiyeOnay.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtGrdViewBakiyeOnay.Size = new System.Drawing.Size(516, 276);
            this.dtGrdViewBakiyeOnay.TabIndex = 5;
            // 
            // talepID
            // 
            this.talepID.HeaderText = "Talep ID";
            this.talepID.MinimumWidth = 6;
            this.talepID.Name = "talepID";
            this.talepID.ReadOnly = true;
            // 
            // talepTarihi
            // 
            this.talepTarihi.HeaderText = "Talep Tarihi";
            this.talepTarihi.MinimumWidth = 6;
            this.talepTarihi.Name = "talepTarihi";
            this.talepTarihi.ReadOnly = true;
            // 
            // talepMiktari
            // 
            this.talepMiktari.HeaderText = "Talep Miktarı";
            this.talepMiktari.MinimumWidth = 6;
            this.talepMiktari.Name = "talepMiktari";
            this.talepMiktari.ReadOnly = true;
            // 
            // btnParaEkle
            // 
            this.btnParaEkle.BackColor = System.Drawing.Color.Beige;
            this.btnParaEkle.Location = new System.Drawing.Point(405, 35);
            this.btnParaEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnParaEkle.Name = "btnParaEkle";
            this.btnParaEkle.Size = new System.Drawing.Size(123, 25);
            this.btnParaEkle.TabIndex = 4;
            this.btnParaEkle.Text = "Ekle";
            this.btnParaEkle.UseVisualStyleBackColor = false;
            this.btnParaEkle.Click += new System.EventHandler(this.btnParaEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Eklenecek Tutar:";
            // 
            // txt_ekleBakiye
            // 
            this.txt_ekleBakiye.Location = new System.Drawing.Point(236, 36);
            this.txt_ekleBakiye.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ekleBakiye.Name = "txt_ekleBakiye";
            this.txt_ekleBakiye.Size = new System.Drawing.Size(132, 23);
            this.txt_ekleBakiye.TabIndex = 2;
            this.txt_ekleBakiye.Text = "0";
            this.txt_ekleBakiye.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txt_ekleBakiye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyFloatValue);
            this.txt_ekleBakiye.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // lblBakiyeParaEkleme
            // 
            this.lblBakiyeParaEkleme.AutoSize = true;
            this.lblBakiyeParaEkleme.Location = new System.Drawing.Point(233, 4);
            this.lblBakiyeParaEkleme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBakiyeParaEkleme.Name = "lblBakiyeParaEkleme";
            this.lblBakiyeParaEkleme.Size = new System.Drawing.Size(15, 16);
            this.lblBakiyeParaEkleme.TabIndex = 1;
            this.lblBakiyeParaEkleme.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mevcut Bakiyeniz(TL):";
            // 
            // tabPageGecmisIslemler
            // 
            this.tabPageGecmisIslemler.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPageGecmisIslemler.Controls.Add(this.dtGrdViewGecmisSiparisler);
            this.tabPageGecmisIslemler.Location = new System.Drawing.Point(4, 25);
            this.tabPageGecmisIslemler.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageGecmisIslemler.Name = "tabPageGecmisIslemler";
            this.tabPageGecmisIslemler.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageGecmisIslemler.Size = new System.Drawing.Size(846, 382);
            this.tabPageGecmisIslemler.TabIndex = 2;
            this.tabPageGecmisIslemler.Text = "Geçmiş Siparişlerim";
            // 
            // dtGrdViewGecmisSiparisler
            // 
            this.dtGrdViewGecmisSiparisler.AllowUserToAddRows = false;
            this.dtGrdViewGecmisSiparisler.AllowUserToDeleteRows = false;
            this.dtGrdViewGecmisSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewGecmisSiparisler.BackgroundColor = System.Drawing.Color.Beige;
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
            this.dtGrdViewGecmisSiparisler.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtGrdViewGecmisSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewGecmisSiparisler.Size = new System.Drawing.Size(838, 374);
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
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(854, 411);
            this.Controls.Add(this.tabCntrlAliciFrm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "AliciMenuFrm";
            this.Load += new System.EventHandler(this.AliciMenuFrm_Load);
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
        private System.Windows.Forms.TabControl tabCntrlAliciFrm;
        private System.Windows.Forms.TabPage tabPageUrunAlim;
        private System.Windows.Forms.Button btnUrunListeYenile;
        private System.Windows.Forms.Label lblUrunKgFiyati;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtGrdViewUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunID;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBirimFiyat;
        private System.Windows.Forms.Label lblBakiyeSatinAlma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblOdenecekTutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxAlinacakMiktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPageParaEkleme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtGrdViewBakiyeOnay;
        private System.Windows.Forms.DataGridViewTextBoxColumn talepID;
        private System.Windows.Forms.DataGridViewTextBoxColumn talepTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn talepMiktari;
        private System.Windows.Forms.Button btnParaEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ekleBakiye;
        private System.Windows.Forms.Label lblBakiyeParaEkleme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageGecmisIslemler;
        private System.Windows.Forms.DataGridView dtGrdViewGecmisSiparisler;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisId;
        private System.Windows.Forms.DataGridViewTextBoxColumn saticiAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemDetay;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemTutari;
        private System.Windows.Forms.DataGridViewTextBoxColumn alicininKalanParasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBirimFiyati;
        private System.Windows.Forms.ImageList ımageList1;
        private System.ComponentModel.IContainer components;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
