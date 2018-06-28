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
    public partial class KullaniciKayit : Form
    {
        public KullaniciKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kullaniciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kullaniciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.deneme1DataSet);

        }

        private void KullaniciKayit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deneme1DataSet.Kullanici' table. You can move, or remove it, as needed.
            this.kullaniciTableAdapter.Fill(this.deneme1DataSet.Kullanici);

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void kullaniciAdiLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
