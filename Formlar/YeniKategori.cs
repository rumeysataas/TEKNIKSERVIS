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
    public partial class YeniKategori : Form
    {
        public YeniKategori()
        {
            InitializeComponent();
        }

        private void SatisFiyat_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void YeniKategori_Load(object sender, EventArgs e)
        {

        }
        TicariTeknikServisEntities db = new TicariTeknikServisEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            KATEGORI urun = new KATEGORI();

            urun.AD = Kategori.Text;
            db.KATEGORIs.Add(urun);
            db.SaveChanges();
            MessageBox.Show("Yeni Kategori Girişi Yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
