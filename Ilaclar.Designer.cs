namespace MBYS
{
    partial class Ilaclar
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
            this.txt_ilacBarkodNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ilacAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ilacTipi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ilacEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ilacBarkodNo
            // 
            this.txt_ilacBarkodNo.Location = new System.Drawing.Point(235, 44);
            this.txt_ilacBarkodNo.Name = "txt_ilacBarkodNo";
            this.txt_ilacBarkodNo.Size = new System.Drawing.Size(147, 22);
            this.txt_ilacBarkodNo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "İlaç Barkod No :";
            // 
            // txt_ilacAd
            // 
            this.txt_ilacAd.Location = new System.Drawing.Point(235, 104);
            this.txt_ilacAd.Name = "txt_ilacAd";
            this.txt_ilacAd.Size = new System.Drawing.Size(147, 22);
            this.txt_ilacAd.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "İlaç Adı :";
            // 
            // txt_ilacTipi
            // 
            this.txt_ilacTipi.Location = new System.Drawing.Point(235, 170);
            this.txt_ilacTipi.Name = "txt_ilacTipi";
            this.txt_ilacTipi.Size = new System.Drawing.Size(147, 22);
            this.txt_ilacTipi.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "İlacın Tipi :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_ilacTipi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_ilacAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_ilacBarkodNo);
            this.groupBox1.Location = new System.Drawing.Point(175, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 216);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlaç Bilgileri";
            // 
            // btn_ilacEkle
            // 
            this.btn_ilacEkle.Location = new System.Drawing.Point(405, 319);
            this.btn_ilacEkle.Name = "btn_ilacEkle";
            this.btn_ilacEkle.Size = new System.Drawing.Size(152, 53);
            this.btn_ilacEkle.TabIndex = 24;
            this.btn_ilacEkle.Text = "Yeni İlaç Ekle";
            this.btn_ilacEkle.UseVisualStyleBackColor = true;
            this.btn_ilacEkle.Click += new System.EventHandler(this.btn_ilacEkle_Click);
            // 
            // Ilaclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ilacEkle);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ilaclar";
            this.Text = "İlaçlar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ilacBarkodNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ilacAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ilacTipi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ilacEkle;
    }
}