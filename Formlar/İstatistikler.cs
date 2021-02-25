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
    public partial class İstatistikler : Form
    {
        public İstatistikler()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl26_Click(object sender, EventArgs e)
        {

        }
        TicariTeknikServisEntities db = new TicariTeknikServisEntities();
        private void İstatistikler_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.URUNs.Count().ToString();
            labelControl9.Text= db.KATEGORIs.Count().ToString();
            labelControl7.Text = db.URUNs.Sum(p => p.STOK).ToString();
            labelControl19.Text = (from x in db.URUNs
                                   orderby x.STOK descending
                                   select x.AD).FirstOrDefault();
            labelControl17.Text = (from x in db.URUNs
                                   orderby x.STOK ascending
                                   select x.AD).FirstOrDefault();
            labelControl13.Text = (from x in db.URUNs
                                   orderby x.SATISFIYAT descending
                                   select x.AD).FirstOrDefault();
            labelControl11.Text = (from x in db.URUNs
                                   orderby x.SATISFIYAT ascending
                                   select x.AD).FirstOrDefault();
            labelControl27.Text = db.URUNs.Where(p => p.KATEGORIID == 4).Sum(p => p.STOK).ToString();
            labelControl25.Text=db.URUNs.Where(p => p.KATEGORIID == 1).Sum(p => p.STOK).ToString(); 
            labelControl23.Text = db.URUNs.Where(p => p.KATEGORIID == 3).Sum(p => p.STOK).ToString();
            labelControl32.Text = (from x in db.URUNs
                                   orderby x.STOK descending
                                   select x.MARKA).FirstOrDefault();
            labelControl38.Text = (from x in db.URUNs
                                   select x.MARKA).Distinct().Count().ToString();
            labelControl15.Text = (from x in db.URUNs
                                   orderby x.STOK descending
                                   select x.KATEGORI.AD).FirstOrDefault();
        }

        private void labelControl16_Click(object sender, EventArgs e)
        {

        }
    }
}
