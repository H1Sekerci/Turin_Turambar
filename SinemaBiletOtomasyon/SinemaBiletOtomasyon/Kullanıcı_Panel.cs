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
    public partial class Bilet_Al : Form
    {
        SQLiteCommand cmd;
        string connectionstring;
        
        
        int tam_toplam = 0;
        int ogrenci_toplam = 0;
        int toplam = 0;
        public Bilet_Al()
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
                    cmd.CommandText = "INSERT INTO tblMusteri (MusteriAdi,MusteriSoyad,MusteriTel,GirdigiFilmAdi,SalonNo,SeansSaat,AlinanTutar) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + label16.Text + "')";
                    cmd.Connection = con;
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Satın alma işlemi başarıyla gerçekleştirildi", "Satın alma işlemi");
                        Kullanıcı_Girişi nesne = new Kullanıcı_Girişi();
                        nesne.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Satın alma işlemi başarısız oldu", "Satın alma işlemi");
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

       

        private void Bilet_Al_Load(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionstring))
                {
                    SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM tblFilmler", con);
                    DataTable dt = new DataTable();
                    con.Open();
                    da.Fill(dt);
                    comboBox1.DataSource = dt;
                    comboBox1.ValueMember = "FilmID";
                    comboBox1.DisplayMember = "FilmAdi";
                    con.Close();
                    textBox4.Text = "1";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bir hata ile karşılaşıldı");
            }
           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    textBox4.Text = "1";
                    using (SQLiteConnection con = new SQLiteConnection(connectionstring))
                    {
                        SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM tblSeanslar  Where FilmID=1", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        da.Fill(dt);
                        comboBox2.DataSource = dt;
                        comboBox2.ValueMember = "FilmID";
                        comboBox2.DisplayMember = "SeansSaat";
                        con.Close();
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    textBox4.Text = "2";
                    using (SQLiteConnection con = new SQLiteConnection(connectionstring))
                    {
                        SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM tblSeanslar Where FilmID=2", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        da.Fill(dt);
                        comboBox2.DataSource = dt;
                        comboBox2.ValueMember = "FilmID";
                        comboBox2.DisplayMember = "SeansSaat";
                        con.Close();
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    textBox4.Text = "3";
                    using (SQLiteConnection con = new SQLiteConnection(connectionstring))
                    {
                        SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM tblSeanslar  Where FilmID=3", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        da.Fill(dt);
                        comboBox2.DataSource = dt;
                        comboBox2.ValueMember = "FilmID";
                        comboBox2.DisplayMember = "SeansSaat";
                        con.Close();
                    }
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    textBox4.Text = "4";
                    using (SQLiteConnection con = new SQLiteConnection(connectionstring))
                    {
                        SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM tblSeanslar  Where FilmID=4", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        da.Fill(dt);
                        comboBox2.DataSource = dt;
                        comboBox2.ValueMember = "FilmID";
                        comboBox2.DisplayMember = "SeansSaat";
                        con.Close();
                    }
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    textBox4.Text = "5";
                    using (SQLiteConnection con = new SQLiteConnection(connectionstring))
                    {
                        SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM tblSeanslar  Where FilmID=5", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        da.Fill(dt);
                        comboBox2.DataSource = dt;
                        comboBox2.ValueMember = "FilmID";
                        comboBox2.DisplayMember = "SeansSaat";
                        con.Close();
                    }
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    textBox4.Text = "6";
                    using (SQLiteConnection con = new SQLiteConnection(connectionstring))
                    {
                        SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM tblSeanslar  Where FilmID=6", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        da.Fill(dt);
                        comboBox2.DataSource = dt;
                        comboBox2.ValueMember = "FilmID";
                        comboBox2.DisplayMember = "SeansSaat";
                        con.Close();
                    }
                }
                else if (comboBox1.SelectedIndex == 6)
                {
                    textBox4.Text = "7";
                    using (SQLiteConnection con = new SQLiteConnection(connectionstring))
                    {
                        SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM tblSeanslar  Where FilmID=7", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        da.Fill(dt);
                        comboBox2.DataSource = dt;
                        comboBox2.ValueMember = "FilmID";
                        comboBox2.DisplayMember = "SeansSaat";
                        con.Close();
                    }
                }
                else if (comboBox1.SelectedIndex == 7)
                {
                    textBox4.Text = "8";
                    using (SQLiteConnection con = new SQLiteConnection(connectionstring))
                    {
                        SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM tblSeanslar  Where FilmID=8", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        da.Fill(dt);
                        comboBox2.DataSource = dt;
                        comboBox2.ValueMember = "FilmID";
                        comboBox2.DisplayMember = "SeansSaat";
                        con.Close();
                    }
                }
                else if (comboBox1.SelectedIndex == 8)
                {
                    textBox4.Text = "9";
                    using (SQLiteConnection con = new SQLiteConnection(connectionstring))
                    {
                        SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM tblSeanslar  Where FilmID=9", con);
                        DataTable dt = new DataTable();
                        con.Open();
                        da.Fill(dt);
                        comboBox2.DataSource = dt;
                        comboBox2.ValueMember = "FilmID";
                        comboBox2.DisplayMember = "SeansSaat";
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bir hata ile karşılaşıldı");
            }
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int ogrencibilet_sayısı;
                int degerogr, degertam;

                if (textBox5.Text == "")
                {
                    textBox5.Clear();
                    label13.Text = "0";
                }
                else
                {
                    if (checkBox1.Checked == true)
                    {
                        ogrenci_toplam = 0;
                        ogrencibilet_sayısı = Convert.ToInt32(textBox5.Text);
                        ogrenci_toplam = 16 * ogrencibilet_sayısı;
                        label13.Text = ogrenci_toplam.ToString();
                        degerogr = Convert.ToInt32(label13.Text);
                        degertam = Convert.ToInt32(label14.Text);
                        toplam = degerogr + degertam;
                        label16.Text = toplam.ToString();

                    }

                }   
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bir hata ile karşılaşıldı");
            }
           
        }

        

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '\b':
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
             try
            {
                int degerogr, degertam;
                int tambilet_sayısı;
                if (textBox6.Text == "")
                {
                    textBox6.Clear();
                    label14.Text = "0";

                }
                else
                {
                    if (checkBox2.Checked == true)
                    {
                        tam_toplam = 0;
                        tambilet_sayısı = Convert.ToInt32(textBox6.Text);
                        tam_toplam = 20 * tambilet_sayısı;
                        label14.Text = tam_toplam.ToString();
                        degerogr = Convert.ToInt32(label13.Text);
                        degertam = Convert.ToInt32(label14.Text);
                        toplam = degerogr + degertam;
                        label16.Text = toplam.ToString();
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bir hata ile karşılaşıldı");
            }
            
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '\b':
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }
        
    }
}
