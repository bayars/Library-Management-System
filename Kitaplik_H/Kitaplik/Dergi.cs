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
    public partial class Dergi : Form
    {
        public Dergi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dergiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dergiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.deneme1DataSet);

        }

        private void Dergi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deneme1DataSet.Dergi' table. You can move, or remove it, as needed.
            this.dergiTableAdapter.Fill(this.deneme1DataSet.Dergi);
            dergiBindingSource.DataSource = this.deneme1DataSet.Dergi;


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {

                    dergiDataGridView.DataSource = dergiBindingSource;

                }
                else
                {
                    var query = from o in this.deneme1DataSet.Dergi
                                where o.Dergi_Adi.Contains(textBox1.Text) || o.Basim_Sikligi == textBox1.Text || o.Tur == textBox1.Text || o.Sayi.ToString() == textBox1.Text
                                select o;
                    dergiDataGridView.DataSource = query.ToList();

                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
