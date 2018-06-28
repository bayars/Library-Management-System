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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelDogrulama persdogru = new PersonelDogrulama();
            persdogru.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KullaniciDogrulama kulldogru = new KullaniciDogrulama();
            kulldogru.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonelKayit perskayit = new PersonelKayit();
            perskayit.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KullaniciKayit kullkayit = new KullaniciKayit();
            kullkayit.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
