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
    public partial class ReceteListele : Form
    {
        public ReceteListele()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres ;User Id=postgres;Password=1234");

        private void btn_hastaReceteListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand hastaReceteListele;

            hastaReceteListele = new NpgsqlCommand();
            hastaReceteListele.Connection = baglanti;
            hastaReceteListele.Parameters.AddWithValue("@seciliTC_No", Convert.ToInt64(txt_tcNo.Text));
            hastaReceteListele.CommandType = CommandType.Text;
            hastaReceteListele.CommandText = "select * from receteler where tc_no = @seciliTC_No";

            NpgsqlDataReader dr = hastaReceteListele.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView_recete.DataSource = dt;
            }

            hastaReceteListele.Dispose();
            baglanti.Close();
        }

        private void btn_receteListeleme_Click(object sender, EventArgs e)
        {
            txt_tcNo.Clear();

            baglanti.Open();
            NpgsqlCommand receteleriListele;
            receteleriListele = new NpgsqlCommand("select * from receteler order by tc_no", baglanti);
            //order by eksik

            NpgsqlDataReader dr = receteleriListele.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView_recete.DataSource = dt;
            }

            receteleriListele.Dispose();
            baglanti.Close();
        }
    }
}
