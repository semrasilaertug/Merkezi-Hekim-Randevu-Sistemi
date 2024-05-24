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
    public partial class IlacListele : Form
    {
        public IlacListele()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres ;User Id=postgres;Password=1234");


        private void btn_ilacListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand ilacListele;
            ilacListele = new NpgsqlCommand("select * from ilaclar", baglanti);


            NpgsqlDataReader dr = ilacListele.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView_ilacListesi.DataSource = dt;
            }

            ilacListele.Dispose();
            baglanti.Close();
        }
    }
}
