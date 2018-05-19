using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace StokTakipProgrami
{
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
        }
        int toplamm, mevcutStokk, fiyatt;
        private void Stok_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaForm anaFrm = (AnaForm)this.MdiParent;
            anaFrm.tsb_stok.Enabled = true;
        }

        private void chx_EldeOlan_Click(object sender, EventArgs e)
        {
            if (chx_Giris.Checked == true)
            {
                nud_EldeOlan.ReadOnly = false;
                if (elde > mevcut)
                {
                    MessageBox.Show("Eldeki stok " + tx_mevcutStok.Text + "' dan küçük olmalıdır");

                }
            }
            else
            {
                nud_EldeOlan.ReadOnly = true;
            }
        }

        private void Stok_Load(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.ToLongDateString();
            lbl_tarih.Text = DateTime.Now.ToLongTimeString();

            StreamReader sr = new StreamReader("StokTakip.txt");
            while (true)
            {
                string k = sr.ReadLine();
                if (k == null)
                    break;
                lstvw_StokTakip.Items.Add(new ListViewItem(k.Split('|')));
            }
            sr.Close();
        }


        private void btn_ekle_Click(object sender, EventArgs e)
        {

            if (tx_urunAdi.Text == "" || tx_mevcutStok.Text == "" || tx_Fiyat.Text == "")
            {
                lbl_bilgi.Text = ("Ürün Bilgilerini girmeden Ekleme yapamazsınız");
            }

            else if (elde > mevcut)
            {
                lbl_bilgi.Text = ("Eldeki stok " + tx_mevcutStok.Text + "' dan küçük olmalıdır");
            }
            else
            {       // EĞER HATA YOKSA EKLEME İŞLEMİ YAPIYOR


                lstvw_StokTakip.Items.Add(new ListViewItem(new string[] { tx_urunAdi.Text, tx_mevcutStok.Text, nud_EldeOlan.Value.ToString(), tx_Fiyat.Text, lbl_tarih.Text, lbl_saat.Text }));
                StreamWriter sw = new StreamWriter("StokTakip.txt");
                foreach (ListViewItem l in lstvw_StokTakip.Items)
                {
                    sw.WriteLine(l.SubItems[0].Text + "|" + l.SubItems[1].Text + "|" + l.SubItems[2].Text + "|" + l.SubItems[3].Text + "|" + l.SubItems[4].Text + "|" + l.SubItems[5].Text);

                } sw.Close();

                tx_urunAdi.Clear();
                tx_toplamFiyat.Clear();
                tx_mevcutStok.Clear();
                nud_EldeOlan.Value = 0;
                tx_Fiyat.Clear();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (lstvw_StokTakip.SelectedIndices.Count != 1)
            {
                lbl_bilgi.Text = ("Lütfen Bir Kayıt Seçin!");
                return;
            }
            else
            {
                lstvw_StokTakip.Items.Remove(lstvw_StokTakip.SelectedItems[0]);
                StreamWriter sw = new StreamWriter("StokTakip.txt");
                foreach (ListViewItem l in lstvw_StokTakip.Items)
                {
                    sw.WriteLine(l.SubItems[0].Text + "|" + l.SubItems[1].Text + "|" + l.SubItems[2].Text + "|" + l.SubItems[3].Text + "|" + l.SubItems[4].Text + "|" + l.SubItems[5].Text);
                } sw.Close();

                tx_urunAdi.Clear();
                tx_toplamFiyat.Clear();
                tx_mevcutStok.Clear();
                nud_EldeOlan.Value = 0;
                tx_Fiyat.Clear();

            }
        }

        private void lstvw_StokTakip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvw_StokTakip.SelectedIndices.Count == 1)
            {
                tx_urunAdi.Text = lstvw_StokTakip.SelectedItems[0].SubItems[0].Text;
                tx_mevcutStok.Text = lstvw_StokTakip.SelectedItems[0].SubItems[1].Text;
                nud_EldeOlan.Text = lstvw_StokTakip.SelectedItems[0].SubItems[2].Text;
                tx_Fiyat.Text = lstvw_StokTakip.SelectedItems[0].SubItems[3].Text;
                lbl_saat.Text = lstvw_StokTakip.SelectedItems[0].SubItems[5].Text;
                lbl_tarih.Text = lstvw_StokTakip.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void btn_degistir_Click(object sender, EventArgs e)
        {
            if (lstvw_StokTakip.SelectedIndices.Count != 1)
            {
                lbl_bilgi.Text = ("Güncellenecek Bir Kayıt Seçin!");
                return;
            }
            else
            {
                mevcut = Convert.ToInt32(tx_mevcutStok.Text);
                elde = Convert.ToInt32(nud_EldeOlan.Value.ToString());


                if (elde > mevcut)
                {
                    lbl_bilgi.Text = ("Eldeki stok " + tx_mevcutStok.Text + "' dan küçük olmalıdır");

                }
                else if (tx_urunAdi.Text == "" || tx_mevcutStok.Text == "" || tx_Fiyat.Text == "")
                {
                    MessageBox.Show("Ürün Bilgilerini girmeden Ekleme yapamazsınız");
                }

                else
                {
                    mevcutStokk = Convert.ToInt32(tx_mevcutStok.Text);
                    fiyatt = Convert.ToInt32(tx_Fiyat.Text);
                    toplamm = (mevcutStokk * fiyatt);

                    lstvw_StokTakip.SelectedItems[0].SubItems[0].Text = tx_urunAdi.Text;
                    lstvw_StokTakip.SelectedItems[0].SubItems[1].Text = tx_mevcutStok.Text;
                    lstvw_StokTakip.SelectedItems[0].SubItems[2].Text = nud_EldeOlan.Value.ToString();
                    lstvw_StokTakip.SelectedItems[0].SubItems[3].Text = tx_Fiyat.Text;
                    lstvw_StokTakip.SelectedItems[0].SubItems[4].Text = lbl_tarih.Text;
                    lstvw_StokTakip.SelectedItems[0].SubItems[5].Text = lbl_saat.Text;

                    StreamWriter sw = new StreamWriter("StokTakip.txt");
                    foreach (ListViewItem l in lstvw_StokTakip.Items)
                    {
                        sw.WriteLine(l.SubItems[0].Text + "|" + l.SubItems[1].Text + "|" + l.SubItems[2].Text + "|" + l.SubItems[3].Text + "|" + l.SubItems[4].Text + "|" + l.SubItems[5].Text);

                    }
                    sw.Close();

                    tx_urunAdi.Clear();
                    tx_toplamFiyat.Clear();
                    tx_mevcutStok.Clear();
                    nud_EldeOlan.Value = 0;
                    tx_Fiyat.Clear();
                }
            }
        }

        private void tx_Fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true || (char)Keys.Back == e.KeyChar)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                lbl_bilgi.Text = ("Fiyat Harf Olamaz");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tx_Fiyat.Text == "" || tx_mevcutStok.Text == "")
            {
                lbl_bilgi.Text =("Hesaplanacak değer bulunamadı");
            }
            else
            {
                int toplamm, mevcutStokk, fiyatt;

                mevcutStokk = Convert.ToInt32(tx_mevcutStok.Text);
                fiyatt = Convert.ToInt32(tx_Fiyat.Text);
                toplamm = (mevcutStokk * fiyatt);
                tx_toplamFiyat.Text = toplamm.ToString();
            }
        }

        int elde, mevcut;
        private void nud_EldeOlan_ValueChanged(object sender, EventArgs e)
        {
            if (tx_mevcutStok.Text == "")
            {
                nud_EldeOlan.Value = 0;
            }

            else
            {
                mevcut = Convert.ToInt32(tx_mevcutStok.Text);
                elde = Convert.ToInt32(nud_EldeOlan.Value.ToString());

                if (elde > mevcut)
                {
                     MessageBox.Show("Eldeki stok " + tx_mevcutStok.Text + "' dan küçük olmalıdır");

                }
            }
        }

        private void tx_mevcutStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true || (char)Keys.Back == e.KeyChar)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                lbl_bilgi.Text = ("Stok Harf Olamaz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = lstvw_StokTakip.Items.Count;
            MessageBox.Show(sayi + " Ürün Bulunmaktadır.");
            lbl_bilgi.Text = (sayi + " Ürün Bulunmaktadır.");
        }

        private void chxbx_onar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chxbx_onar_Click(object sender, EventArgs e)
        {

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Döküman Dosyası|*.txt|Tüm Dosyalar |*.*";
            sfd.FileName = "Döküman";
            sfd.Title = "Kaydetme Penceresi";
            DialogResult dr = sfd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);

                foreach (ListViewItem item in lstvw_StokTakip.Items)
                {
                    sw.WriteLine(item.SubItems[0].Text + "|" + item.SubItems[1].Text + "|" +
                        item.SubItems[2].Text + "|" + item.SubItems[3].Text + "|" + item.SubItems[4].Text + "|" + item.SubItems[5].Text);
                }
                sw.Close();
                lbl_bilgi.Text = ("Dosyaya Başarılı Olarak Kayıt Edildi.");
            }
            else
                lbl_bilgi.Text = ("İptal Edildi");
        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Döküman Dosyası|*.txt|Tüm Dosyalar |*.*";
            DialogResult dr = opf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(opf.FileName);
                lstvw_StokTakip.Items.Clear();
                while (true)
                {
                    string oku = sr.ReadLine();
                    if (oku == null)
                        break;
                    string[] parca = oku.Split('|');

                    lstvw_StokTakip.Items.Add(new ListViewItem(parca));

                    StreamWriter sw = new StreamWriter("StokTakip.txt");
                    foreach (ListViewItem l in lstvw_StokTakip.Items)
                    {
                        sw.WriteLine(l.SubItems[0].Text + "|" + l.SubItems[1].Text + "|" + l.SubItems[2].Text + "|" + l.SubItems[3].Text + "|" + l.SubItems[4].Text + "|" + l.SubItems[5].Text);

                    } sw.Close();
                }
                sr.Close();
                lbl_mesaj.Text = "Dosyadan veriler yüklendi.";
            }
            else
                lbl_mesaj.Text = "İşlem İptal Edildi.";
        }

        private void chxbx_onarr_Click(object sender, EventArgs e)
        {
            if (chxbx_onarr.Checked)
            {
                nud_EldeOlan.Increment = +10;
            }
            else
            {
                nud_EldeOlan.Increment = +1;
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_urunAdi.Clear();
            tx_toplamFiyat.Clear();
            tx_mevcutStok.Clear();
            nud_EldeOlan.Value = 0;
            tx_Fiyat.Clear();
            lbl_bilgi.Text = "Metin kutuları boşaltıldı.";
        }

        private void lnklbl_tumunuSil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            silme_paneli.Visible = true;
        }

        private void lnklbl_tumunuSil_Click(object sender, EventArgs e)
        {



        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (tx_parola.Text == "admin")
            {

                DialogResult secenek = MessageBox.Show("Tüm Kayıtları Silmek istediğinize Eminmisiniz? ", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {

                    StreamWriter sw = new StreamWriter("StokTakip.txt");
                    foreach (ListViewItem l in lstvw_StokTakip.Items)
                    {
                        lstvw_StokTakip.Items.Remove(l);
                    } sw.Close();

                    tx_urunAdi.Clear();
                    tx_toplamFiyat.Clear();
                    tx_mevcutStok.Clear();
                    nud_EldeOlan.Value = 0;
                    tx_Fiyat.Clear();

                    lbl_bilgi.Text = "Tüm Kayıtla Silindi";
                }
                else if (secenek == DialogResult.No)
                {
                    //Hayır seçeneğine tıklandığında çalıştırılacak kodlar
                }
            }
            else
            {
                MessageBox.Show("Yanlış Parola");
                lbl_bilgi.Text = "Yanlış Parola";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            silme_paneli.Visible = false;
        }

        private void chxbx_onarr_CheckedChanged(object sender, EventArgs e)
        {

        }


       

    }
}
