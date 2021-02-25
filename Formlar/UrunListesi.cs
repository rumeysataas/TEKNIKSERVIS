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
    public partial class UrunListesi : Form
    {
        public UrunListesi()
        {
            InitializeComponent();
        }
         void Metot1()
        {
            var list = from u in db.URUNs
                       select new
                       {
                           u.ID,
                           u.AD,
                           u.MARKA,
                           KATEGORI = u.KATEGORI.AD,
                           u.STOK,
                           u.ALISFIYAT,
                           u.SATISFIYAT
                           
                       };
            gridControl1.DataSource = list.ToList();

        }

        TicariTeknikServisEntities db = new TicariTeknikServisEntities();
        private void UrunListesi_Load(object sender, EventArgs e)
        {
            Metot1();
            lookUpEdit2.Properties.DataSource = db.KATEGORIs.ToList();
        }

        
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            URUN urun = new URUN();
            urun.AD = BtnUrunAd.Text;
            urun.MARKA = BtnMarka.Text;
            urun.ALISFIYAT = Decimal.Parse(BtnALisFiyat.Text);
            urun.SATISFIYAT= Decimal.Parse(BtnSatisFiyat.Text);
            urun.STOK = short.Parse(BtnStok.Text);
            urun.KATEGORIID = int.Parse(lookUpEdit2.EditValue.ToString());
            urun.DURUM = false;
            db.URUNs.Add(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Metot1();
           
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            BtnId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            BtnUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            BtnMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            BtnALisFiyat.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
            BtnSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            BtnStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
          
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(BtnId.Text);
            var deger = db.URUNs.Find(id);
            db.URUNs.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(BtnId.Text);
            var deger = db.URUNs.Find(id);
            deger.AD = BtnUrunAd.Text;
            deger.MARKA = BtnMarka.Text;
            deger.ALISFIYAT = decimal.Parse(BtnALisFiyat.Text);
            deger.SATISFIYAT = decimal.Parse(BtnSatisFiyat.Text);
            deger.KATEGORIID = int.Parse(lookUpEdit2.EditValue.ToString());
            deger.STOK = short.Parse(BtnStok.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
