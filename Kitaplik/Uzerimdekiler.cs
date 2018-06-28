using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kitaplik
{
    public partial class Uzerimdekiler : Form
    {
        private int Id;
        private string kullaniciAdi;
        private string mailAdresi;
        private string sahiplikler;


        public Uzerimdekiler(string kullaniciAdi)
        {
            this.kullaniciAdi = kullaniciAdi;
            InitializeComponent();
            UzerimdekilerDoldur();
        }

        private void UzerimdekilerDoldur()
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source=Deneme1.accdb";
            string kisiSorgu = $"SELECT * FROM Kullanici WHERE KullaniciAdi = '{this.kullaniciAdi}'";

            try
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand(kisiSorgu, conn);
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    this.Id = (int)reader[0];
                    this.kullaniciAdi = reader[1].ToString();
                    this.mailAdresi = reader[4].ToString();
                    this.sahiplikler = reader[5].ToString();
                    this.SahiplikleriDoldur();
                } else
                {
                    MessageBox.Show("Kullanıcı verileri bulunamadı.");
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

        //private void SahiplikCikar (string cikarilacakSahiplik)
        //{

        //}

        private void SahiplikleriDoldur ()
        {
            string[] uzerindekiler = this.sahiplikler.Split(new string[] { "," }, StringSplitOptions.None);

            int i = 0;
            foreach (String uzerindeki in uzerindekiler)
            {
                string tur = uzerindeki.Substring(0,1);
                string uzunTur = "Kitap";

                switch(tur)
                {
                    case "K":
                        uzunTur = "Kitap";
                        break;
                    case "M":
                        uzunTur = "Muzik";
                        break;
                    case "D":
                        uzunTur = "Dergi";
                        break;
                    case "F":
                        uzunTur = "Film";
                        break;
                }

                int id = 0;
                Int32.TryParse(uzerindeki.Substring(1), out id);

                System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data source=Deneme1.accdb";
                string kisiSorgu = $"SELECT * FROM {uzunTur} WHERE ID={id}";

                try
                {
                    conn.Open();
                    OleDbCommand command = new OleDbCommand(kisiSorgu, conn);
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int kitapID = (int)reader[0];
                        string kitapAdi = (string)reader[1];
                        //string kitapAdi = reader.GetString(1);

                        uzerimdekilerGrid.Rows.Add();
                        uzerimdekilerGrid.Rows[i].Cells[0].Value = kitapAdi;
                        uzerimdekilerGrid.Rows[i].Cells[1].Value = uzunTur;

                        i++;
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
        }
    }
}
