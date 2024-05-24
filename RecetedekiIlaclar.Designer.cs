namespace MBYS
{
    partial class RecetedekiIlaclar
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
            this.btn_receteyeIlacEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbox_ilacAdedi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ilacBarkodNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_receteNo = new System.Windows.Forms.TextBox();
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_receteyeIlacEkle
            // 
            this.btn_receteyeIlacEkle.Location = new System.Drawing.Point(194, 332);
            this.btn_receteyeIlacEkle.Name = "btn_receteyeIlacEkle";
            this.btn_receteyeIlacEkle.Size = new System.Drawing.Size(152, 53);
            this.btn_receteyeIlacEkle.TabIndex = 22;
            this.btn_receteyeIlacEkle.Text = "Reçeteye İlaç Ekle";
            this.btn_receteyeIlacEkle.UseVisualStyleBackColor = true;
            this.btn_receteyeIlacEkle.Click += new System.EventHandler(this.btn_receteyeIlacEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbox_ilacAdedi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_ilacBarkodNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_receteNo);
            this.groupBox1.Location = new System.Drawing.Point(133, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 217);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hastanın reçetesine ilaç eklemek için ilaç bilgileri giriniz.";
            // 
            // cbox_ilacAdedi
            // 
            this.cbox_ilacAdedi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_ilacAdedi.FormattingEnabled = true;
            this.cbox_ilacAdedi.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbox_ilacAdedi.Location = new System.Drawing.Point(279, 171);
            this.cbox_ilacAdedi.Name = "cbox_ilacAdedi";
            this.cbox_ilacAdedi.Size = new System.Drawing.Size(147, 24);
            this.cbox_ilacAdedi.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "İlaç Adedi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "İlaç Barkod No :";
            // 
            // txt_ilacBarkodNo
            // 
            this.txt_ilacBarkodNo.Location = new System.Drawing.Point(279, 104);
            this.txt_ilacBarkodNo.Name = "txt_ilacBarkodNo";
            this.txt_ilacBarkodNo.Size = new System.Drawing.Size(147, 22);
            this.txt_ilacBarkodNo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reçete No :";
            // 
            // txt_receteNo
            // 
            this.txt_receteNo.Location = new System.Drawing.Point(279, 46);
            this.txt_receteNo.Name = "txt_receteNo";
            this.txt_receteNo.Size = new System.Drawing.Size(147, 22);
            this.txt_receteNo.TabIndex = 2;
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 53);
            this.button1.TabIndex = 23;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_iptal);
            // 
            // RecetedekiIlaclar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_receteyeIlacEkle);
            this.Controls.Add(this.groupBox1);
            this.Name = "RecetedekiIlaclar";
            this.Text = "Reçetedeki İlaçlar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_receteyeIlacEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_receteNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ilacBarkodNo;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbox_ilacAdedi;
    }
}