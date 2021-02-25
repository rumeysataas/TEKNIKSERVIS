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
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }
        TicariTeknikServisEntities db = new TicariTeknikServisEntities();
        private void Kategori_Load(object sender, EventArgs e)
        {
            var degerler = from k in db.KATEGORIs
                           select new
                           {
                               k.ID,
                                k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            KATEGORI kategori = new KATEGORI();
            kategori.AD = BtnAd.Text;
            db.KATEGORIs.Add(kategori);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from k in db.KATEGORIs
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            BtnId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            BtnAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void groupControl8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(BtnId.Text);
            var deger = db.KATEGORIs.Find(id);
            db.KATEGORIs.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(BtnId.Text);
            var deger = db.KATEGORIs.Find(id);
            deger.AD = BtnAd.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
