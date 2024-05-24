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
    public partial class ilacıAlanHastalar : Form
    {
        public ilacıAlanHastalar()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres ;User Id=postgres;Password=1234");

        private void btn_ilacıAlanHastaList_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand ilacınHastalariListele;

            ilacınHastalariListele = new NpgsqlCommand();
            ilacınHastalariListele.Connection = baglanti;
            ilacınHastalariListele.Parameters.AddWithValue("@seciliBarkod_No", Convert.ToInt32(txt_ilacBarkodNo.Text));
            ilacınHastalariListele.CommandType = CommandType.Text;
            ilacınHastalariListele.CommandText = "select muayene_kaydi.recete_no, hastalar.tc_no, hastalar.hasta_ad, hastalar.hasta_soyad from ((hastalar inner join muayene_kaydi on hastalar.tc_no = muayene_kaydi.tc_no) inner join recetedeki_ilaclar on muayene_kaydi.recete_no = recetedeki_ilaclar.recete_no) where recetedeki_ilaclar.barkod_no = @seciliBarkod_No ";

            NpgsqlDataReader dr = ilacınHastalariListele.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView_ilaciAlanHasta.DataSource = dt;
            }

            ilacınHastalariListele.Dispose();
            baglanti.Close();
        }
    }
}
