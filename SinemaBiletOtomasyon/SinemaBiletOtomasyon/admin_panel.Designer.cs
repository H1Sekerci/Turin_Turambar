namespace SinemaBiletOtomasyon
{
    partial class admin_panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_FilmListele = new System.Windows.Forms.Button();
            this.btn_FilmGüncelle = new System.Windows.Forms.Button();
            this.btn_KullanıcıListele = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_FilmListele
            // 
            this.btn_FilmListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_FilmListele.Location = new System.Drawing.Point(41, 33);
            this.btn_FilmListele.Name = "btn_FilmListele";
            this.btn_FilmListele.Size = new System.Drawing.Size(199, 29);
            this.btn_FilmListele.TabIndex = 0;
            this.btn_FilmListele.Text = "Vizyondaki Filmleri Listele";
            this.btn_FilmListele.UseVisualStyleBackColor = true;
            this.btn_FilmListele.Click += new System.EventHandler(this.btn_FilmListele_Click);
            // 
            // btn_FilmGüncelle
            // 
            this.btn_FilmGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_FilmGüncelle.Location = new System.Drawing.Point(41, 89);
            this.btn_FilmGüncelle.Name = "btn_FilmGüncelle";
            this.btn_FilmGüncelle.Size = new System.Drawing.Size(199, 29);
            this.btn_FilmGüncelle.TabIndex = 1;
            this.btn_FilmGüncelle.Text = "Vizyondaki Filmleri Güncelle";
            this.btn_FilmGüncelle.UseVisualStyleBackColor = true;
            this.btn_FilmGüncelle.Click += new System.EventHandler(this.btn_FilmGüncelle_Click);
            // 
            // btn_KullanıcıListele
            // 
            this.btn_KullanıcıListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KullanıcıListele.Location = new System.Drawing.Point(41, 148);
            this.btn_KullanıcıListele.Name = "btn_KullanıcıListele";
            this.btn_KullanıcıListele.Size = new System.Drawing.Size(199, 29);
            this.btn_KullanıcıListele.TabIndex = 2;
            this.btn_KullanıcıListele.Text = "Üyeleri Listele";
            this.btn_KullanıcıListele.UseVisualStyleBackColor = true;
            this.btn_KullanıcıListele.Click += new System.EventHandler(this.btn_KullanıcıListele_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(41, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Üye Kaydı Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(41, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Satın Alım Geçmişini Görüntüle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Geri
            // 
            this.btn_Geri.Image = global::SinemaBiletOtomasyon.Properties.Resources.geri;
            this.btn_Geri.Location = new System.Drawing.Point(265, 12);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(41, 36);
            this.btn_Geri.TabIndex = 3;
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 300);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_KullanıcıListele);
            this.Controls.Add(this.btn_FilmGüncelle);
            this.Controls.Add(this.btn_FilmListele);
            this.Name = "admin_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_FilmListele;
        private System.Windows.Forms.Button btn_FilmGüncelle;
        private System.Windows.Forms.Button btn_KullanıcıListele;
        private System.Windows.Forms.Button btn_Geri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}