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
    public partial class MuayeneListele : Form
    {
        public MuayeneListele()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres ;User Id=postgres;Password=1234");

        private void btn_seciliHastaListele_Click(object sender, EventArgs e)
        {
            txt_muayeneTarihi.Clear();
            baglanti.Open();
            NpgsqlCommand hastaMuayeneListele;

            hastaMuayeneListele = new NpgsqlCommand();
            hastaMuayeneListele.Connection = baglanti;
            hastaMuayeneListele.Parameters.AddWithValue("@seciliTC_No", Convert.ToInt64(txt_tcNo.Text));
            hastaMuayeneListele.CommandType = CommandType.Text;
            hastaMuayeneListele.CommandText = "select hastalar.hasta_ad, hastalar.hasta_soyad, muayene_kaydi.* from muayene_kaydi inner join hastalar on hastalar.tc_no = muayene_kaydi.tc_no where muayene_kaydi.tc_no = @seciliTC_No order by muayene_kaydi.muayene_tarihi";

            NpgsqlDataReader dr = hastaMuayeneListele.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView_muayene.DataSource = dt;
            }

            hastaMuayeneListele.Dispose();
            baglanti.Close();
        }

        private void btn_muayeneTarihListeleme_Click(object sender, EventArgs e)
        {
            txt_tcNo.Clear();
            baglanti.Open();
            NpgsqlCommand muayeneListele_tarih;

            muayeneListele_tarih = new NpgsqlCommand();
            muayeneListele_tarih.Connection = baglanti;
            muayeneListele_tarih.Parameters.AddWithValue("@seciliTarih", txt_muayeneTarihi.Text);
            muayeneListele_tarih.CommandType = CommandType.Text;
            muayeneListele_tarih.CommandText = "select muayene_kaydi.* , hastalar.hasta_ad, hastalar.hasta_soyad from muayene_kaydi inner join hastalar on hastalar.tc_no = muayene_kaydi.tc_no where muayene_tarihi = @seciliTarih order by muayene_kaydi.muayene_tarihi";
           
            NpgsqlDataReader dr = muayeneListele_tarih.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView_muayene.DataSource = dt;
            }

            muayeneListele_tarih.Dispose();
            baglanti.Close();
        }

        private void btn_muayeneListele_Click(object sender, EventArgs e)
        {
            txt_muayeneTarihi.Clear();
            txt_tcNo.Clear();
            baglanti.Open();
            NpgsqlCommand tumMuayeneListele;
            tumMuayeneListele = new NpgsqlCommand("select hastalar.hasta_ad, hastalar.hasta_soyad, muayene_kaydi.* from muayene_kaydi inner join hastalar on hastalar.tc_no = muayene_kaydi.tc_no order by muayene_kaydi.muayene_tarihi", baglanti);


            NpgsqlDataReader dr = tumMuayeneListele.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView_muayene.DataSource = dt;
            }

            tumMuayeneListele.Dispose();
            baglanti.Close();
        }
    }
}
