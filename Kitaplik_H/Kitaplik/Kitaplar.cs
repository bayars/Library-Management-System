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
    public partial class Kitaplar : Form
    {
        public Kitaplar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel pers = new Personel();
            this.Close();
        }

        private void kitapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kitapBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.deneme1DataSet);
        }

        private void Kitaplar_Load(object sender, EventArgs e)
        {
            this.kitapTableAdapter.Fill(this.deneme1DataSet.Kitap);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {

                    kitapDataGridView.DataSource = kitapBindingSource;

                }
                else
                {
                    var query = from o in this.deneme1DataSet.Kitap
                                where o.Adi.Contains(textBox1.Text) || o.Basim_Yili == textBox1.Text || o.Tur == textBox1.Text || o.Yayin_Evi == textBox1.Text || o.Yazar.Contains(textBox1.Text)
                                select o;
                    kitapDataGridView.DataSource = query.ToList();

                }
            }
        
    }

        private void yayin_EviTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adiTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
