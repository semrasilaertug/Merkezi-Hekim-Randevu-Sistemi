namespace MBYS
{
    partial class MuayeneListele
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
            this.dataGridView_muayene = new System.Windows.Forms.DataGridView();
            this.btn_seciliHastaListele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_muayeneTarihi = new System.Windows.Forms.TextBox();
            this.btn_muayeneTarihListeleme = new System.Windows.Forms.Button();
            this.btn_muayeneListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_muayene)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_muayene
            // 
            this.dataGridView_muayene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_muayene.Location = new System.Drawing.Point(1, 391);
            this.dataGridView_muayene.Name = "dataGridView_muayene";
            this.dataGridView_muayene.RowHeadersWidth = 51;
            this.dataGridView_muayene.RowTemplate.Height = 24;
            this.dataGridView_muayene.Size = new System.Drawing.Size(802, 236);
            this.dataGridView_muayene.TabIndex = 25;
            // 
            // btn_seciliHastaListele
            // 
            this.btn_seciliHastaListele.Location = new System.Drawing.Point(467, 41);
            this.btn_seciliHastaListele.Name = "btn_seciliHastaListele";
            this.btn_seciliHastaListele.Size = new System.Drawing.Size(152, 53);
            this.btn_seciliHastaListele.TabIndex = 23;
            this.btn_seciliHastaListele.Text = "Hasta Muayene Kaydını Listele";
            this.btn_seciliHastaListele.UseVisualStyleBackColor = true;
            this.btn_seciliHastaListele.Click += new System.EventHandler(this.btn_seciliHastaListele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_tcNo);
            this.groupBox1.Controls.Add(this.btn_seciliHastaListele);
            this.groupBox1.Location = new System.Drawing.Point(63, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 120);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Belirli bir hastanın muayene kayıtlarını listelemek için hasta TC Kimlik No girin" +
    "iz.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC Kimlik No :";
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.Location = new System.Drawing.Point(134, 56);
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.Size = new System.Drawing.Size(147, 22);
            this.txt_tcNo.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_muayeneTarihListeleme);
            this.groupBox2.Controls.Add(this.txt_muayeneTarihi);
            this.groupBox2.Location = new System.Drawing.Point(63, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 114);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Belirli bir tarihteki muayene kayıtlarını listelemek için tarih giriniz.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Muayene Tarihi :";
            // 
            // txt_muayeneTarihi
            // 
            this.txt_muayeneTarihi.Location = new System.Drawing.Point(150, 56);
            this.txt_muayeneTarihi.Name = "txt_muayeneTarihi";
            this.txt_muayeneTarihi.Size = new System.Drawing.Size(147, 22);
            this.txt_muayeneTarihi.TabIndex = 8;
            // 
            // btn_muayeneTarihListeleme
            // 
            this.btn_muayeneTarihListeleme.Location = new System.Drawing.Point(467, 41);
            this.btn_muayeneTarihListeleme.Name = "btn_muayeneTarihListeleme";
            this.btn_muayeneTarihListeleme.Size = new System.Drawing.Size(152, 53);
            this.btn_muayeneTarihListeleme.TabIndex = 26;
            this.btn_muayeneTarihListeleme.Text = "Muayene Kayıtlarını Listele";
            this.btn_muayeneTarihListeleme.UseVisualStyleBackColor = true;
            this.btn_muayeneTarihListeleme.Click += new System.EventHandler(this.btn_muayeneTarihListeleme_Click);
            // 
            // btn_muayeneListele
            // 
            this.btn_muayeneListele.Location = new System.Drawing.Point(530, 320);
            this.btn_muayeneListele.Name = "btn_muayeneListele";
            this.btn_muayeneListele.Size = new System.Drawing.Size(152, 53);
            this.btn_muayeneListele.TabIndex = 27;
            this.btn_muayeneListele.Text = "Tüm Muayene Kayıtlarını Listele";
            this.btn_muayeneListele.UseVisualStyleBackColor = true;
            this.btn_muayeneListele.Click += new System.EventHandler(this.btn_muayeneListele_Click);
            // 
            // MuayeneListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.btn_muayeneListele);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView_muayene);
            this.Controls.Add(this.groupBox1);
            this.Name = "MuayeneListele";
            this.Text = "Muayene Kaydı Listele";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_muayene)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_muayene;
        private System.Windows.Forms.Button btn_seciliHastaListele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tcNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_muayeneTarihi;
        private System.Windows.Forms.Button btn_muayeneTarihListeleme;
        private System.Windows.Forms.Button btn_muayeneListele;
    }
}