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
    public partial class Muzik : Form
    {
        public Muzik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void muzikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.muzikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.deneme1DataSet);

        }

        private void Muzik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deneme1DataSet.Muzik' table. You can move, or remove it, as needed.
            this.muzikTableAdapter.Fill(this.deneme1DataSet.Muzik);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {

                    muzikDataGridView.DataSource = muzikBindingSource;

                }
                else
                {
                    var query = from o in this.deneme1DataSet.Muzik
                                where o.Album_Adi.Contains(textBox1.Text) || o.Sanatci == textBox1.Text || o.Cikis_Yili.ToString() == textBox1.Text ||  o.Tur.Contains(textBox1.Text)
                                select o;
                    muzikDataGridView.DataSource = query.ToList();

                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cikis_YiliLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
