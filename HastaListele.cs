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
    public partial class HastaListele : Form
    {
        public HastaListele()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres ;User Id=postgres;Password=1234");

        private void btn_seciliHastaListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand seciliHastaListele;

             seciliHastaListele = new NpgsqlCommand();
             seciliHastaListele.Connection = baglanti;
             seciliHastaListele.Parameters.AddWithValue("@seciliTC_No", Convert.ToInt64(txt_tcNo.Text));
             seciliHastaListele.CommandType = CommandType.Text;
             seciliHastaListele.CommandText = "select * from hastalar where tc_no = @seciliTC_No";
            
            NpgsqlDataReader dr = seciliHastaListele.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView_hasta.DataSource = dt;
            }

            seciliHastaListele.Dispose();
            baglanti.Close();
        }

        private void btn_tumHastalariListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand seciliHastaListele;
            seciliHastaListele = new NpgsqlCommand("select * from hastalar", baglanti);


            NpgsqlDataReader dr = seciliHastaListele.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView_hasta.DataSource = dt;
            }

            seciliHastaListele.Dispose();
            baglanti.Close();
        }
    }
}
