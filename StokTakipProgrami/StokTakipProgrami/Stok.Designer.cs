namespace StokTakipProgrami
{
    partial class Stok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stok));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_urunAdi = new System.Windows.Forms.TextBox();
            this.nud_EldeOlan = new System.Windows.Forms.NumericUpDown();
            this.chx_Giris = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_Fiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstvw_StokTakip = new System.Windows.Forms.ListView();
            this.urunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mevcutStok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eldeOlan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Saat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tx_mevcutStok = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_toplamFiyat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.chxbx_onarr = new System.Windows.Forms.CheckBox();
            this.lbl_mesaj = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lnklbl_tumunuSil = new System.Windows.Forms.LinkLabel();
            this.silme_paneli = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.yonetici = new System.Windows.Forms.Label();
            this.Sil = new System.Windows.Forms.Button();
            this.tx_parola = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_ac = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_degistir = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_bilgi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_EldeOlan)).BeginInit();
            this.silme_paneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mevcut Stok :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Elde Olan Ürün :";
            // 
            // tx_urunAdi
            // 
            this.tx_urunAdi.Location = new System.Drawing.Point(206, 5);
            this.tx_urunAdi.Name = "tx_urunAdi";
            this.tx_urunAdi.Size = new System.Drawing.Size(100, 20);
            this.tx_urunAdi.TabIndex = 1;
            // 
            // nud_EldeOlan
            // 
            this.nud_EldeOlan.Location = new System.Drawing.Point(622, 5);
            this.nud_EldeOlan.Maximum = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            this.nud_EldeOlan.Name = "nud_EldeOlan";
            this.nud_EldeOlan.ReadOnly = true;
            this.nud_EldeOlan.Size = new System.Drawing.Size(100, 20);
            this.nud_EldeOlan.TabIndex = 3;
            this.nud_EldeOlan.ValueChanged += new System.EventHandler(this.nud_EldeOlan_ValueChanged);
            // 
            // chx_Giris
            // 
            this.chx_Giris.AutoSize = true;
            this.chx_Giris.Location = new System.Drawing.Point(622, 26);
            this.chx_Giris.Name = "chx_Giris";
            this.chx_Giris.Size = new System.Drawing.Size(92, 17);
            this.chx_Giris.TabIndex = 4;
            this.chx_Giris.Text = "Klavyeden Gir";
            this.chx_Giris.UseVisualStyleBackColor = true;
            this.chx_Giris.Click += new System.EventHandler(this.chx_EldeOlan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adet Fiyatı :";
            // 
            // tx_Fiyat
            // 
            this.tx_Fiyat.Location = new System.Drawing.Point(206, 28);
            this.tx_Fiyat.MaxLength = 7;
            this.tx_Fiyat.Name = "tx_Fiyat";
            this.tx_Fiyat.Size = new System.Drawing.Size(100, 20);
            this.tx_Fiyat.TabIndex = 5;
            this.tx_Fiyat.Text = "0";
            this.tx_Fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_Fiyat_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(287, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "₺";
            // 
            // lstvw_StokTakip
            // 
            this.lstvw_StokTakip.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urunAdi,
            this.mevcutStok,
            this.eldeOlan,
            this.fiyat,
            this.Saat,
            this.Tarih});
            this.lstvw_StokTakip.FullRowSelect = true;
            this.lstvw_StokTakip.GridLines = true;
            this.lstvw_StokTakip.Location = new System.Drawing.Point(168, 83);
            this.lstvw_StokTakip.MultiSelect = false;
            this.lstvw_StokTakip.Name = "lstvw_StokTakip";
            this.lstvw_StokTakip.Size = new System.Drawing.Size(724, 364);
            this.lstvw_StokTakip.TabIndex = 11;
            this.lstvw_StokTakip.UseCompatibleStateImageBehavior = false;
            this.lstvw_StokTakip.View = System.Windows.Forms.View.Details;
            this.lstvw_StokTakip.SelectedIndexChanged += new System.EventHandler(this.lstvw_StokTakip_SelectedIndexChanged);
            // 
            // urunAdi
            // 
            this.urunAdi.Text = "Ürün Adı ";
            this.urunAdi.Width = 109;
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
            // tx_mevcutStok
            // 
            this.tx_mevcutStok.Location = new System.Drawing.Point(399, 6);
            this.tx_mevcutStok.MaxLength = 6;
            this.tx_mevcutStok.Name = "tx_mevcutStok";
            this.tx_mevcutStok.Size = new System.Drawing.Size(97, 20);
            this.tx_mevcutStok.TabIndex = 2;
            this.tx_mevcutStok.Text = "1";
            this.tx_mevcutStok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_mevcutStok_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Toplam Fiyat :";
            // 
            // tx_toplamFiyat
            // 
            this.tx_toplamFiyat.Location = new System.Drawing.Point(399, 33);
            this.tx_toplamFiyat.Name = "tx_toplamFiyat";
            this.tx_toplamFiyat.ReadOnly = true;
            this.tx_toplamFiyat.Size = new System.Drawing.Size(100, 20);
            this.tx_toplamFiyat.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Toplam Fiyati Gör";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(483, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "₺";
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Location = new System.Drawing.Point(786, 7);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(0, 13);
            this.lbl_saat.TabIndex = 18;
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Location = new System.Drawing.Point(786, 26);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(0, 13);
            this.lbl_tarih.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 43);
            this.button2.TabIndex = 20;
            this.button2.Text = "Toplam Ürün Sayısı";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chxbx_onarr
            // 
            this.chxbx_onarr.AutoSize = true;
            this.chxbx_onarr.Location = new System.Drawing.Point(622, 43);
            this.chxbx_onarr.Name = "chxbx_onarr";
            this.chxbx_onarr.Size = new System.Drawing.Size(72, 17);
            this.chxbx_onarr.TabIndex = 21;
            this.chxbx_onarr.Text = "10\'ar arttır";
            this.chxbx_onarr.UseVisualStyleBackColor = true;
            this.chxbx_onarr.CheckedChanged += new System.EventHandler(this.chxbx_onarr_CheckedChanged);
            this.chxbx_onarr.Click += new System.EventHandler(this.chxbx_onarr_Click);
            // 
            // lbl_mesaj
            // 
            this.lbl_mesaj.AutoSize = true;
            this.lbl_mesaj.Location = new System.Drawing.Point(247, 60);
            this.lbl_mesaj.Name = "lbl_mesaj";
            this.lbl_mesaj.Size = new System.Drawing.Size(0, 13);
            this.lbl_mesaj.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(743, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tarih :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(745, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Saat :";
            // 
            // lnklbl_tumunuSil
            // 
            this.lnklbl_tumunuSil.AutoSize = true;
            this.lnklbl_tumunuSil.Location = new System.Drawing.Point(179, 61);
            this.lnklbl_tumunuSil.Name = "lnklbl_tumunuSil";
            this.lnklbl_tumunuSil.Size = new System.Drawing.Size(60, 13);
            this.lnklbl_tumunuSil.TabIndex = 27;
            this.lnklbl_tumunuSil.TabStop = true;
            this.lnklbl_tumunuSil.Text = "Tümünü Sil";
            this.lnklbl_tumunuSil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_tumunuSil_LinkClicked);
            this.lnklbl_tumunuSil.Click += new System.EventHandler(this.lnklbl_tumunuSil_Click);
            // 
            // silme_paneli
            // 
            this.silme_paneli.Controls.Add(this.button3);
            this.silme_paneli.Controls.Add(this.yonetici);
            this.silme_paneli.Controls.Add(this.Sil);
            this.silme_paneli.Controls.Add(this.tx_parola);
            this.silme_paneli.Location = new System.Drawing.Point(250, 54);
            this.silme_paneli.Name = "silme_paneli";
            this.silme_paneli.Size = new System.Drawing.Size(279, 25);
            this.silme_paneli.TabIndex = 28;
            this.silme_paneli.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(222, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Gizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(189, 1);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(29, 24);
            this.Sil.TabIndex = 26;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // tx_parola
            // 
            this.tx_parola.Location = new System.Drawing.Point(91, 3);
            this.tx_parola.Name = "tx_parola";
            this.tx_parola.PasswordChar = '•';
            this.tx_parola.Size = new System.Drawing.Size(93, 20);
            this.tx_parola.TabIndex = 25;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Resim Adı";
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_temizle.BackgroundImage")));
            this.btn_temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_temizle.Location = new System.Drawing.Point(85, 5);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(59, 39);
            this.btn_temizle.TabIndex = 26;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_ac
            // 
            this.btn_ac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ac.BackgroundImage")));
            this.btn_ac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ac.Location = new System.Drawing.Point(2, 169);
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(77, 52);
            this.btn_ac.TabIndex = 22;
            this.btn_ac.UseVisualStyleBackColor = true;
            this.btn_ac.Click += new System.EventHandler(this.btn_ac_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackgroundImage = global::StokTakipProgrami.Properties.Resources.kaydet;
            this.btn_kaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_kaydet.Location = new System.Drawing.Point(85, 111);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(77, 52);
            this.btn_kaydet.TabIndex = 0;
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_degistir
            // 
            this.btn_degistir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_degistir.BackgroundImage")));
            this.btn_degistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_degistir.Location = new System.Drawing.Point(2, 111);
            this.btn_degistir.Name = "btn_degistir";
            this.btn_degistir.Size = new System.Drawing.Size(77, 52);
            this.btn_degistir.TabIndex = 10;
            this.btn_degistir.UseVisualStyleBackColor = true;
            this.btn_degistir.Click += new System.EventHandler(this.btn_degistir_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sil.BackgroundImage")));
            this.btn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_sil.Location = new System.Drawing.Point(85, 53);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(77, 52);
            this.btn_sil.TabIndex = 9;
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ekle.BackgroundImage")));
            this.btn_ekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ekle.Location = new System.Drawing.Point(2, 53);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(77, 52);
            this.btn_ekle.TabIndex = 8;
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(535, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Bilgi :";
            // 
            // lbl_bilgi
            // 
            this.lbl_bilgi.AutoSize = true;
            this.lbl_bilgi.Location = new System.Drawing.Point(565, 66);
            this.lbl_bilgi.Name = "lbl_bilgi";
            this.lbl_bilgi.Size = new System.Drawing.Size(0, 13);
            this.lbl_bilgi.TabIndex = 30;
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 458);
            this.Controls.Add(this.lbl_bilgi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.silme_paneli);
            this.Controls.Add(this.lnklbl_tumunuSil);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_mesaj);
            this.Controls.Add(this.btn_ac);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.chxbx_onarr);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_toplamFiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_mevcutStok);
            this.Controls.Add(this.btn_degistir);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.lstvw_StokTakip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_Fiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chx_Giris);
            this.Controls.Add(this.nud_EldeOlan);
            this.Controls.Add(this.tx_urunAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stok";
            this.Text = "Stok";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Stok_FormClosing);
            this.Load += new System.EventHandler(this.Stok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_EldeOlan)).EndInit();
            this.silme_paneli.ResumeLayout(false);
            this.silme_paneli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chx_Giris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_Fiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_degistir;
        public System.Windows.Forms.TextBox tx_urunAdi;
        public System.Windows.Forms.TextBox tx_mevcutStok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_toplamFiyat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chxbx_onarr;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.ColumnHeader urunAdi;
        private System.Windows.Forms.ColumnHeader mevcutStok;
        private System.Windows.Forms.ColumnHeader eldeOlan;
        private System.Windows.Forms.ColumnHeader fiyat;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.ColumnHeader Saat;
        private System.Windows.Forms.Button btn_ac;
        private System.Windows.Forms.Label lbl_mesaj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.NumericUpDown nud_EldeOlan;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.LinkLabel lnklbl_tumunuSil;
        private System.Windows.Forms.Panel silme_paneli;
        private System.Windows.Forms.Label yonetici;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.TextBox tx_parola;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.ListView lstvw_StokTakip;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_bilgi;
    }
}