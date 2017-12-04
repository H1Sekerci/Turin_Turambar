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
    public partial class Filmleri_Güncelle : Form
    {
        SQLiteConnection baglanti;
        SQLiteCommand cmd;
        SQLiteDataAdapter da;
        DataSet ds;
        string connectionstring;
        public Filmleri_Güncelle()
        {
            InitializeComponent();
            connectionstring = @"Data Source = DBSinemaSatis.db";
        }

        private void Filmleri_Güncelle_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        
            
       

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionstring))
                {

                    cmd = new SQLiteCommand();
                    cmd.CommandText = "UPDATE tblFilmler SET FilmAdi='" + textBox2.Text + "', Seanslar='" + textBox4.Text + "', SalonNo=" + textBox3.Text + " Where FilmID=" + textBox1.Text + "";
                    cmd.Connection = con;
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        Griddoldur();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme Başarısız Oldu", "Film Güncelleme");
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

        private void button1_Click(object sender, EventArgs e)
        {
            admin_panel nesne = new admin_panel();
            nesne.Show();
            this.Hide();
        }
    }
}
