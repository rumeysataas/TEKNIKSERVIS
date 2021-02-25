using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEKNIKSERVIS.Formlar;

namespace TEKNIKSERVIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Kate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.MdiParent = this;
            kategori.Show();
        }

        private void BtnUrunList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.UrunListesi fr = new Formlar.UrunListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void YeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YeniUrun yu = new YeniUrun();
            yu.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void YeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            YeniKategori yenikat = new YeniKategori();
           
            yenikat.Show();
        }

        private void Urunİstatistikler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            İstatistikler istatistik = new İstatistikler();
            istatistik.MdiParent = this;
            istatistik.Show();
        }

        private void MarkaIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Markalar marka = new Markalar();
            marka.MdiParent = this;
            marka.Show();
        }
    }
}
