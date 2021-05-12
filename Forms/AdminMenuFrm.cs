<<<<<<< HEAD
﻿using PlanlamaOyunuYazilimYapimi.Entitys;
using PlanlamaOyunuYazilimYapimi.SqlQuerys;
using System;
=======
﻿using System;
>>>>>>> 8600fc4903085aa61567d83f545a6446bd109905
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
    public partial class AdminMenuFrm : Form
    {
        public AdminMenuFrm()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        AdminFrmQuerys admnFrmQrys = new AdminFrmQuerys();
        List<Urun> urnlr = new List<Urun>();
        List<Talep> prTlplr = new List<Talep>();

        private void AdminMenuFrm_Load(object sender, EventArgs e)
        {
            cmbBoxUrunFiltre.SelectedIndex = 0;
            prTlplr = admnFrmQrys.getAllParaTalep();
            dataGridViewParaTalepListele(prTlplr);
        }
        /*
         * ÜRÜN TALEPLERİ KISMI
         */
        private void cmbBoxUrunFiltre_SelectedIndexChanged(object sender, EventArgs e)//combobox daki seçenek değişirse yapılacak işlemler
        {
            urnlr.Clear();
            if (cmbBoxUrunFiltre.Text == "Hepsi")
            {
                urnlr = admnFrmQrys.getAllUrun();//bütün ürünleri çekiyor
            }
            else if (cmbBoxUrunFiltre.Text == "Onaylanmamış Ürünler")
            {
                urnlr = admnFrmQrys.getUrunByUrunOnay(false);//onaylanmamış ürünleri çekiyor
            }
            else if (cmbBoxUrunFiltre.Text == "Onaylanmış Ürünler")
            {
                urnlr = admnFrmQrys.getUrunByUrunOnay(true);//onaylanmış ürünleri çekiyor
            }
            dataGridViewUrunListele(urnlr);//datagridview a ürünleri listeliyor
        }

        public void dataGridViewUrunListele(List<Urun> urnlr)//datagridview a parametre olarak gönderilen urnlr listesini(ürün listesi) listeliyor
        {
            dtGrdViewUrunler.Rows.Clear();
            for (int i = 0; i < urnlr.Count; i++)
            {
                dtGrdViewUrunler.Rows.Add();
                dtGrdViewUrunler.Rows[i].Cells[0].Value = urnlr[i].urunID;
                dtGrdViewUrunler.Rows[i].Cells[1].Value = urnlr[i].kullaniciAdi;
                dtGrdViewUrunler.Rows[i].Cells[2].Value = urnlr[i].urunAdi;
                dtGrdViewUrunler.Rows[i].Cells[3].Value = urnlr[i].urunKg;
                dtGrdViewUrunler.Rows[i].Cells[4].Value = urnlr[i].urunFiyati;
                dtGrdViewUrunler.Rows[i].Cells[5].Value = urnlr[i].urunOnay;
            }
        }
        private void btnUrunOnayla_Click(object sender, EventArgs e)
        {
            if (dtGrdViewUrunler.SelectedRows.Count > 0)
            {
                admnFrmQrys.changeUrunOnay(Convert.ToInt32(dtGrdViewUrunler.SelectedRows[0].Cells[0].Value), true);//ürün onayı işlemi
                dtGrdViewUrunler.SelectedRows[0].Cells[5].Value = true;//seçili ürünün onayını true yapıyor
            }
        }

        private void btnUrunOnayKaldir_Click(object sender, EventArgs e)
        {
            if (dtGrdViewUrunler.SelectedRows.Count > 0)
            {
                admnFrmQrys.changeUrunOnay(Convert.ToInt32(dtGrdViewUrunler.SelectedRows[0].Cells[0].Value), false);//ürün onay kaldırma işlemi
                dtGrdViewUrunler.SelectedRows[0].Cells[5].Value = false;//seçili ürünün onayını false yapıyor
            }
        }

        /*
         * PARA TALEPLERİ KISMI
         */
        public void dataGridViewParaTalepListele(List<Talep> prTlplr)//datagridview a parametre olarak gönderilen prTlplr listesini(para talepleri listesi) listeliyor
        {
            dtGrdViewParalar.Rows.Clear();
            for (int i = 0; i < prTlplr.Count; i++)
            {
                dtGrdViewParalar.Rows.Add();
                dtGrdViewParalar.Rows[i].Cells[0].Value = prTlplr[i].talepId;
                dtGrdViewParalar.Rows[i].Cells[1].Value = prTlplr[i].kullaniciAdi;
                dtGrdViewParalar.Rows[i].Cells[2].Value = prTlplr[i].talepMiktari;
            }
        }
        private void btnParaOnayla_Click(object sender, EventArgs e)
        {
            if (dtGrdViewParalar.SelectedRows.Count > 0)
            {
                int talepId = Convert.ToInt32(dtGrdViewParalar.SelectedRows[0].Cells[0].Value);//listeden seçilen talebin talepId si alınıyor
                string kullaniciAdi = dtGrdViewParalar.SelectedRows[0].Cells[1].Value.ToString();//listeden seçilen talebin kullaniciAdi alınıyor
                double talepMiktari = Convert.ToDouble(dtGrdViewParalar.SelectedRows[0].Cells[2].Value);//listeden seçilen talebin miktarı alınıyor
                admnFrmQrys.confirmParaTalep(talepId, kullaniciAdi, talepMiktari);//para talebinde bulunan kullanıcının bakiyesine para ekleniyor ve para talebi siliniyor
                //para talebi listesi yenileniyor
                prTlplr.Clear();
                prTlplr = admnFrmQrys.getAllParaTalep();
                dataGridViewParaTalepListele(prTlplr);
            }
        }

        private void btnParaOnayiRet_Click(object sender, EventArgs e)
        {
            if (dtGrdViewParalar.SelectedRows.Count > 0)
            {
                admnFrmQrys.deleteParaTalepByTalepId(Convert.ToInt32(dtGrdViewParalar.SelectedRows[0].Cells[0].Value));//para talebi siliniyor
                paraTalepListeYenile();
            }
        }

        private void btnTalepListeYenile_Click(object sender, EventArgs e)
        {
            paraTalepListeYenile();
        }
        private void paraTalepListeYenile()//para talepleri listesini yeniliyor
        {
            prTlplr.Clear();
            prTlplr = admnFrmQrys.getAllParaTalep();
            dataGridViewParaTalepListele(prTlplr);
        }
=======
>>>>>>> 8600fc4903085aa61567d83f545a6446bd109905
    }
}
