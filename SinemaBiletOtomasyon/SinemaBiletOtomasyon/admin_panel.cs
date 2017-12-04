using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SinemaBiletOtomasyon
{
    public partial class admin_panel : Form
    {
        public admin_panel()
        {
            InitializeComponent();
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Kullanıcı_Girişi nesne = new Kullanıcı_Girişi();
            nesne.Show();
            this.Hide();
        }

        private void btn_FilmListele_Click(object sender, EventArgs e)
        {
            Filmleri_Listele nesne = new Filmleri_Listele();
            nesne.Show();
            this.Hide();
        }

        private void btn_KullanıcıListele_Click(object sender, EventArgs e)
        {
            Kullanıcı_Listele nesne = new Kullanıcı_Listele();
            nesne.Show();
            this.Hide();
        }

        private void btn_FilmGüncelle_Click(object sender, EventArgs e)
        {
            Filmleri_Güncelle nesne = new Filmleri_Güncelle();
            nesne.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Satın_Alma_Gecmisi nesne = new Satın_Alma_Gecmisi();
            nesne.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayıtSil nesne = new KayıtSil();
            nesne.Show();
            this.Hide();
        }
    }
}
