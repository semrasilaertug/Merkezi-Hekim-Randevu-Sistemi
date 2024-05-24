namespace MBYS
{
    partial class ReceteListele
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
            this.btn_receteListeleme = new System.Windows.Forms.Button();
            this.dataGridView_recete = new System.Windows.Forms.DataGridView();
            this.btn_hastaReceteListele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recete)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_receteListeleme
            // 
            this.btn_receteListeleme.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_receteListeleme.Location = new System.Drawing.Point(355, 223);
            this.btn_receteListeleme.Name = "btn_receteListeleme";
            this.btn_receteListeleme.Size = new System.Drawing.Size(152, 53);
            this.btn_receteListeleme.TabIndex = 32;
            this.btn_receteListeleme.Text = "Tüm Reçete Kayıtlarını Listele";
            this.btn_receteListeleme.UseVisualStyleBackColor = false;
            this.btn_receteListeleme.Click += new System.EventHandler(this.btn_receteListeleme_Click);
            // 
            // dataGridView_recete
            // 
            this.dataGridView_recete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_recete.Location = new System.Drawing.Point(-1, 295);
            this.dataGridView_recete.Name = "dataGridView_recete";
            this.dataGridView_recete.RowHeadersWidth = 51;
            this.dataGridView_recete.RowTemplate.Height = 24;
            this.dataGridView_recete.Size = new System.Drawing.Size(802, 249);
            this.dataGridView_recete.TabIndex = 31;
            // 
            // btn_hastaReceteListele
            // 
            this.btn_hastaReceteListele.Location = new System.Drawing.Point(190, 94);
            this.btn_hastaReceteListele.Name = "btn_hastaReceteListele";
            this.btn_hastaReceteListele.Size = new System.Drawing.Size(152, 53);
            this.btn_hastaReceteListele.TabIndex = 29;
            this.btn_hastaReceteListele.Text = "Hastanın Reçetesini Listele";
            this.btn_hastaReceteListele.UseVisualStyleBackColor = true;
            this.btn_hastaReceteListele.Click += new System.EventHandler(this.btn_hastaReceteListele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_tcNo);
            this.groupBox1.Controls.Add(this.btn_hastaReceteListele);
            this.groupBox1.Location = new System.Drawing.Point(165, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 177);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Belirli bir hastanın reçetesini listelemek için hasta TC Kimlik No giriniz.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC Kimlik No :";
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.Location = new System.Drawing.Point(195, 54);
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.Size = new System.Drawing.Size(147, 22);
            this.txt_tcNo.TabIndex = 4;
            // 
            // ReceteListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.btn_receteListeleme);
            this.Controls.Add(this.dataGridView_recete);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReceteListele";
            this.Text = "Reçete Kaydı Listele";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_recete)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_receteListeleme;
        private System.Windows.Forms.DataGridView dataGridView_recete;
        private System.Windows.Forms.Button btn_hastaReceteListele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tcNo;
    }
}