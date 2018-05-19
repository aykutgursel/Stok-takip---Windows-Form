using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StokTakipProgrami
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void tsb_stok_Click(object sender, EventArgs e)
        {
            Stok r = new Stok();
            r.MdiParent = this;
            tsb_stok.Enabled = false;
            r.Show();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void tsb_verilen_Click(object sender, EventArgs e)
        {
            personeldekiUrunler P = new personeldekiUrunler();
            P.MdiParent = this;
            tsb_verilen.Enabled = false;
            P.Show();
        }
    }
}
