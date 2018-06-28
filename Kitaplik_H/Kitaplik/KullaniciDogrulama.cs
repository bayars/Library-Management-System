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
    public partial class KullaniciDogrulama : Form
    {
        public KullaniciDogrulama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source=Deneme1.accdb";
            string sqlPerson = "SELECT KullaniciAdi, Parola FROM Kullanici";
            try
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand(sqlPerson, conn);
                OleDbDataReader reader = null;
                reader = command.ExecuteReader();
                bool dogrulama = false;
                while (reader.Read())
                {
                    if (textBox1.Text == reader[0].ToString() && textBox2.Text == reader[1].ToString())
                    {
                        dogrulama = true;
                        MessageBox.Show("Giris Basarili", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Kullanici kull = new Kullanici(textBox1.Text, textBox2.Text);
                        kull.ShowDialog();
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
            }

            /*

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Lutfen kullanici adinizi ve parolanizi giriniz.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
                }
                try
                {
                    Deneme1DataSetTableAdapters.KullaniciTableAdapter user = new Deneme1DataSetTableAdapters.KullaniciTableAdapter();
                    Deneme1DataSet.KullaniciDataTable dt = user.GetDataByKullaniciAdiParola(textBox1.Text, textBox2.Text);
                    if(dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Giris Basarili","Mesaj" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Kullanici kullanici = new Kullanici();
                        kullanici.Show();
                    }
                    else
                    {
                        MessageBox.Show("Giris hatali! Lutfen kullanici adi ve parolanizi kontrol ediniz", "Mesaj", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }


                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar == (char)13)
            {
                textBox2.Focus();
            }*/
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void KullaniciDogrulama_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }
