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
    public partial class YeniHastaKaydi : Form
    {
        public YeniHastaKaydi()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres ;User Id=postgres;Password=1234");

        private void btn_hastaEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand hasta_ekle = new NpgsqlCommand();
            hasta_ekle.Connection = baglanti;

            hasta_ekle.Parameters.AddWithValue("@tc_no", Convert.ToInt64(txt_tcNo.Text));
            hasta_ekle.Parameters.AddWithValue("@hasta_ad", txt_hastaAd.Text);
            hasta_ekle.Parameters.AddWithValue("@hasta_soyad", txt_hastaSoyad.Text);
            hasta_ekle.Parameters.AddWithValue("@dogum_yeri", txt_dogumYeri.Text);
            hasta_ekle.Parameters.AddWithValue("@dogum_tarihi", txt_dogumTarihi.Text);
            hasta_ekle.Parameters.AddWithValue("@medeni_durum", txt_medeniDurum.Text);
            hasta_ekle.Parameters.AddWithValue("@adres", txt_adres.Text);
            hasta_ekle.Parameters.AddWithValue("@telefon", Convert.ToInt32(txt_telefon.Text));

            hasta_ekle.CommandType = CommandType.Text;
            hasta_ekle.CommandText = "insert into hastalar (tc_no, hasta_ad, hasta_soyad, dogum_yeri, dogum_tarihi, medeni_durum, adres, telefon) " +
                "values  (@tc_no, @hasta_ad, @hasta_soyad, @dogum_yeri, @dogum_tarihi, @medeni_durum, @adres, @telefon)";

            NpgsqlDataReader dr = hasta_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);

            }
            hasta_ekle.Dispose();
            baglanti.Close();

            MessageBox.Show("Hasta kaydı başarıyla oluşturuldu. ");
            txt_tcNo.Clear();
            txt_hastaAd.Clear();
            txt_hastaSoyad.Clear();
            txt_dogumYeri.Clear();
            txt_dogumTarihi.Clear();
            txt_medeniDurum.Clear();
            txt_adres.Clear();
            txt_telefon.Clear();
        }
    }
}
