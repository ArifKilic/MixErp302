using MixErp302.Bilgi;
using MixErp302.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixErp302
{
    public partial class frmAnaSayfa : Form
    {
        Formlar F = new Formlar();
        
            public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnBilgiDiris_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void btbUrun_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            F.PersGiris();
        }


        private void btnCariGiris_Click(object sender, EventArgs e)
        {
            F.CariGiris();
        }

        

        private void btnUrunGiris_Click_1(object sender, EventArgs e)
        {
            F.UrunGiris();
        }

        private void btnUrunAlis_Click(object sender, EventArgs e)
        {
            F.UrunAlis();
        }

        private void btnUrunSatis_Click(object sender, EventArgs e)
        {
            F.UrunSatis();
        }
    }
}
