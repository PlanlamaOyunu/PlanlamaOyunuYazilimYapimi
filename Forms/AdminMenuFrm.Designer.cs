
namespace PlanlamaOyunuYazilimYapimi.Forms
{
    partial class AdminMenuFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenuFrm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageUrunler = new System.Windows.Forms.TabPage();
            this.btnUrunOnayKaldir = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnUrunOnayla = new System.Windows.Forms.Button();
            this.dtGrdViewUrunler = new System.Windows.Forms.DataGridView();
            this.urunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saticiKullaniciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKgFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunOnay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbBoxUrunFiltre = new System.Windows.Forms.ComboBox();
            this.tabPageParaTalepleri = new System.Windows.Forms.TabPage();
            this.btnTalepListeYenile = new System.Windows.Forms.Button();
            this.btnParaOnayiRet = new System.Windows.Forms.Button();
            this.btnParaOnayla = new System.Windows.Forms.Button();
            this.dtGrdViewParalar = new System.Windows.Forms.DataGridView();
            this.talepId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talepKullaniciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talepMiktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewUrunler)).BeginInit();
            this.tabPageParaTalepleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewParalar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUrunler);
            this.tabControl1.Controls.Add(this.tabPageParaTalepleri);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 411);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageUrunler
            // 
            this.tabPageUrunler.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPageUrunler.Controls.Add(this.btnUrunOnayKaldir);
            this.tabPageUrunler.Controls.Add(this.btnUrunOnayla);
            this.tabPageUrunler.Controls.Add(this.dtGrdViewUrunler);
            this.tabPageUrunler.Controls.Add(this.cmbBoxUrunFiltre);
            this.tabPageUrunler.Location = new System.Drawing.Point(4, 25);
            this.tabPageUrunler.Name = "tabPageUrunler";
            this.tabPageUrunler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUrunler.Size = new System.Drawing.Size(846, 382);
            this.tabPageUrunler.TabIndex = 0;
            this.tabPageUrunler.Text = "Ürünler";
            // 
            // btnUrunOnayKaldir
            // 
            this.btnUrunOnayKaldir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunOnayKaldir.BackColor = System.Drawing.Color.Beige;
            this.btnUrunOnayKaldir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunOnayKaldir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunOnayKaldir.ImageKey = "delete_96px.png";
            this.btnUrunOnayKaldir.ImageList = this.ımageList1;
            this.btnUrunOnayKaldir.Location = new System.Drawing.Point(635, 6);
            this.btnUrunOnayKaldir.Name = "btnUrunOnayKaldir";
            this.btnUrunOnayKaldir.Size = new System.Drawing.Size(208, 35);
            this.btnUrunOnayKaldir.TabIndex = 8;
            this.btnUrunOnayKaldir.Text = "Ürünü Onayı Kaldır";
            this.btnUrunOnayKaldir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunOnayKaldir.UseVisualStyleBackColor = false;
            this.btnUrunOnayKaldir.Click += new System.EventHandler(this.btnUrunOnayKaldir_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "synchronize_96px(mavi).png");
            this.ımageList1.Images.SetKeyName(1, "checkmark_96px.png");
            this.ımageList1.Images.SetKeyName(2, "delete_96px.png");
            // 
            // btnUrunOnayla
            // 
            this.btnUrunOnayla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunOnayla.BackColor = System.Drawing.Color.Beige;
            this.btnUrunOnayla.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunOnayla.ForeColor = System.Drawing.Color.Black;
            this.btnUrunOnayla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunOnayla.ImageKey = "checkmark_96px.png";
            this.btnUrunOnayla.ImageList = this.ımageList1;
            this.btnUrunOnayla.Location = new System.Drawing.Point(461, 6);
            this.btnUrunOnayla.Name = "btnUrunOnayla";
            this.btnUrunOnayla.Size = new System.Drawing.Size(168, 35);
            this.btnUrunOnayla.TabIndex = 7;
            this.btnUrunOnayla.Text = "Ürünü Onayla";
            this.btnUrunOnayla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunOnayla.UseVisualStyleBackColor = false;
            this.btnUrunOnayla.Click += new System.EventHandler(this.btnUrunOnayla_Click);
            // 
            // dtGrdViewUrunler
            // 
            this.dtGrdViewUrunler.AllowUserToAddRows = false;
            this.dtGrdViewUrunler.AllowUserToDeleteRows = false;
            this.dtGrdViewUrunler.AllowUserToResizeRows = false;
            this.dtGrdViewUrunler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdViewUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewUrunler.BackgroundColor = System.Drawing.Color.Beige;
            this.dtGrdViewUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunId,
            this.saticiKullaniciAdi,
            this.urunAdi,
            this.urunKg,
            this.urunKgFiyat,
            this.urunOnay});
            this.dtGrdViewUrunler.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dtGrdViewUrunler.Location = new System.Drawing.Point(3, 47);
            this.dtGrdViewUrunler.MultiSelect = false;
            this.dtGrdViewUrunler.Name = "dtGrdViewUrunler";
            this.dtGrdViewUrunler.ReadOnly = true;
            this.dtGrdViewUrunler.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtGrdViewUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewUrunler.Size = new System.Drawing.Size(840, 335);
            this.dtGrdViewUrunler.TabIndex = 6;
            // 
            // urunId
            // 
            this.urunId.FillWeight = 15F;
            this.urunId.HeaderText = "Ürün ID";
            this.urunId.Name = "urunId";
            this.urunId.ReadOnly = true;
            // 
            // saticiKullaniciAdi
            // 
            this.saticiKullaniciAdi.FillWeight = 28.0185F;
            this.saticiKullaniciAdi.HeaderText = "Satıcı Kullanıcı Adı";
            this.saticiKullaniciAdi.Name = "saticiKullaniciAdi";
            this.saticiKullaniciAdi.ReadOnly = true;
            // 
            // urunAdi
            // 
            this.urunAdi.FillWeight = 28.0185F;
            this.urunAdi.HeaderText = "Ürün Adı";
            this.urunAdi.Name = "urunAdi";
            this.urunAdi.ReadOnly = true;
            // 
            // urunKg
            // 
            this.urunKg.FillWeight = 28.0185F;
            this.urunKg.HeaderText = "Ürün Kg";
            this.urunKg.Name = "urunKg";
            this.urunKg.ReadOnly = true;
            // 
            // urunKgFiyat
            // 
            this.urunKgFiyat.FillWeight = 28.0185F;
            this.urunKgFiyat.HeaderText = "Ürün Kg Fiyatı(TL)";
            this.urunKgFiyat.Name = "urunKgFiyat";
            this.urunKgFiyat.ReadOnly = true;
            // 
            // urunOnay
            // 
            this.urunOnay.FillWeight = 28.0185F;
            this.urunOnay.HeaderText = "Ürün Onayı";
            this.urunOnay.Name = "urunOnay";
            this.urunOnay.ReadOnly = true;
            // 
            // cmbBoxUrunFiltre
            // 
            this.cmbBoxUrunFiltre.BackColor = System.Drawing.Color.White;
            this.cmbBoxUrunFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxUrunFiltre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxUrunFiltre.FormattingEnabled = true;
            this.cmbBoxUrunFiltre.Items.AddRange(new object[] {
            "Hepsi",
            "Onaylanmamış Ürünler",
            "Onaylanmış Ürünler"});
            this.cmbBoxUrunFiltre.Location = new System.Drawing.Point(3, 6);
            this.cmbBoxUrunFiltre.Name = "cmbBoxUrunFiltre";
            this.cmbBoxUrunFiltre.Size = new System.Drawing.Size(262, 27);
            this.cmbBoxUrunFiltre.TabIndex = 0;
            this.cmbBoxUrunFiltre.SelectedIndexChanged += new System.EventHandler(this.cmbBoxUrunFiltre_SelectedIndexChanged);
            // 
            // tabPageParaTalepleri
            // 
            this.tabPageParaTalepleri.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPageParaTalepleri.Controls.Add(this.btnTalepListeYenile);
            this.tabPageParaTalepleri.Controls.Add(this.btnParaOnayiRet);
            this.tabPageParaTalepleri.Controls.Add(this.btnParaOnayla);
            this.tabPageParaTalepleri.Controls.Add(this.dtGrdViewParalar);
            this.tabPageParaTalepleri.Location = new System.Drawing.Point(4, 25);
            this.tabPageParaTalepleri.Name = "tabPageParaTalepleri";
            this.tabPageParaTalepleri.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParaTalepleri.Size = new System.Drawing.Size(846, 382);
            this.tabPageParaTalepleri.TabIndex = 1;
            this.tabPageParaTalepleri.Text = "Para Talepleri";
            // 
            // btnTalepListeYenile
            // 
            this.btnTalepListeYenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTalepListeYenile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTalepListeYenile.ImageKey = "synchronize_96px(mavi).png";
            this.btnTalepListeYenile.ImageList = this.ımageList1;
            this.btnTalepListeYenile.Location = new System.Drawing.Point(-179, 3);
            this.btnTalepListeYenile.Name = "btnTalepListeYenile";
            this.btnTalepListeYenile.Size = new System.Drawing.Size(44, 39);
            this.btnTalepListeYenile.TabIndex = 11;
            this.btnTalepListeYenile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTalepListeYenile.UseVisualStyleBackColor = true;
            this.btnTalepListeYenile.Click += new System.EventHandler(this.btnTalepListeYenile_Click);
            // 
            // btnParaOnayiRet
            // 
            this.btnParaOnayiRet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParaOnayiRet.BackColor = System.Drawing.Color.Beige;
            this.btnParaOnayiRet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParaOnayiRet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParaOnayiRet.ImageKey = "delete_96px.png";
            this.btnParaOnayiRet.ImageList = this.ımageList1;
            this.btnParaOnayiRet.Location = new System.Drawing.Point(621, 3);
            this.btnParaOnayiRet.Name = "btnParaOnayiRet";
            this.btnParaOnayiRet.Size = new System.Drawing.Size(222, 35);
            this.btnParaOnayiRet.TabIndex = 10;
            this.btnParaOnayiRet.Text = "Para Talebini Reddet";
            this.btnParaOnayiRet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnParaOnayiRet.UseVisualStyleBackColor = false;
            this.btnParaOnayiRet.Click += new System.EventHandler(this.btnParaOnayiRet_Click);
            // 
            // btnParaOnayla
            // 
            this.btnParaOnayla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParaOnayla.BackColor = System.Drawing.Color.Beige;
            this.btnParaOnayla.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParaOnayla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParaOnayla.ImageKey = "checkmark_96px.png";
            this.btnParaOnayla.ImageList = this.ımageList1;
            this.btnParaOnayla.Location = new System.Drawing.Point(389, 3);
            this.btnParaOnayla.Name = "btnParaOnayla";
            this.btnParaOnayla.Size = new System.Drawing.Size(226, 35);
            this.btnParaOnayla.TabIndex = 9;
            this.btnParaOnayla.Text = "Para Talebini Onayla";
            this.btnParaOnayla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnParaOnayla.UseVisualStyleBackColor = false;
            this.btnParaOnayla.Click += new System.EventHandler(this.btnParaOnayla_Click);
            // 
            // dtGrdViewParalar
            // 
            this.dtGrdViewParalar.AllowUserToAddRows = false;
            this.dtGrdViewParalar.AllowUserToDeleteRows = false;
            this.dtGrdViewParalar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdViewParalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewParalar.BackgroundColor = System.Drawing.Color.Beige;
            this.dtGrdViewParalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewParalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.talepId,
            this.talepKullaniciAdi,
            this.talepMiktari});
            this.dtGrdViewParalar.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dtGrdViewParalar.Location = new System.Drawing.Point(3, 44);
            this.dtGrdViewParalar.MultiSelect = false;
            this.dtGrdViewParalar.Name = "dtGrdViewParalar";
            this.dtGrdViewParalar.ReadOnly = true;
            this.dtGrdViewParalar.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtGrdViewParalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewParalar.Size = new System.Drawing.Size(840, 335);
            this.dtGrdViewParalar.TabIndex = 8;
            // 
            // talepId
            // 
            this.talepId.HeaderText = "Talep ID";
            this.talepId.Name = "talepId";
            this.talepId.ReadOnly = true;
            // 
            // talepKullaniciAdi
            // 
            this.talepKullaniciAdi.HeaderText = "Kullanıcının Adı";
            this.talepKullaniciAdi.Name = "talepKullaniciAdi";
            this.talepKullaniciAdi.ReadOnly = true;
            // 
            // talepMiktari
            // 
            this.talepMiktari.HeaderText = "Talep Miktarı(TL)";
            this.talepMiktari.Name = "talepMiktari";
            this.talepMiktari.ReadOnly = true;
            // 
            // AdminMenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(854, 411);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AdminMenuFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenuFrm";
            this.Load += new System.EventHandler(this.AdminMenuFrm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageUrunler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewUrunler)).EndInit();
            this.tabPageParaTalepleri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewParalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUrunler;
        private System.Windows.Forms.TabPage tabPageParaTalepleri;
        private System.Windows.Forms.Button btnUrunOnayKaldir;
        private System.Windows.Forms.Button btnUrunOnayla;
        private System.Windows.Forms.DataGridView dtGrdViewUrunler;
        private System.Windows.Forms.ComboBox cmbBoxUrunFiltre;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnTalepListeYenile;
        private System.Windows.Forms.Button btnParaOnayiRet;
        private System.Windows.Forms.Button btnParaOnayla;
        private System.Windows.Forms.DataGridView dtGrdViewParalar;
        private System.Windows.Forms.DataGridViewTextBoxColumn talepId;
        private System.Windows.Forms.DataGridViewTextBoxColumn talepKullaniciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn talepMiktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn saticiKullaniciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKgFiyat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn urunOnay;
            
        

    }
}