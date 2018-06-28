using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplik
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitaplar kitap = new Kitaplar();
            kitap.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dergi derg = new Dergi();
            derg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Muzik muzik = new Muzik();
            muzik.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Film film = new Film();
            film.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KullaniciDuzenleme kullduzenleme = new KullaniciDuzenleme();
            kullduzenleme.ShowDialog();
        }

        private void Personel_Load(object sender, EventArgs e)
        {

        }
    }
}
