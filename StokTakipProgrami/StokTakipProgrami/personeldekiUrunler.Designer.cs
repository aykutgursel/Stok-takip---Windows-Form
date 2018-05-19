namespace StokTakipProgrami
{
    partial class personeldekiUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personeldekiUrunler));
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_urunAdi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_kimeV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_kacAdet = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_aciklama = new System.Windows.Forms.TextBox();
            this.lstv_Personel = new System.Windows.Forms.ListView();
            this.urunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tarihhh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saatttt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.lstvw_StokTakip = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mevcutStok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eldeOlan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Saat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tarihh = new System.Windows.Forms.Label();
            this.saatt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.yonetici = new System.Windows.Forms.Label();
            this.tx_parola = new System.Windows.Forms.TextBox();
            this.Sil = new System.Windows.Forms.Button();
            this.silme_paneli = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sill = new System.Windows.Forms.Button();
            this.btn_ac = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_bilgi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kacAdet)).BeginInit();
            this.silme_paneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı :";
            // 
            // cbx_urunAdi
            // 
            this.cbx_urunAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_urunAdi.FormattingEnabled = true;
            this.cbx_urunAdi.Location = new System.Drawing.Point(99, 27);
            this.cbx_urunAdi.Name = "cbx_urunAdi";
            this.cbx_urunAdi.Size = new System.Drawing.Size(170, 21);
            this.cbx_urunAdi.TabIndex = 2;
            this.cbx_urunAdi.SelectedIndexChanged += new System.EventHandler(this.cbx_urunAdi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kime Verildi :";
            // 
            // tx_kimeV
            // 
            this.tx_kimeV.Location = new System.Drawing.Point(99, 54);
            this.tx_kimeV.MaxLength = 30;
            this.tx_kimeV.Multiline = true;
            this.tx_kimeV.Name = "tx_kimeV";
            this.tx_kimeV.Size = new System.Drawing.Size(170, 27);
            this.tx_kimeV.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kaç Adet Verildi :";
            // 
            // nud_kacAdet
            // 
            this.nud_kacAdet.Location = new System.Drawing.Point(99, 95);
            this.nud_kacAdet.Name = "nud_kacAdet";
            this.nud_kacAdet.ReadOnly = true;
            this.nud_kacAdet.Size = new System.Drawing.Size(91, 20);
            this.nud_kacAdet.TabIndex = 7;
            this.nud_kacAdet.ValueChanged += new System.EventHandler(this.nud_kacAdet_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(99, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Klavyeden Gir";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Açıklama :";
            // 
            // tx_aciklama
            // 
            this.tx_aciklama.Location = new System.Drawing.Point(99, 149);
            this.tx_aciklama.Multiline = true;
            this.tx_aciklama.Name = "tx_aciklama";
            this.tx_aciklama.Size = new System.Drawing.Size(170, 55);
            this.tx_aciklama.TabIndex = 10;
            // 
            // lstv_Personel
            // 
            this.lstv_Personel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urunAdi,
            this.Kime,
            this.adet,
            this.aciklama,
            this.tarihhh,
            this.saatttt});
            this.lstv_Personel.FullRowSelect = true;
            this.lstv_Personel.GridLines = true;
            this.lstv_Personel.Location = new System.Drawing.Point(276, 28);
            this.lstv_Personel.MultiSelect = false;
            this.lstv_Personel.Name = "lstv_Personel";
            this.lstv_Personel.Size = new System.Drawing.Size(699, 212);
            this.lstv_Personel.TabIndex = 16;
            this.lstv_Personel.UseCompatibleStateImageBehavior = false;
            this.lstv_Personel.View = System.Windows.Forms.View.Details;
            this.lstv_Personel.SelectedIndexChanged += new System.EventHandler(this.lstv_Personel_SelectedIndexChanged);
            // 
            // urunAdi
            // 
            this.urunAdi.Text = "Ürün Adı";
            this.urunAdi.Width = 129;
            // 
            // Kime
            // 
            this.Kime.Text = "Kime Verildi";
            this.Kime.Width = 108;
            // 
            // adet
            // 
            this.adet.Text = "Kaç Adet Verildi";
            this.adet.Width = 133;
            // 
            // aciklama
            // 
            this.aciklama.Text = "Açıklama";
            this.aciklama.Width = 130;
            // 
            // tarihhh
            // 
            this.tarihhh.Text = "Tarih ";
            this.tarihhh.Width = 101;
            // 
            // saatttt
            // 
            this.saatttt.Text = "Saat";
            this.saatttt.Width = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "( 30 Karakter )";
            // 
            // lstvw_StokTakip
            // 
            this.lstvw_StokTakip.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.mevcutStok,
            this.eldeOlan,
            this.fiyat,
            this.Saat,
            this.Tarih});
            this.lstvw_StokTakip.Enabled = false;
            this.lstvw_StokTakip.Location = new System.Drawing.Point(276, 246);
            this.lstvw_StokTakip.MultiSelect = false;
            this.lstvw_StokTakip.Name = "lstvw_StokTakip";
            this.lstvw_StokTakip.Size = new System.Drawing.Size(699, 201);
            this.lstvw_StokTakip.TabIndex = 18;
            this.lstvw_StokTakip.UseCompatibleStateImageBehavior = false;
            this.lstvw_StokTakip.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı ";
            this.columnHeader1.Width = 109;
            // 
            // mevcutStok
            // 
            this.mevcutStok.Text = "Mevcut Stok";
            this.mevcutStok.Width = 110;
            // 
            // eldeOlan
            // 
            this.eldeOlan.Text = "Elde Olan Ürün";
            this.eldeOlan.Width = 120;
            // 
            // fiyat
            // 
            this.fiyat.Text = "Adet Fiyatı";
            this.fiyat.Width = 120;
            // 
            // Saat
            // 
            this.Saat.DisplayIndex = 5;
            this.Saat.Text = "Kaydedilen Saat";
            this.Saat.Width = 113;
            // 
            // Tarih
            // 
            this.Tarih.DisplayIndex = 4;
            this.Tarih.Text = "Kaydedilen Tarih";
            this.Tarih.Width = 117;
            // 
            // tarihh
            // 
            this.tarihh.AutoSize = true;
            this.tarihh.Location = new System.Drawing.Point(311, 9);
            this.tarihh.Name = "tarihh";
            this.tarihh.Size = new System.Drawing.Size(35, 13);
            this.tarihh.TabIndex = 19;
            this.tarihh.Text = "label7";
            // 
            // saatt
            // 
            this.saatt.AutoSize = true;
            this.saatt.Location = new System.Drawing.Point(510, 9);
            this.saatt.Name = "saatt";
            this.saatt.Size = new System.Drawing.Size(35, 13);
            this.saatt.TabIndex = 20;
            this.saatt.Text = "label7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tarih :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Saat :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Tümünü Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // yonetici
            // 
            this.yonetici.AutoSize = true;
            this.yonetici.Location = new System.Drawing.Point(8, 7);
            this.yonetici.Name = "yonetici";
            this.yonetici.Size = new System.Drawing.Size(82, 13);
            this.yonetici.TabIndex = 24;
            this.yonetici.Text = "Yönetici Şifresi :";
            // 
            // tx_parola
            // 
            this.tx_parola.Location = new System.Drawing.Point(91, 3);
            this.tx_parola.Name = "tx_parola";
            this.tx_parola.PasswordChar = '•';
            this.tx_parola.Size = new System.Drawing.Size(93, 20);
            this.tx_parola.TabIndex = 25;
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(189, 2);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(29, 23);
            this.Sil.TabIndex = 26;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click_1);
            // 
            // silme_paneli
            // 
            this.silme_paneli.Controls.Add(this.button3);
            this.silme_paneli.Controls.Add(this.yonetici);
            this.silme_paneli.Controls.Add(this.Sil);
            this.silme_paneli.Controls.Add(this.tx_parola);
            this.silme_paneli.Location = new System.Drawing.Point(668, 1);
            this.silme_paneli.Name = "silme_paneli";
            this.silme_paneli.Size = new System.Drawing.Size(283, 26);
            this.silme_paneli.TabIndex = 27;
            this.silme_paneli.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 22);
            this.button3.TabIndex = 28;
            this.button3.Text = "Gizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackgroundImage = global::StokTakipProgrami.Properties.Resources.temizle;
            this.btn_temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_temizle.Location = new System.Drawing.Point(208, 87);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(61, 48);
            this.btn_temizle.TabIndex = 29;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_sill
            // 
            this.btn_sill.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sill.BackgroundImage")));
            this.btn_sill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sill.Enabled = false;
            this.btn_sill.Location = new System.Drawing.Point(115, 214);
            this.btn_sill.Name = "btn_sill";
            this.btn_sill.Size = new System.Drawing.Size(77, 52);
            this.btn_sill.TabIndex = 28;
            this.btn_sill.UseVisualStyleBackColor = false;
            this.btn_sill.Click += new System.EventHandler(this.btn_sill_Click);
            // 
            // btn_ac
            // 
            this.btn_ac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ac.BackgroundImage")));
            this.btn_ac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ac.Location = new System.Drawing.Point(71, 272);
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(77, 56);
            this.btn_ac.TabIndex = 15;
            this.btn_ac.UseVisualStyleBackColor = true;
            this.btn_ac.Click += new System.EventHandler(this.btn_ac_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.BackgroundImage")));
            this.btn_kaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_kaydet.Location = new System.Drawing.Point(154, 272);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(77, 56);
            this.btn_kaydet.TabIndex = 14;
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.BackgroundImage")));
            this.btn_guncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_guncelle.Enabled = false;
            this.btn_guncelle.Location = new System.Drawing.Point(195, 214);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(77, 52);
            this.btn_guncelle.TabIndex = 13;
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ekle.BackgroundImage")));
            this.btn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ekle.Location = new System.Drawing.Point(32, 214);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(77, 52);
            this.btn_ekle.TabIndex = 11;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            this.btn_ekle.Enter += new System.EventHandler(this.btn_ekle_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(4, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "Bilgi :";
            // 
            // lbl_bilgi
            // 
            this.lbl_bilgi.AutoSize = true;
            this.lbl_bilgi.Location = new System.Drawing.Point(42, 7);
            this.lbl_bilgi.Name = "lbl_bilgi";
            this.lbl_bilgi.Size = new System.Drawing.Size(0, 13);
            this.lbl_bilgi.TabIndex = 31;
            // 
            // personeldekiUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 476);
            this.Controls.Add(this.lbl_bilgi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_sill);
            this.Controls.Add(this.silme_paneli);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.saatt);
            this.Controls.Add(this.tarihh);
            this.Controls.Add(this.lstvw_StokTakip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstv_Personel);
            this.Controls.Add(this.btn_ac);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.tx_aciklama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.nud_kacAdet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_kimeV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_urunAdi);
            this.Controls.Add(this.label1);
            this.Name = "personeldekiUrunler";
            this.Text = "Personeldeki Ürünler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.personeldekiUrunler_FormClosing);
            this.Load += new System.EventHandler(this.personeldekiUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_kacAdet)).EndInit();
            this.silme_paneli.ResumeLayout(false);
            this.silme_paneli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_urunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_kimeV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.NumericUpDown nud_kacAdet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_aciklama;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_ac;
        private System.Windows.Forms.ListView lstv_Personel;
        private System.Windows.Forms.ColumnHeader urunAdi;
        private System.Windows.Forms.ColumnHeader Kime;
        private System.Windows.Forms.ColumnHeader adet;
        private System.Windows.Forms.ColumnHeader aciklama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lstvw_StokTakip;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader mevcutStok;
        private System.Windows.Forms.ColumnHeader eldeOlan;
        private System.Windows.Forms.ColumnHeader fiyat;
        private System.Windows.Forms.ColumnHeader Saat;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.Label tarihh;
        private System.Windows.Forms.Label saatt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader tarihhh;
        private System.Windows.Forms.ColumnHeader saatttt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label yonetici;
        private System.Windows.Forms.TextBox tx_parola;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Panel silme_paneli;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_sill;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_bilgi;
    }
}