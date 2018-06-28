using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Kitaplik
{
    public partial class Kullanici : Form
    {
        private string kullaniciAdi;
        private string parola;

        public Kullanici()
        {
            this.kullaniciAdi = "bilinmiyor";
            this.parola = "bilinmiyor";

            InitializeComponent();
            /*
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source=Deneme1.accdb";
            string sqlPerson = "SELECT KullaniciAdi FROM Kullanici";
            KullaniciDogrulama kulls = new KullaniciDogrulama();
            Kullanici kull = new Kullanici();
            string kels = this.kullaniciAdi;
            try
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand(sqlPerson, conn);
                OleDbDataReader reader = null;
                reader = command.ExecuteReader();
                bool dogrulama = false;
                while (reader.Read())
                {
                    if (kels == reader[0].ToString())
                    {
                        label5.Text = kels;
                    }
                }

                if (!dogrulama)
                {
                    MessageBox.Show("Doğrulama başarısız", "Hatalı Bilgiler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }*/

        }

        public Kullanici(string kullaniciAdi, string parola)
        {
            this.kullaniciAdi = kullaniciAdi;
            this.parola = parola;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uzerimdekiler win = new Uzerimdekiler(this.kullaniciAdi);
            win.ShowDialog();
        }

        private void kullaniciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kullaniciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.deneme1DataSet);

        }

        private void Kullanici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'deneme1DataSet.Kullanici' table. You can move, or remove it, as needed.
            this.kullaniciTableAdapter.Fill(this.deneme1DataSet.Kullanici);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
           

        }

        private void label5_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arama arama = new Arama();
            arama.Show();
        }
    }
}
