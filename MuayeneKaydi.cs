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
    public partial class MuayeneKaydi : Form
    {
        public MuayeneKaydi()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres ;User Id=postgres;Password=1234");

        private void btn_muayeneEkle_Click(object sender, EventArgs e)
        {
                baglanti.Open();
                NpgsqlCommand muayeneKaydi_kontrol = new NpgsqlCommand();
                muayeneKaydi_kontrol.Connection = baglanti;
                muayeneKaydi_kontrol.Parameters.AddWithValue("@tc_no", Convert.ToInt64(txt_tcNo.Text));
                muayeneKaydi_kontrol.Parameters.AddWithValue("@muayene_tarihi", txt_muayeneTarihi.Text);
                muayeneKaydi_kontrol.CommandType = CommandType.Text;
                muayeneKaydi_kontrol.CommandText = "SELECT * FROM muayene_kaydi WHERE tc_no = @tc_no AND muayene_tarihi = @muayene_tarihi";
                NpgsqlDataReader dr = muayeneKaydi_kontrol.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Bu hasta için bu tarihte zaten muayene kaydı mevcut. Lütfen farklı bir tarih seçiniz.");
                }
                else
                {
                    baglanti.Close();
                    baglanti.Open();
                    NpgsqlCommand muayeneKaydi_ekle = new NpgsqlCommand();
                    muayeneKaydi_ekle.Connection = baglanti;
                    muayeneKaydi_ekle.Parameters.AddWithValue("@recete_no", txt_receteNo.Text);
                    muayeneKaydi_ekle.Parameters.AddWithValue("@tc_no", Convert.ToInt64(txt_tcNo.Text));
                    muayeneKaydi_ekle.Parameters.AddWithValue("@muayene_tarihi", txt_muayeneTarihi.Text);
                    muayeneKaydi_ekle.Parameters.AddWithValue("@hasta_sikayet", txt_hastaSikayeti.Text);
                    muayeneKaydi_ekle.Parameters.AddWithValue("@tani", txt_doktorTanısı.Text);
                    muayeneKaydi_ekle.Parameters.AddWithValue("@tedavi", txt_tedavi.Text);
                    muayeneKaydi_ekle.CommandType = CommandType.Text;
                    muayeneKaydi_ekle.CommandText = "INSERT INTO muayene_kaydi (recete_no, tc_no, muayene_tarihi, hasta_sikayet, tani, tedavi) " +
                        "VALUES  (@recete_no, @tc_no, @muayene_tarihi, @hasta_sikayet, @tani, @tedavi)";
                    muayeneKaydi_ekle.ExecuteNonQuery();
                    muayeneKaydi_ekle.Dispose();
                    MessageBox.Show("Muayene kaydı başarıyla oluşturuldu.");
                    
                    
                    //txt_tcNo.Clear();
                    //txt_muayeneTarihi.Clear();
                    txt_hastaSikayeti.Clear();
                    txt_doktorTanısı.Clear();
                    txt_tedavi.Clear();
                }
            muayeneKaydi_kontrol.Dispose();
            
            baglanti.Close();


        }

        private void btn_receteEkle_Click(object sender, EventArgs e)
        {
            
                baglanti.Open();

                NpgsqlCommand recete_kontrol = new NpgsqlCommand();
                recete_kontrol.Connection = baglanti;
                recete_kontrol.Parameters.AddWithValue("@recete_no", txt_receteNo.Text);
                recete_kontrol.Parameters.AddWithValue("@tc_no", Convert.ToInt64(txt_tcNo.Text));
                recete_kontrol.Parameters.AddWithValue("@recete_tarihi", txt_muayeneTarihi.Text);
                recete_kontrol.CommandType = CommandType.Text;
                recete_kontrol.CommandText = "SELECT * FROM receteler WHERE tc_no = @tc_no AND recete_tarihi = @recete_tarihi";
                NpgsqlDataReader dr = recete_kontrol.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Bu hasta için bu tarihte zaten reçete kaydı mevcut. Lütfen farklı bir tarih seçiniz.");
                }
                else
                {
                    baglanti.Close();
                    baglanti.Open();

                    NpgsqlCommand recete_ekle = new NpgsqlCommand();
                    recete_ekle.Connection = baglanti;

                    recete_ekle.Parameters.AddWithValue("@recete_no", txt_receteNo.Text);
                    recete_ekle.Parameters.AddWithValue("@recete_tarihi", txt_muayeneTarihi.Text);
                    recete_ekle.Parameters.AddWithValue("@tc_no", Convert.ToInt64(txt_tcNo.Text));

                    recete_ekle.CommandType = CommandType.Text;
                    recete_ekle.CommandText = "insert into receteler (recete_no, recete_tarihi, tc_no) " +
                        "values  (@recete_no, @recete_tarihi, @tc_no)";

                    NpgsqlDataReader ydr = recete_ekle.ExecuteReader();
                    if (ydr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(ydr);

                    }
                    recete_ekle.Dispose();

                    MessageBox.Show("Reçete kaydı başarıyla oluşturuldu. Reçete numarası :  " + txt_receteNo.Text);
                }
                recete_kontrol.Dispose();
                baglanti.Close();
            
        }
    }
}
