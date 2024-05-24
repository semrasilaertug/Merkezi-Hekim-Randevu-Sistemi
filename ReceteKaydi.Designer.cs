namespace MBYS
{
    partial class ReceteKaydi
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
            this.txt_receteNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_receteTarihi = new System.Windows.Forms.TextBox();
            this.btn_receteEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_receteNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_tcNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_receteTarihi);
            this.groupBox1.Location = new System.Drawing.Point(153, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 223);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reçete Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reçete No :";
            // 
            // txt_receteNo
            // 
            this.txt_receteNo.Location = new System.Drawing.Point(257, 49);
            this.txt_receteNo.Name = "txt_receteNo";
            this.txt_receteNo.Size = new System.Drawing.Size(147, 22);
            this.txt_receteNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta TC Kimlik No :";
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.Location = new System.Drawing.Point(257, 175);
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.Size = new System.Drawing.Size(147, 22);
            this.txt_tcNo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reçete Tarihi :";
            // 
            // txt_receteTarihi
            // 
            this.txt_receteTarihi.Location = new System.Drawing.Point(257, 109);
            this.txt_receteTarihi.Name = "txt_receteTarihi";
            this.txt_receteTarihi.Size = new System.Drawing.Size(147, 22);
            this.txt_receteTarihi.TabIndex = 6;
            // 
            // btn_receteEkle
            // 
            this.btn_receteEkle.Location = new System.Drawing.Point(337, 325);
            this.btn_receteEkle.Name = "btn_receteEkle";
            this.btn_receteEkle.Size = new System.Drawing.Size(152, 53);
            this.btn_receteEkle.TabIndex = 20;
            this.btn_receteEkle.Text = "Reçete Kaydını Ekle";
            this.btn_receteEkle.UseVisualStyleBackColor = true;
            this.btn_receteEkle.Click += new System.EventHandler(this.btn_receteEkle_Click);
            // 
            // ReceteKaydi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_receteEkle);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReceteKaydi";
            this.Text = "Reçete Kaydı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_receteNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tcNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_receteTarihi;
        private System.Windows.Forms.Button btn_receteEkle;
    }
}