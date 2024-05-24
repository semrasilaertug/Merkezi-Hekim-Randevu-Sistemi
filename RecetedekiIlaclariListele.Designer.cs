namespace MBYS
{
    partial class RecetedekiIlaclariListele
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
            this.btn_receteIlacListele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_receteNo = new System.Windows.Forms.TextBox();
            this.dataGridView_recetedekiIlaclar = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recetedekiIlaclar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_receteIlacListele
            // 
            this.btn_receteIlacListele.Location = new System.Drawing.Point(347, 180);
            this.btn_receteIlacListele.Name = "btn_receteIlacListele";
            this.btn_receteIlacListele.Size = new System.Drawing.Size(152, 53);
            this.btn_receteIlacListele.TabIndex = 24;
            this.btn_receteIlacListele.Text = "İlaçları Listele";
            this.btn_receteIlacListele.UseVisualStyleBackColor = true;
            this.btn_receteIlacListele.Click += new System.EventHandler(this.btn_receteIlacListele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_receteNo);
            this.groupBox1.Location = new System.Drawing.Point(183, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 123);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hastanın reçetesindeki ilaçları listelemek için bilgileri giriniz.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reçete No :";
            // 
            // txt_receteNo
            // 
            this.txt_receteNo.Location = new System.Drawing.Point(169, 53);
            this.txt_receteNo.Name = "txt_receteNo";
            this.txt_receteNo.Size = new System.Drawing.Size(147, 22);
            this.txt_receteNo.TabIndex = 2;
            // 
            // dataGridView_recetedekiIlaclar
            // 
            this.dataGridView_recetedekiIlaclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_recetedekiIlaclar.Location = new System.Drawing.Point(-5, 274);
            this.dataGridView_recetedekiIlaclar.Name = "dataGridView_recetedekiIlaclar";
            this.dataGridView_recetedekiIlaclar.RowHeadersWidth = 51;
            this.dataGridView_recetedekiIlaclar.RowTemplate.Height = 24;
            this.dataGridView_recetedekiIlaclar.Size = new System.Drawing.Size(804, 265);
            this.dataGridView_recetedekiIlaclar.TabIndex = 25;
            // 
            // RecetedekiIlaclariListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.dataGridView_recetedekiIlaclar);
            this.Controls.Add(this.btn_receteIlacListele);
            this.Controls.Add(this.groupBox1);
            this.Name = "RecetedekiIlaclariListele";
            this.Text = "Hastanın Reçetesindeki İlaçlar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recetedekiIlaclar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_receteIlacListele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_receteNo;
        private System.Windows.Forms.DataGridView dataGridView_recetedekiIlaclar;
    }
}