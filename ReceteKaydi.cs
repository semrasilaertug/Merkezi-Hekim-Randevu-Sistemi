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
    public partial class ReceteKaydi : Form
    {
        public ReceteKaydi()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres ;User Id=postgres;Password=1234");

        private void btn_receteEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand recete_ekle = new NpgsqlCommand();
            recete_ekle.Connection = baglanti;

            recete_ekle.Parameters.AddWithValue("@recete_no", txt_receteNo.Text);
            recete_ekle.Parameters.AddWithValue("@recete_tarihi", txt_receteTarihi.Text);
            recete_ekle.Parameters.AddWithValue("@tc_no", Convert.ToInt32(txt_tcNo.Text));

            recete_ekle.CommandType = CommandType.Text;
            recete_ekle.CommandText = "insert into receteler (recete_no, recete_tarihi, tc_no) " +
                "values  (@recete_no, @recete_tarihi, @tc_no)";

            NpgsqlDataReader dr = recete_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);

            }
            recete_ekle.Dispose();
            baglanti.Close();

            MessageBox.Show("Reçete kaydı başarıyla oluşturuldu. ");
            txt_receteNo.Clear();
            txt_receteTarihi.Clear(); 
            txt_tcNo.Clear();
        }
    }
}
