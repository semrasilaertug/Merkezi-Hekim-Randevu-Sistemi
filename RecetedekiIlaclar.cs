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
    public partial class RecetedekiIlaclar : Form
    {
        public RecetedekiIlaclar()
        {
            InitializeComponent();
            cbox_ilacAdedi.SelectedIndex= 0;
        }

        int sayac = 0; 

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres ;User Id=postgres;Password=1234");

        private void btn_receteyeIlacEkle_Click(object sender, EventArgs e)
        {
            

            baglanti.Open();
            NpgsqlCommand receteIlacEkle = new NpgsqlCommand();
            receteIlacEkle.Connection = baglanti;

            receteIlacEkle.Parameters.AddWithValue("@recete_no", txt_receteNo.Text);
            receteIlacEkle.Parameters.AddWithValue("@barkod_no", Convert.ToInt32(txt_ilacBarkodNo.Text));
            receteIlacEkle.Parameters.AddWithValue("@ilac_adedi", Convert.ToInt32(cbox_ilacAdedi.SelectedItem));



            receteIlacEkle.CommandType = CommandType.Text;
            receteIlacEkle.CommandText = "insert into recetedeki_ilaclar (recete_no, barkod_no, ilac_adedi) " +
                "values  (@recete_no, @barkod_no, @ilac_adedi)";

            NpgsqlDataReader dr = receteIlacEkle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);

            }
            receteIlacEkle.Dispose();
            baglanti.Close();

            MessageBox.Show("Hastanın reçetesine başarıyla ilaç eklendi.");

                baglanti.Close();
                txt_ilacBarkodNo.Clear();
                cbox_ilacAdedi.SelectedIndex = 0;
                txt_ilacBarkodNo.Focus();
            sayac++;
            int gerisayim = 5 - sayac;
            MessageBox.Show(gerisayim + " ilaç ekleme hakkınız kaldı.");
            if (sayac==5)
            {
                btn_receteyeIlacEkle.Enabled = false;
            }
        }

        private void btn_iptal(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
