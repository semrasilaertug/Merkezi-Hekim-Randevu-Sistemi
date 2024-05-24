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
    public partial class RecetedekiIlaclariListele : Form
    {
        public RecetedekiIlaclariListele()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres ;User Id=postgres;Password=1234");

        private void btn_receteIlacListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand hastaIlacListele;

            hastaIlacListele = new NpgsqlCommand();
            hastaIlacListele.Connection = baglanti;
            hastaIlacListele.Parameters.AddWithValue("@seciliRecete_No", txt_receteNo.Text);
            hastaIlacListele.CommandType = CommandType.Text;
            hastaIlacListele.CommandText = "select recetedeki_ilaclar.recete_no, recetedeki_ilaclar.barkod_no, recetedeki_ilaclar.ilac_adedi, ilaclar.ilac_adi, ilaclar.ilac_tipi from recetedeki_ilaclar inner join ilaclar  on ilaclar.barkod_no = recetedeki_ilaclar.barkod_no where recetedeki_ilaclar.recete_no = @seciliRecete_No order by ilaclar.ilac_adi  ";

            NpgsqlDataReader dr = hastaIlacListele.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView_recetedekiIlaclar.DataSource = dt;
            }

            hastaIlacListele.Dispose();
            baglanti.Close();
            txt_receteNo.Clear();
        }
    }
}
