namespace MBYS
{
    partial class ilacıAlanHastalar
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
            this.btn_ilacıAlanHastaList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ilacBarkodNo = new System.Windows.Forms.TextBox();
            this.dataGridView_ilaciAlanHasta = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ilaciAlanHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ilacıAlanHastaList
            // 
            this.btn_ilacıAlanHastaList.Location = new System.Drawing.Point(181, 98);
            this.btn_ilacıAlanHastaList.Name = "btn_ilacıAlanHastaList";
            this.btn_ilacıAlanHastaList.Size = new System.Drawing.Size(152, 53);
            this.btn_ilacıAlanHastaList.TabIndex = 24;
            this.btn_ilacıAlanHastaList.Text = "Hastaları Listele";
            this.btn_ilacıAlanHastaList.UseVisualStyleBackColor = true;
            this.btn_ilacıAlanHastaList.Click += new System.EventHandler(this.btn_ilacıAlanHastaList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_ilacıAlanHastaList);
            this.groupBox1.Controls.Add(this.txt_ilacBarkodNo);
            this.groupBox1.Location = new System.Drawing.Point(198, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 170);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlacı hangi hastaların aldığını listelemek için bilgileri giriniz.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "İlaç Barkod No :";
            // 
            // txt_ilacBarkodNo
            // 
            this.txt_ilacBarkodNo.Location = new System.Drawing.Point(181, 47);
            this.txt_ilacBarkodNo.Name = "txt_ilacBarkodNo";
            this.txt_ilacBarkodNo.Size = new System.Drawing.Size(147, 22);
            this.txt_ilacBarkodNo.TabIndex = 8;
            // 
            // dataGridView_ilaciAlanHasta
            // 
            this.dataGridView_ilaciAlanHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ilaciAlanHasta.Location = new System.Drawing.Point(3, 259);
            this.dataGridView_ilaciAlanHasta.Name = "dataGridView_ilaciAlanHasta";
            this.dataGridView_ilaciAlanHasta.RowHeadersWidth = 51;
            this.dataGridView_ilaciAlanHasta.RowTemplate.Height = 24;
            this.dataGridView_ilaciAlanHasta.Size = new System.Drawing.Size(798, 269);
            this.dataGridView_ilaciAlanHasta.TabIndex = 25;
            // 
            // ilacıAlanHastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.dataGridView_ilaciAlanHasta);
            this.Controls.Add(this.groupBox1);
            this.Name = "ilacıAlanHastalar";
            this.Text = "İlacı Alan Hastaları Listele";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ilaciAlanHasta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ilacıAlanHastaList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ilacBarkodNo;
        private System.Windows.Forms.DataGridView dataGridView_ilaciAlanHasta;
    }
}