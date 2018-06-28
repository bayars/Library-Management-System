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
    public partial class Arama : Form
    {
        public Arama()
        {
            InitializeComponent();
        }
        public string textbox1 ()
        {
            return textBox1.Text;
        }
        public DataGridView tablo()
        {
            return dataGridView1; 
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Arama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deneme1DataSet.Dergi' table. You can move, or remove it, as needed.
            this.dergiTableAdapter.Fill(this.deneme1DataSet.Dergi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {

                    d

                }
                else
                {
                    var query = from o in this.
                                where o.Adi.Contains(textBox1.Text) || o.Basim_Yili == textBox1.Text || o.Tur == textBox1.Text || o.Yayin_Evi == textBox1.Text || o.Yazar.Contains(textBox1.Text)
                                select o;
                    kitapDataGridView.DataSource = query.ToList();

                }
            }*/
        }
    }
}
