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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hastaKaydıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniHastaKaydi yeniHastaKaydi = new YeniHastaKaydi();
            yeniHastaKaydi.Show();
        }

        private void muayeneKaydıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayeneKaydi muayeneKaydi = new MuayeneKaydi();
            muayeneKaydi.Show();
        }

        

        private void ilaçKaydıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ilaclar ilaclar = new Ilaclar();
            ilaclar.Show();
        }

        private void ilaçListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaListele hastaListele = new HastaListele(); 
            hastaListele.Show();
        }

        private void muayeneListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MuayeneListele muayeneListele = new MuayeneListele();
            muayeneListele.Show();
        }

        private void ilaçKayıtlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceteListele receteListele = new ReceteListele();
            receteListele.Show();
        }

        private void ilaçKayıtlarıToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IlacListele ilacListele = new IlacListele();
            ilacListele.Show();
        }

        private void hastanınAldığıİlaçlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecetedekiIlaclariListele hastaIlacListele = new RecetedekiIlaclariListele();
            hastaIlacListele.Show();
        }

        private void ilacıAlanHastalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ilacıAlanHastalar ilacıAlanHastalar = new ilacıAlanHastalar();
            ilacıAlanHastalar.Show();
        }

        private void reçeteyeİlaçKaydıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecetedekiIlaclar recetedekiIlaclar = new RecetedekiIlaclar();
            recetedekiIlaclar.Show();
        }
    }
}
