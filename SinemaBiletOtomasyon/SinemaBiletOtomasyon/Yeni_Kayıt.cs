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
    public partial class Yeni_Kayıt : Form
    {
        SQLiteCommand cmd;
        string connectionstring;

        public Yeni_Kayıt()
        {
            InitializeComponent();
            connectionstring = @"Data Source = DBSinemaSatis.db";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionstring))
                {

                    cmd = new SQLiteCommand();
                    cmd.CommandText = "INSERT INTO tblKullaniciGirisi (YetkiID,KullaniciAdi,Sifre) VALUES ('2','" + textBox1.Text + "','" + textBox2.Text + "')";
                    cmd.Connection = con;
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Kayıt başarılı..", "Yeni üye kaydı");
                        Kullanıcı_Girişi nesne = new Kullanıcı_Girişi();
                        nesne.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Başarısız Oldu", "Yeni üye kaydı");
                    }
                    con.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bir Hata ile Karşılaşıldı");
            }
           
        }

        private void Yeni_Kayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
