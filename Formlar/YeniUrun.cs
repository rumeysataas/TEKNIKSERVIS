using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEKNIKSERVIS.Formlar
{
    public partial class YeniUrun : Form
    {
        public YeniUrun()
        {
            InitializeComponent();
        }

        private void pictureEdit6_EditValueChanged(object sender, EventArgs e)
        {

        }
        TicariTeknikServisEntities db = new TicariTeknikServisEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            URUN urun = new URUN();
           
            urun.AD = UrunAd.Text;
            urun.MARKA = Marka.Text;
            urun.SATISFIYAT = decimal.Parse(SatisFiyat.Text);
            urun.ALISFIYAT = decimal.Parse(AlisFiyat.Text);
            urun.STOK = short.Parse(Stok.Text);
            urun.KATEGORIID = int.Parse(Kategori.Text);
            db.URUNs.Add(urun);
            db.SaveChanges();
            MessageBox.Show("Yeni Ürün Girişi Yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void YeniUrun_Load(object sender, EventArgs e)
        {

        }
    }
}
