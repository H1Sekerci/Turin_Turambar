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
    public partial class Filmleri_Listele : Form
    {
            SQLiteConnection baglanti;
            SQLiteDataAdapter da;
            DataSet ds;
            string connectionstring;
        public Filmleri_Listele()
        {
            InitializeComponent();
            connectionstring = @" Data Source = DBSinemaSatis.db";
        }

        private void Filmleri_Listele_Load(object sender, EventArgs e)
        {
            Griddoldur();
        }

        private void Griddoldur()
        {
            try
            {
                baglanti = new SQLiteConnection(connectionstring);
                da = new SQLiteDataAdapter("Select *from tblFilmler ", baglanti);
                ds = new DataSet();
                baglanti.Open();
                da.Fill(ds, "tblFilmler");
                dataGridView1.DataSource = ds.Tables["tblFilmler"];
                baglanti.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bir hata ile karşılaşıldı");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SQLiteConnection(connectionstring);
                da = new SQLiteDataAdapter("Select *from tblFilmler where FilmAdi like '" + textBox1.Text + "%'", baglanti);
                ds = new DataSet();
                baglanti.Open();
                da.Fill(ds, "tblFilmler");
                dataGridView1.DataSource = ds.Tables["tblFilmler"];
                baglanti.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bir hata ile karşılaşıldı");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_panel nesne = new admin_panel();
            nesne.Show();
            this.Hide();
        }
    }
}
