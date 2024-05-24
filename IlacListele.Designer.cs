namespace MBYS
{
    partial class IlacListele
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
            this.btn_ilacListele = new System.Windows.Forms.Button();
            this.dataGridView_ilacListesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ilacListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ilacListele
            // 
            this.btn_ilacListele.Location = new System.Drawing.Point(316, 41);
            this.btn_ilacListele.Name = "btn_ilacListele";
            this.btn_ilacListele.Size = new System.Drawing.Size(152, 53);
            this.btn_ilacListele.TabIndex = 26;
            this.btn_ilacListele.Text = "İlaçları Listele";
            this.btn_ilacListele.UseVisualStyleBackColor = true;
            this.btn_ilacListele.Click += new System.EventHandler(this.btn_ilacListele_Click);
            // 
            // dataGridView_ilacListesi
            // 
            this.dataGridView_ilacListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ilacListesi.Location = new System.Drawing.Point(0, 135);
            this.dataGridView_ilacListesi.Name = "dataGridView_ilacListesi";
            this.dataGridView_ilacListesi.RowHeadersWidth = 51;
            this.dataGridView_ilacListesi.RowTemplate.Height = 24;
            this.dataGridView_ilacListesi.Size = new System.Drawing.Size(801, 315);
            this.dataGridView_ilacListesi.TabIndex = 27;
            // 
            // IlacListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_ilacListesi);
            this.Controls.Add(this.btn_ilacListele);
            this.Name = "IlacListele";
            this.Text = "IlacListele";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ilacListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ilacListele;
        private System.Windows.Forms.DataGridView dataGridView_ilacListesi;
    }
}