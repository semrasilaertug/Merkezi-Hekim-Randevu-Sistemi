using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBYS
{
    public partial class Ilaclar : Form
    {
        public Ilaclar()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres ;User Id=postgres;Password=1234");

        private void btn_ilacEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand ilac_ekle = new NpgsqlCommand();
            ilac_ekle.Connection = baglanti;

            ilac_ekle.Parameters.AddWithValue("@barkod_no", Convert.ToInt32(txt_ilacBarkodNo.Text));
            ilac_ekle.Parameters.AddWithValue("@ilac_adi", txt_ilacAd.Text);
            ilac_ekle.Parameters.AddWithValue("@ilac_tipi", txt_ilacTipi.Text);
            ilac_ekle.CommandType = CommandType.Text;
            ilac_ekle.CommandText = "insert into ilaclar (barkod_no, ilac_adi, ilac_tipi) " +
                "values  (@barkod_no, @ilac_adi, @ilac_tipi)";

            NpgsqlDataReader dr = ilac_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);

            }
            ilac_ekle.Dispose();
            baglanti.Close();

            MessageBox.Show("İlaç kaydı başarıyla oluşturuldu. ");
            txt_ilacBarkodNo.Clear();
            txt_ilacAd.Clear();
            txt_ilacTipi.Clear();
        }
    }
}
