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
    public partial class Markalar : Form
    {
        public Markalar()
        {
            InitializeComponent();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }
        TicariTeknikServisEntities db = new TicariTeknikServisEntities();
        private void Markalar_Load(object sender, EventArgs e)
        {
            var degerler = db.URUNs.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            }) ;
            gridControl1.DataSource = degerler.ToList();
            labelControl2.Text = db.URUNs.Sum(x => x.STOK).ToString();
            labelControl3.Text = (from x in db.URUNs
                                  select x.MARKA).Distinct().Count().ToString();
            labelControl5.Text = (from x in db.URUNs
                                  orderby x.STOK descending
                                  select x.MARKA).FirstOrDefault();
            labelControl7.Text= (from x in db.URUNs
                                 orderby x.SATISFIYAT descending
                                 select x.MARKA).FirstOrDefault();
            chartControl1.Series["Series 1"].Points.AddPoint("Siemens", 4);
            chartControl1.Series["Series 1"].Points.AddPoint("Arçelik", 4);
            chartControl1.Series["Series 1"].Points.AddPoint("Beko", 4);
            chartControl1.Series["Series 1"].Points.AddPoint("Toshiba", 4);
            chartControl1.Series["Series 1"].Points.AddPoint("Lenovo", 4);

            chartControl2.Series["Kategoriler"].Points.AddPoint("Beyaz Eşya", 4);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Bilgisayar", 3);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Küçük Ev Aletleri", 2);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Telefon", 5);
            chartControl2.Series["Kategoriler"].Points.AddPoint("TV", 1);
            chartControl2.Series["Kategoriler"].Points.AddPoint("Mutfak Araçları", 6);
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit5_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit7_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
