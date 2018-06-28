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
    public partial class Film : Form
    {
        public Film()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void filmBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.deneme1DataSet);

        }

        private void Film_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deneme1DataSet.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.deneme1DataSet.Film);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {

                    filmDataGridView.DataSource = filmBindingSource;

                }
                else
                {

                    var query = from o in this.deneme1DataSet.Film
                                where o.Filmin_Adi.Contains(textBox1.Text) || o.Yonetmeni == textBox1.Text  || o.Tur == textBox1.Text || o.IMDB.ToString() == textBox1.Text || o.Vizyon_Tarihi.ToString() == textBox1.Text
                                select o;
                    filmDataGridView.DataSource = query.ToList();

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void filmDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void filmBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
