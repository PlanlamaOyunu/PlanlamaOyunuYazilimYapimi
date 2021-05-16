
namespace PlanlamaOyunuYazilimYapimi.Forms
{
    partial class SaticiMenuFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaticiMenuFrm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtGrdViewUrunlerim = new System.Windows.Forms.DataGridView();
            this.urunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKgFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunOnay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnUrunKaldir = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtGrdViewYeniUrun = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbBoxUrunIsmi = new System.Windows.Forms.ComboBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtBoxUrunKgFiyat = new System.Windows.Forms.TextBox();
            this.txtBoxUrunKilo = new System.Windows.Forms.TextBox();
            this.txtBoxUrunIsmi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSiparisListeYenile = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dtGrdViewSiparisler = new System.Windows.Forms.DataGridView();
            this.siparisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemDetay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemTutari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBirimFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewUrunlerim)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewYeniUrun)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 411);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage1.Controls.Add(this.dtGrdViewUrunlerim);
            this.tabPage1.Controls.Add(this.btnUrunKaldir);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(846, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ürünlerim";
            // 
            // dtGrdViewUrunlerim
            // 
            this.dtGrdViewUrunlerim.AllowUserToAddRows = false;
            this.dtGrdViewUrunlerim.AllowUserToDeleteRows = false;
            this.dtGrdViewUrunlerim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdViewUrunlerim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewUrunlerim.BackgroundColor = System.Drawing.Color.Beige;
            this.dtGrdViewUrunlerim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewUrunlerim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunId,
            this.urunAdi,
            this.urunKg,
            this.urunKgFiyat,
            this.urunOnay});
            this.dtGrdViewUrunlerim.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtGrdViewUrunlerim.Location = new System.Drawing.Point(3, 41);
            this.dtGrdViewUrunlerim.MultiSelect = false;
            this.dtGrdViewUrunlerim.Name = "dtGrdViewUrunlerim";
            this.dtGrdViewUrunlerim.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdViewUrunlerim.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrdViewUrunlerim.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtGrdViewUrunlerim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewUrunlerim.Size = new System.Drawing.Size(840, 338);
            this.dtGrdViewUrunlerim.TabIndex = 2;
            this.dtGrdViewUrunlerim.SelectionChanged += new System.EventHandler(this.dtGrdViewUrunlerim_SelectionChanged);
            // 
            // urunId
            // 
            this.urunId.HeaderText = "Ürün ID";
            this.urunId.Name = "urunId";
            this.urunId.ReadOnly = true;
            // 
            // urunAdi
            // 
            this.urunAdi.HeaderText = "Ürün Adı";
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.ReadOnly = true;
            // 
            // urunKg
            // 
            this.urunKg.HeaderText = "Ürün Kg";
            this.urunKg.Name = "urunKg";
            this.urunKg.ReadOnly = true;
            // 
            // urunKgFiyat
            // 
            this.urunKgFiyat.HeaderText = "Ürün Kg Fiyatı(TL)";
            this.urunKgFiyat.Name = "urunKgFiyat";
            this.urunKgFiyat.ReadOnly = true;
            // 
            // urunOnay
            // 
            this.urunOnay.HeaderText = "Ürün Onayı";
            this.urunOnay.Name = "urunOnay";
            this.urunOnay.ReadOnly = true;
            this.urunOnay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.urunOnay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnUrunKaldir
            // 
            this.btnUrunKaldir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunKaldir.BackColor = System.Drawing.Color.Beige;
            this.btnUrunKaldir.Location = new System.Drawing.Point(744, 6);
            this.btnUrunKaldir.Name = "btnUrunKaldir";
            this.btnUrunKaldir.Size = new System.Drawing.Size(99, 29);
            this.btnUrunKaldir.TabIndex = 1;
            this.btnUrunKaldir.Text = "Ürünü Kaldır";
            this.btnUrunKaldir.UseVisualStyleBackColor = false;
            this.btnUrunKaldir.Click += new System.EventHandler(this.btnUrunKaldir_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage2.Controls.Add(this.dtGrdViewYeniUrun);
            this.tabPage2.Controls.Add(this.cmbBoxUrunIsmi);
            this.tabPage2.Controls.Add(this.btnUrunEkle);
            this.tabPage2.Controls.Add(this.txtBoxUrunKgFiyat);
            this.tabPage2.Controls.Add(this.txtBoxUrunKilo);
            this.tabPage2.Controls.Add(this.txtBoxUrunIsmi);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(846, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yeni Ürün";
            // 
            // dtGrdViewYeniUrun
            // 
            this.dtGrdViewYeniUrun.AllowUserToAddRows = false;
            this.dtGrdViewYeniUrun.AllowUserToDeleteRows = false;
            this.dtGrdViewYeniUrun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdViewYeniUrun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewYeniUrun.BackgroundColor = System.Drawing.Color.Beige;
            this.dtGrdViewYeniUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewYeniUrun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn2});
            this.dtGrdViewYeniUrun.Location = new System.Drawing.Point(3, 111);
            this.dtGrdViewYeniUrun.MultiSelect = false;
            this.dtGrdViewYeniUrun.Name = "dtGrdViewYeniUrun";
            this.dtGrdViewYeniUrun.ReadOnly = true;
            this.dtGrdViewYeniUrun.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtGrdViewYeniUrun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewYeniUrun.Size = new System.Drawing.Size(840, 269);
            this.dtGrdViewYeniUrun.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Ürün ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Ürün Adı";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Ürün Kg";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Ürün Kg Fiyatı(TL)";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.HeaderText = "Ürün Onayı";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cmbBoxUrunIsmi
            // 
            this.cmbBoxUrunIsmi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxUrunIsmi.FormattingEnabled = true;
            this.cmbBoxUrunIsmi.Items.AddRange(new object[] {
            "Buğday",
            "Pirinç",
            "Arpa",
            "Yulaf",
            "Petrol",
            "Pamuk",
            "Diğer"});
            this.cmbBoxUrunIsmi.Location = new System.Drawing.Point(131, 13);
            this.cmbBoxUrunIsmi.Name = "cmbBoxUrunIsmi";
            this.cmbBoxUrunIsmi.Size = new System.Drawing.Size(159, 24);
            this.cmbBoxUrunIsmi.TabIndex = 8;
            this.cmbBoxUrunIsmi.SelectedIndexChanged += new System.EventHandler(this.cmbBoxUrunIsmi_SelectedIndexChanged);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.Beige;
            this.btnUrunEkle.Location = new System.Drawing.Point(273, 79);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(161, 25);
            this.btnUrunEkle.TabIndex = 7;
            this.btnUrunEkle.Text = "Ürün Talebi Oluştur";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunTalep_Click);
            // 
            // txtBoxUrunKgFiyat
            // 
            this.txtBoxUrunKgFiyat.Location = new System.Drawing.Point(131, 79);
            this.txtBoxUrunKgFiyat.Name = "txtBoxUrunKgFiyat";
            this.txtBoxUrunKgFiyat.Size = new System.Drawing.Size(132, 23);
            this.txtBoxUrunKgFiyat.TabIndex = 5;
            this.txtBoxUrunKgFiyat.Text = "0";
            this.txtBoxUrunKgFiyat.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBoxUrunKgFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyFloatValue);
            this.txtBoxUrunKgFiyat.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtBoxUrunKilo
            // 
            this.txtBoxUrunKilo.Location = new System.Drawing.Point(131, 46);
            this.txtBoxUrunKilo.Name = "txtBoxUrunKilo";
            this.txtBoxUrunKilo.Size = new System.Drawing.Size(132, 23);
            this.txtBoxUrunKilo.TabIndex = 4;
            this.txtBoxUrunKilo.Text = "0";
            this.txtBoxUrunKilo.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBoxUrunKilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyFloatValue);
            this.txtBoxUrunKilo.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtBoxUrunIsmi
            // 
            this.txtBoxUrunIsmi.Location = new System.Drawing.Point(302, 13);
            this.txtBoxUrunIsmi.Name = "txtBoxUrunIsmi";
            this.txtBoxUrunIsmi.Size = new System.Drawing.Size(132, 23);
            this.txtBoxUrunIsmi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Kg fiyatı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün kilosu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün ismi:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage3.Controls.Add(this.btnSiparisListeYenile);
            this.tabPage3.Controls.Add(this.dtGrdViewSiparisler);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(846, 382);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Siparişler";
            // 
            // btnSiparisListeYenile
            // 
            this.btnSiparisListeYenile.BackColor = System.Drawing.Color.Beige;
            this.btnSiparisListeYenile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisListeYenile.ImageKey = "synchronize_96px(mavi).png";
            this.btnSiparisListeYenile.ImageList = this.ımageList1;
            this.btnSiparisListeYenile.Location = new System.Drawing.Point(3, 6);
            this.btnSiparisListeYenile.Name = "btnSiparisListeYenile";
            this.btnSiparisListeYenile.Size = new System.Drawing.Size(48, 35);
            this.btnSiparisListeYenile.TabIndex = 13;
            this.btnSiparisListeYenile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSiparisListeYenile.UseVisualStyleBackColor = false;
            this.btnSiparisListeYenile.Click += new System.EventHandler(this.btnSiparisListeYenile_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "synchronize_96px(mavi).png");
            this.ımageList1.Images.SetKeyName(1, "checkmark_96px.png");
            this.ımageList1.Images.SetKeyName(2, "delete_96px.png");
            // 
            // dtGrdViewSiparisler
            // 
            this.dtGrdViewSiparisler.AllowUserToAddRows = false;
            this.dtGrdViewSiparisler.AllowUserToDeleteRows = false;
            this.dtGrdViewSiparisler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdViewSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewSiparisler.BackgroundColor = System.Drawing.Color.Beige;
            this.dtGrdViewSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewSiparisler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siparisId,
            this.aliciAdi,
            this.islemTarihi,
            this.islemDetay,
            this.islemTutari,
            this.urunBirimFiyati});
            this.dtGrdViewSiparisler.Location = new System.Drawing.Point(3, 47);
            this.dtGrdViewSiparisler.Name = "dtGrdViewSiparisler";
            this.dtGrdViewSiparisler.ReadOnly = true;
            this.dtGrdViewSiparisler.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtGrdViewSiparisler.Size = new System.Drawing.Size(840, 333);
            this.dtGrdViewSiparisler.TabIndex = 1;
            // 
            // siparisId
            // 
            this.siparisId.HeaderText = "Sipariş ID";
            this.siparisId.Name = "siparisId";
            this.siparisId.ReadOnly = true;
            // 
            // aliciAdi
            // 
            this.aliciAdi.HeaderText = "Alıcı Adı";
            this.aliciAdi.Name = "aliciAdi";
            this.aliciAdi.ReadOnly = true;
            // 
            // islemTarihi
            // 
            this.islemTarihi.HeaderText = "İşlem Tarihi";
            this.islemTarihi.Name = "islemTarihi";
            this.islemTarihi.ReadOnly = true;
            // 
            // islemDetay
            // 
            this.islemDetay.HeaderText = "Detay";
            this.islemDetay.Name = "islemDetay";
            this.islemDetay.ReadOnly = true;
            // 
            // islemTutari
            // 
            this.islemTutari.HeaderText = "İşlem Tutarı";
            this.islemTutari.Name = "islemTutari";
            this.islemTutari.ReadOnly = true;
            // 
            // urunBirimFiyati
            // 
            this.urunBirimFiyati.HeaderText = "Ürün Kg Fiyatı (TL)";
            this.urunBirimFiyati.Name = "urunBirimFiyati";
            this.urunBirimFiyati.ReadOnly = true;
            // 
            // SaticiMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(854, 411);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "SaticiMenuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaticiMenuFrm";
            this.Load += new System.EventHandler(this.SaticiMenuFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewUrunlerim)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewYeniUrun)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewSiparisler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnUrunKaldir;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtGrdViewYeniUrun;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.ComboBox cmbBoxUrunIsmi;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TextBox txtBoxUrunKgFiyat;
        private System.Windows.Forms.TextBox txtBoxUrunKilo;
        private System.Windows.Forms.TextBox txtBoxUrunIsmi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSiparisListeYenile;
        private System.Windows.Forms.DataGridView dtGrdViewSiparisler;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisId;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemDetay;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemTutari;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBirimFiyati;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridView dtGrdViewUrunlerim;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKgFiyat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn urunOnay;
    }
}