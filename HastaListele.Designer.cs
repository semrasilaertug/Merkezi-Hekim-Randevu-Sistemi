namespace MBYS
{
    partial class HastaListele
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            this.btn_seciliHastaListele = new System.Windows.Forms.Button();
            this.btn_tumHastalariListele = new System.Windows.Forms.Button();
            this.dataGridView_hasta = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hasta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_tcNo);
            this.groupBox1.Controls.Add(this.btn_seciliHastaListele);
            this.groupBox1.Location = new System.Drawing.Point(180, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Belirli bir hastayı listelemek için hasta TC Kimlik No giriniz.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC Kimlik No :";
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.Location = new System.Drawing.Point(136, 43);
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.Size = new System.Drawing.Size(147, 22);
            this.txt_tcNo.TabIndex = 4;
            // 
            // btn_seciliHastaListele
            // 
            this.btn_seciliHastaListele.Location = new System.Drawing.Point(136, 97);
            this.btn_seciliHastaListele.Name = "btn_seciliHastaListele";
            this.btn_seciliHastaListele.Size = new System.Drawing.Size(152, 53);
            this.btn_seciliHastaListele.TabIndex = 19;
            this.btn_seciliHastaListele.Text = "Belirli Hasta Kaydını Listele";
            this.btn_seciliHastaListele.UseVisualStyleBackColor = true;
            this.btn_seciliHastaListele.Click += new System.EventHandler(this.btn_seciliHastaListele_Click);
            // 
            // btn_tumHastalariListele
            // 
            this.btn_tumHastalariListele.Location = new System.Drawing.Point(311, 230);
            this.btn_tumHastalariListele.Name = "btn_tumHastalariListele";
            this.btn_tumHastalariListele.Size = new System.Drawing.Size(152, 53);
            this.btn_tumHastalariListele.TabIndex = 20;
            this.btn_tumHastalariListele.Text = "Tüm Hasta Kayıtlarını Listele";
            this.btn_tumHastalariListele.UseVisualStyleBackColor = true;
            this.btn_tumHastalariListele.Click += new System.EventHandler(this.btn_tumHastalariListele_Click);
            // 
            // dataGridView_hasta
            // 
            this.dataGridView_hasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_hasta.Location = new System.Drawing.Point(-1, 306);
            this.dataGridView_hasta.Name = "dataGridView_hasta";
            this.dataGridView_hasta.RowHeadersWidth = 51;
            this.dataGridView_hasta.RowTemplate.Height = 24;
            this.dataGridView_hasta.Size = new System.Drawing.Size(802, 263);
            this.dataGridView_hasta.TabIndex = 21;
            // 
            // HastaListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.dataGridView_hasta);
            this.Controls.Add(this.btn_tumHastalariListele);
            this.Controls.Add(this.groupBox1);
            this.Name = "HastaListele";
            this.Text = "Hasta Kayıtlarını Listele";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hasta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tcNo;
        private System.Windows.Forms.Button btn_seciliHastaListele;
        private System.Windows.Forms.Button btn_tumHastalariListele;
        private System.Windows.Forms.DataGridView dataGridView_hasta;
    }
}