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
    public partial class Kullanıcı_Girişi : Form
    {
        string connectionstring;
        SQLiteCommand cmd;
        SQLiteDataReader dr;
        public Kullanıcı_Girişi()
        {
            InitializeComponent();
            connectionstring = @" Data Source = DBSinemaSatis.db";
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(connectionstring))
            {
                try
                {
                    string ad = textBox1.Text;
                    string sifre = textBox2.Text;
                    string Yetki_No;
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        cmd = new SQLiteCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT * FROM tblKullaniciGirisi where KullaniciAdi ='" + ad + "' AND Sifre='" + sifre + "'";
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Yetki_No = dr["YetkiID"].ToString();
                            if (Yetki_No == "1")
                            {
                                admin_panel f2 = new admin_panel();
                                f2.Show();
                                Hide();
                            }
                            else if (Yetki_No == "2")
                            {
                                Bilet_Al f2 = new Bilet_Al();
                                f2.Show();
                                Hide();
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                        }
                    }
                    cmd.Dispose();
                    dr.Dispose();
                    con.Close();
                   
                }
                catch (Exception)
                {

                    MessageBox.Show("Veritabanı ile bağlantı kurulamıyor...");

                }

            }
        }

        private void btn_Kayıt_Click(object sender, EventArgs e)
        {
            Yeni_Kayıt nesne = new Yeni_Kayıt();
            nesne.Show();
            this.Hide();
        }
    }
}
