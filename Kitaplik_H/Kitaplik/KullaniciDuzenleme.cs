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
    public partial class KullaniciDuzenleme : Form
    {
        public KullaniciDuzenleme()
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

        private void KullaniciDuzenleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deneme1DataSet.Kullanici' table. You can move, or remove it, as needed.
            this.kullaniciTableAdapter.Fill(this.deneme1DataSet.Kullanici);

        }

        private void kullaniciAdiLabel_Click(object sender, EventArgs e)
        {

        }

        private void tel_NoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
