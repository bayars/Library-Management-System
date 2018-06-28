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
    public partial class PersonelDogrulama : Form
    {
        public PersonelDogrulama()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source=Deneme1.accdb";
            string sqlPerson = "SELECT PersonelAdi, Parola FROM Personel";
            try
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand(sqlPerson, conn);
                OleDbDataReader reader = null;
                reader = command.ExecuteReader();
                bool dogrulama = false;
                while(reader.Read())
                {
                    if(textUsername.Text == reader[0].ToString() && textPasword.Text == reader[1].ToString())
                    {
                        dogrulama = true;
                        MessageBox.Show("Giris Basarili","Tamam",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Personel pers = new Personel();
                        pers.ShowDialog();
                    }
                }

                if(!dogrulama)
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

        }

        private void textUsername_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textPasword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
