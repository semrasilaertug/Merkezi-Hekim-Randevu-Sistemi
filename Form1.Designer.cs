namespace MBYS
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kAYITEKLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaKaydıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muayeneKaydıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçKaydıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reçeteyeİlaçKaydıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kAYITLARILİSTELEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muayeneListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçKayıtlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçKayıtlarıToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hastanınAldığıİlaçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilacıAlanHastalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kAYITEKLEToolStripMenuItem,
            this.kAYITLARILİSTELEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kAYITEKLEToolStripMenuItem
            // 
            this.kAYITEKLEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaKaydıEkleToolStripMenuItem,
            this.muayeneKaydıEkleToolStripMenuItem,
            this.ilaçKaydıEkleToolStripMenuItem,
            this.reçeteyeİlaçKaydıEkleToolStripMenuItem});
            this.kAYITEKLEToolStripMenuItem.Name = "kAYITEKLEToolStripMenuItem";
            this.kAYITEKLEToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.kAYITEKLEToolStripMenuItem.Text = "KAYIT EKLE";
            // 
            // hastaKaydıEkleToolStripMenuItem
            // 
            this.hastaKaydıEkleToolStripMenuItem.Name = "hastaKaydıEkleToolStripMenuItem";
            this.hastaKaydıEkleToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.hastaKaydıEkleToolStripMenuItem.Text = "Hasta Kaydı Ekle";
            this.hastaKaydıEkleToolStripMenuItem.Click += new System.EventHandler(this.hastaKaydıEkleToolStripMenuItem_Click);
            // 
            // muayeneKaydıEkleToolStripMenuItem
            // 
            this.muayeneKaydıEkleToolStripMenuItem.Name = "muayeneKaydıEkleToolStripMenuItem";
            this.muayeneKaydıEkleToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.muayeneKaydıEkleToolStripMenuItem.Text = "Muayene Kaydı Ekle ";
            this.muayeneKaydıEkleToolStripMenuItem.Click += new System.EventHandler(this.muayeneKaydıEkleToolStripMenuItem_Click);
            // 
            // ilaçKaydıEkleToolStripMenuItem
            // 
            this.ilaçKaydıEkleToolStripMenuItem.Name = "ilaçKaydıEkleToolStripMenuItem";
            this.ilaçKaydıEkleToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.ilaçKaydıEkleToolStripMenuItem.Text = "İlaç Kaydı Ekle";
            this.ilaçKaydıEkleToolStripMenuItem.Click += new System.EventHandler(this.ilaçKaydıEkleToolStripMenuItem_Click);
            // 
            // reçeteyeİlaçKaydıEkleToolStripMenuItem
            // 
            this.reçeteyeİlaçKaydıEkleToolStripMenuItem.Name = "reçeteyeİlaçKaydıEkleToolStripMenuItem";
            this.reçeteyeİlaçKaydıEkleToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.reçeteyeİlaçKaydıEkleToolStripMenuItem.Text = "Reçeteye İlaç Kaydı Ekle";
            this.reçeteyeİlaçKaydıEkleToolStripMenuItem.Click += new System.EventHandler(this.reçeteyeİlaçKaydıEkleToolStripMenuItem_Click);
            // 
            // kAYITLARILİSTELEToolStripMenuItem
            // 
            this.kAYITLARILİSTELEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilaçListesiToolStripMenuItem,
            this.muayeneListesiToolStripMenuItem,
            this.ilaçKayıtlarıToolStripMenuItem,
            this.ilaçKayıtlarıToolStripMenuItem1,
            this.hastanınAldığıİlaçlarToolStripMenuItem,
            this.ilacıAlanHastalarToolStripMenuItem});
            this.kAYITLARILİSTELEToolStripMenuItem.Name = "kAYITLARILİSTELEToolStripMenuItem";
            this.kAYITLARILİSTELEToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.kAYITLARILİSTELEToolStripMenuItem.Text = "KAYITLARI LİSTELE";
            // 
            // ilaçListesiToolStripMenuItem
            // 
            this.ilaçListesiToolStripMenuItem.Name = "ilaçListesiToolStripMenuItem";
            this.ilaçListesiToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.ilaçListesiToolStripMenuItem.Text = "Hasta Kayıtları";
            this.ilaçListesiToolStripMenuItem.Click += new System.EventHandler(this.ilaçListesiToolStripMenuItem_Click);
            // 
            // muayeneListesiToolStripMenuItem
            // 
            this.muayeneListesiToolStripMenuItem.Name = "muayeneListesiToolStripMenuItem";
            this.muayeneListesiToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.muayeneListesiToolStripMenuItem.Text = "Muayene Kayıtları";
            this.muayeneListesiToolStripMenuItem.Click += new System.EventHandler(this.muayeneListesiToolStripMenuItem_Click);
            // 
            // ilaçKayıtlarıToolStripMenuItem
            // 
            this.ilaçKayıtlarıToolStripMenuItem.Name = "ilaçKayıtlarıToolStripMenuItem";
            this.ilaçKayıtlarıToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.ilaçKayıtlarıToolStripMenuItem.Text = "Reçete Kayıtları";
            this.ilaçKayıtlarıToolStripMenuItem.Click += new System.EventHandler(this.ilaçKayıtlarıToolStripMenuItem_Click);
            // 
            // ilaçKayıtlarıToolStripMenuItem1
            // 
            this.ilaçKayıtlarıToolStripMenuItem1.Name = "ilaçKayıtlarıToolStripMenuItem1";
            this.ilaçKayıtlarıToolStripMenuItem1.Size = new System.Drawing.Size(238, 26);
            this.ilaçKayıtlarıToolStripMenuItem1.Text = "İlaç Kayıtları";
            this.ilaçKayıtlarıToolStripMenuItem1.Click += new System.EventHandler(this.ilaçKayıtlarıToolStripMenuItem1_Click);
            // 
            // hastanınAldığıİlaçlarToolStripMenuItem
            // 
            this.hastanınAldığıİlaçlarToolStripMenuItem.Name = "hastanınAldığıİlaçlarToolStripMenuItem";
            this.hastanınAldığıİlaçlarToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.hastanınAldığıİlaçlarToolStripMenuItem.Text = "Hastanın Aldığı İlaçlar";
            this.hastanınAldığıİlaçlarToolStripMenuItem.Click += new System.EventHandler(this.hastanınAldığıİlaçlarToolStripMenuItem_Click);
            // 
            // ilacıAlanHastalarToolStripMenuItem
            // 
            this.ilacıAlanHastalarToolStripMenuItem.Name = "ilacıAlanHastalarToolStripMenuItem";
            this.ilacıAlanHastalarToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.ilacıAlanHastalarToolStripMenuItem.Text = "İlacı Alan Hastalar ";
            this.ilacıAlanHastalarToolStripMenuItem.Click += new System.EventHandler(this.ilacıAlanHastalarToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Thistle;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(138, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 151);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HOŞGELDİNİZ!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MUAYENE BİLGİ YÖNETİM SİSTEMİ ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MBYS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kAYITEKLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaKaydıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muayeneKaydıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçKaydıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kAYITLARILİSTELEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muayeneListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçKayıtlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçKayıtlarıToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hastanınAldığıİlaçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilacıAlanHastalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reçeteyeİlaçKaydıEkleToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

