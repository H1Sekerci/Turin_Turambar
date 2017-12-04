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
    public partial class Satın_Alma_Gecmisi : Form
    {
        SQLiteConnection baglanti;
        SQLiteDataAdapter da;
        DataSet ds;
        string connectionstring;
        public Satın_Alma_Gecmisi()
        {
            InitializeComponent();
            connectionstring = @" Data Source = DBSinemaSatis.db";
        }

        private void Satın_Alma_Gecmisi_Load(object sender, EventArgs e)
        {
            Griddoldur();
        }

        private void Griddoldur()
        {
            try
            {
                baglanti = new SQLiteConnection(connectionstring);
                da = new SQLiteDataAdapter("SELECT * FROM tblMusteri", baglanti);
                ds = new DataSet();
                baglanti.Open();
                da.Fill(ds, "tblMusteri");
                dataGridView1.DataSource = ds.Tables["tblMusteri"];
                baglanti.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bir Hata ile Karşılaşıldı");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti = new SQLiteConnection(connectionstring);
                da = new SQLiteDataAdapter("Select *from tblKullaniciGirisi where KullaniciAdi like '" + textBox1.Text + "%' AND YetkiID NOT LIKE 1", baglanti);
                ds = new DataSet();
                baglanti.Open();
                da.Fill(ds, "tblKullaniciGirisi");
                dataGridView1.DataSource = ds.Tables["tblKullaniciGirisi"];
                baglanti.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bir Hata ile Karşılaşıldı");
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
