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
    public partial class personeldekiUrunler : Form
    {
        public personeldekiUrunler()
        {
            InitializeComponent();
        }

        private void personeldekiUrunler_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaForm anaFrm = (AnaForm)this.MdiParent;
            anaFrm.tsb_verilen.Enabled = true;
        }

        private void cbx_urunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void personeldekiUrunler_Load(object sender, EventArgs e)
        {
            tarihh.Text = DateTime.Now.ToLongDateString();
            saatt.Text = DateTime.Now.ToLongTimeString();

            StreamReader sr = new StreamReader("StokTakip.txt");
            while (true)
            {
                string k = sr.ReadLine();
                if (k == null)
                    break;
                lstvw_StokTakip.Items.Add(new ListViewItem(k.Split('|')));
            }
            sr.Close();

            // -----------------------CBX E VERİLERİ YÜKLEME------------------------------------
            StreamReader sa = new StreamReader("StokTakip.txt");
            while (true)
            {
                string oku = sa.ReadLine();
                if (oku == null)
                    break;
                string[] parca = oku.Split('|');
                cbx_urunAdi.Items.Add(parca[0]);
            }
            sa.Close();

            StreamReader sy = new StreamReader("Verilen.txt");
            while (true)
            {
                string k = sy.ReadLine();
                if (k == null)
                    break;
                lstv_Personel.Items.Add(new ListViewItem(k.Split('|')));
            }
            sy.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                nud_kacAdet.ReadOnly = false;
            }
            else
                nud_kacAdet.ReadOnly = true;

        }

        private void nud_kacAdet_ValueChanged(object sender, EventArgs e)
        {


        }

        private void cbx_eldeOlan_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        int urunler;
        private void button1_Click_1(object sender, EventArgs e)
        {
            urunler = Convert.ToInt32(cbx_urunAdi.SelectedIndex.ToString());

            if (urunler == -1)
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçin!");
                return;
            }
            else if (cbx_urunAdi.SelectedIndex.ToString() == cbx_urunAdi.Text)
            {
                StreamReader su = new StreamReader("StokTakip.txt");

                string oku = su.ReadLine();

                string[] parca = oku.Split('|');
                MessageBox.Show(" Seçili Ürün Bilgileri \n Ürün Adı :" + parca[0] + "\n Mevcut Stok :" + parca[1] +
                "\n Elde Olan : " + parca[2] + "\n Fiyat : " + parca[3] + "₺");

                su.Close();
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            StreamReader su = new StreamReader("StokTakip.txt");
            StreamReader sr = new StreamReader("Verilen.txt");
            
            while (true)
            {
                string oku = su.ReadLine();
                if (oku == null)
                    break;
                string[] parca = oku.Split('|');


            }




            if (tx_kimeV.Text == "" || nud_kacAdet.Value.ToString() == "" || cbx_urunAdi.Text == "")
            {
                MessageBox.Show("Bilgileri girmeden Ekleme yapamazsınız");
                lbl_bilgi.Text = "Bilgi girmeden Ekleme yapamazsınız.";
            }

            else
            {       // EĞER HATA YOKSA EKLEME İŞLEMİ YAPIYOR


                lstv_Personel.Items.Add(new ListViewItem(new string[] { cbx_urunAdi.Text, tx_kimeV.Text, nud_kacAdet.Value.ToString(), tx_aciklama.Text, tarihh.Text, saatt.Text }));
                StreamWriter sw = new StreamWriter("Verilen.txt");
                StreamWriter ss = new StreamWriter("StokTakip.txt");
                foreach (ListViewItem l in lstv_Personel.Items)
                {
                      sw.WriteLine(l.SubItems[0].Text + "|" + l.SubItems[1].Text + "|" + l.SubItems[2].Text + "|" + l.SubItems[3].Text + "|" + l.SubItems[4].Text + "|" + l.SubItems[5].Text);
                } sw.Close();

                cbx_urunAdi.Text = "";
                tx_kimeV.Clear();
                tx_aciklama.Clear();
                nud_kacAdet.Value = 0;

                lbl_bilgi.Text = "Ürün Eklendi";

            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (lstv_Personel.SelectedIndices.Count != 1)
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçin!");
                lbl_bilgi.Text = "Kayıt Seçin !";
                return;
            }
            else
            {
                lstv_Personel.Items.Remove(lstv_Personel.SelectedItems[0]);
                StreamWriter sw = new StreamWriter("Verilen.txt");
                foreach (ListViewItem l in lstvw_StokTakip.Items)
                {
                    sw.WriteLine(l.SubItems[0].Text + "|" + l.SubItems[1].Text + "|" + l.SubItems[2].Text + "|" + l.SubItems[3].Text + "|" + l.SubItems[4].Text + "|" + l.SubItems[5].Text);
                } sw.Close();

                cbx_urunAdi.Text = "";
                tx_kimeV.Clear();
                tx_aciklama.Clear();
                nud_kacAdet.Value = 0;

                lbl_bilgi.Text = "Kayıt Silindi.";

            }

        }

        private void lstv_Personel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstv_Personel.SelectedIndices.Count == 1)
            {
                cbx_urunAdi.Text = lstv_Personel.SelectedItems[0].SubItems[0].Text;
                tx_kimeV.Text = lstv_Personel.SelectedItems[0].SubItems[1].Text;
                nud_kacAdet.Text = lstv_Personel.SelectedItems[0].SubItems[2].Text;
                tx_aciklama.Text = lstv_Personel.SelectedItems[0].SubItems[3].Text;

                lbl_bilgi.Text = lstv_Personel.SelectedItems[0].SubItems[0].Text + " isimli ürün seçili.";


                btn_sill.Enabled = true;
                btn_guncelle.Enabled = true;
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (lstv_Personel.SelectedIndices.Count != 1)
            {
                lbl_bilgi.Text = ("Güncellenecek Bir Kayıt Seçin!");
                return;
            }
            else if (tx_kimeV.Text == "" || cbx_urunAdi.Text == "")
            {
                lbl_bilgi.Text = "Güncellenecek Kayıt Seçin.";
            }

            else
            {
                lstv_Personel.SelectedItems[0].SubItems[0].Text = cbx_urunAdi.Text;
                lstv_Personel.SelectedItems[0].SubItems[1].Text = tx_kimeV.Text;
                lstv_Personel.SelectedItems[0].SubItems[2].Text = nud_kacAdet.Value.ToString();
                lstv_Personel.SelectedItems[0].SubItems[3].Text = tx_aciklama.Text;
                tarihh.Text = DateTime.Now.ToLongDateString();
                saatt.Text = DateTime.Now.ToLongTimeString();

                StreamWriter sw = new StreamWriter("Verilen.txt");
                foreach (ListViewItem l in lstv_Personel.Items)
                {
                    sw.WriteLine(l.SubItems[0].Text + "|" + l.SubItems[1].Text + "|" + l.SubItems[2].Text + "|" + l.SubItems[3].Text + "|" + tarihh.Text + "|" + saatt.Text);

                }
                sw.Close();

                cbx_urunAdi.Text = "";
                tx_kimeV.Clear();
                tx_aciklama.Clear();
                nud_kacAdet.Value = 0;

            }
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

                foreach (ListViewItem item in lstv_Personel.Items)
                {
                    sw.WriteLine(item.SubItems[0].Text + "|" + item.SubItems[1].Text + "|" +
                        item.SubItems[2].Text + "|" + item.SubItems[3].Text + "|" + item.SubItems[4].Text + "|" + item.SubItems[5].Text);
                }
                sw.Close();
                lbl_bilgi.Text = "Güncellenecek Kayıt Seçin.";
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
                    lstv_Personel.Items.Add(new ListViewItem(parca));

                    StreamWriter sw = new StreamWriter("Verilen.txt"); // Dosyayı açtıktan sonra ekranda kalır
                    foreach (ListViewItem l in lstv_Personel.Items)
                    {
                        sw.WriteLine(l.SubItems[0].Text + "|" + l.SubItems[1].Text + "|" + l.SubItems[2].Text + "|" + l.SubItems[3].Text + "|" + l.SubItems[4].Text + "|" + l.SubItems[5].Text);

                    } sw.Close();

                }
                sr.Close();
                lbl_bilgi.Text = ("Dosyadan veriler yüklendi.");
            }
            else
                lbl_bilgi.Text = ("İşlem İptal Edildi.");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            silme_paneli.Visible = true;
        }

        private void Sil_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            silme_paneli.Visible = false;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            cbx_urunAdi.Text = "";
            tx_kimeV.Clear();
            tx_aciklama.Clear();
            nud_kacAdet.Value = 0;

            lbl_bilgi.Text = "Bilgiler temizlendi";
        }

        private void btn_ekle_Enter(object sender, EventArgs e)
        {

        }

        private void btn_sill_Click(object sender, EventArgs e)
        {

            if (lstv_Personel.SelectedIndices.Count != 1)
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçin!");
                lbl_bilgi.Text = "Kayıt Seçin !";
                return;
            }
            else
            {
                lstv_Personel.Items.Remove(lstv_Personel.SelectedItems[0]);
                StreamWriter sw = new StreamWriter("Verilen.txt");
                foreach (ListViewItem l in lstvw_StokTakip.Items)
                {
                    sw.WriteLine(l.SubItems[0].Text + "|" + l.SubItems[1].Text + "|" + l.SubItems[2].Text + "|" + l.SubItems[3].Text + "|" + l.SubItems[4].Text + "|" + l.SubItems[5].Text);
                } sw.Close();

                cbx_urunAdi.Text = "";
                tx_kimeV.Clear();
                tx_aciklama.Clear();
                nud_kacAdet.Value = 0;

                lbl_bilgi.Text = "Kayıt Silindi.";

            }

        }

        private void Sil_Click_1(object sender, EventArgs e)
        {
            if (tx_parola.Text == "admin")
            {

                DialogResult secenek = MessageBox.Show("Tüm Kayıtları Silmek istediğinize Eminmisiniz? ", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {

                    StreamWriter sw = new StreamWriter("Verilen.txt");
                    foreach (ListViewItem l in lstv_Personel.Items)
                    {
                        lstv_Personel.Items.Remove(l);
                    } sw.Close();

                    cbx_urunAdi.Text = "";
                    tx_kimeV.Clear();
                    tx_aciklama.Clear();
                    nud_kacAdet.Value = 0;

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
    }
}
