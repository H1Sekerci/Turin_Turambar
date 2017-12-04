using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SinemaBiletOtomasyon
{
    public partial class KayıtSil : Form
    {
        SQLiteConnection baglanti;
        SQLiteDataAdapter da;
        DataSet ds;
        SQLiteCommand cmd;
        string connectionstring;
        public KayıtSil()
        {
            InitializeComponent();
            connectionstring = @" Data Source = DBSinemaSatis.db";
        }

        private void KayıtSil_Load(object sender, EventArgs e)
        {
            Griddoldur();
        }

        private void Griddoldur()
        {
            try
            {
                baglanti = new SQLiteConnection(connectionstring);
                da = new SQLiteDataAdapter("Select *from tblKullaniciGirisi Where YetkiID NOT LIKE 1", baglanti);
                ds = new DataSet();
                baglanti.Open();
                da.Fill(ds, "tblKullaniciGirisi");
                dataGridView1.DataSource = ds.Tables["tblKullaniciGirisi"];
                baglanti.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bir hata ile karşılaşıldı");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionstring))
                {

                    cmd = new SQLiteCommand();
                    cmd.CommandText = "DELETE FROM tblKullaniciGirisi Where KullaniciAdi='" + label3.Text + "'AND Sifre=" + label4.Text;
                    cmd.Connection = con;
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        Griddoldur();
                    }
                    else
                    {
                        MessageBox.Show("Müşteri kayıt Silme işlemi başarız oldu", "Müşteri kaydı silme");
                    }
                    con.Close();
                    cmd.Dispose();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bir hata ile karşılaşıldı");
            }
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_panel nesne = new admin_panel();
            nesne.Show();
            this.Hide();
        }
    }
}
