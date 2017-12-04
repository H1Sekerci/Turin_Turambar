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
    public partial class Kullanıcı_Listele : Form
    {
        SQLiteConnection baglanti;
        SQLiteDataAdapter da;
        DataSet ds;
        string connectionstring;
        public Kullanıcı_Listele()
        {
            InitializeComponent();
            connectionstring = @" Data Source = DBSinemaSatis.db";
        }

        private void Kullanıcı_Listele_Load(object sender, EventArgs e)
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
