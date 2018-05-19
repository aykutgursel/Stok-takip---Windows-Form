namespace StokTakipProgrami
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_stok = new System.Windows.Forms.ToolStripButton();
            this.tsb_verilen = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_stok,
            this.tsb_verilen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(707, 36);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_stok
            // 
            this.tsb_stok.Font = new System.Drawing.Font("Rod", 10F, System.Drawing.FontStyle.Bold);
            this.tsb_stok.Image = ((System.Drawing.Image)(resources.GetObject("tsb_stok.Image")));
            this.tsb_stok.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_stok.Name = "tsb_stok";
            this.tsb_stok.Size = new System.Drawing.Size(96, 33);
            this.tsb_stok.Text = "STOK TAKİP";
            this.tsb_stok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_stok.Click += new System.EventHandler(this.tsb_stok_Click);
            // 
            // tsb_verilen
            // 
            this.tsb_verilen.Font = new System.Drawing.Font("Rod", 10F, System.Drawing.FontStyle.Bold);
            this.tsb_verilen.Image = ((System.Drawing.Image)(resources.GetObject("tsb_verilen.Image")));
            this.tsb_verilen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_verilen.Name = "tsb_verilen";
            this.tsb_verilen.Size = new System.Drawing.Size(141, 33);
            this.tsb_verilen.Text = "VERİLEN ÜRÜNLER";
            this.tsb_verilen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_verilen.Click += new System.EventHandler(this.tsb_verilen_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 400);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Text = "Stok Takip";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton tsb_stok;
        public System.Windows.Forms.ToolStripButton tsb_verilen;
    }
}

