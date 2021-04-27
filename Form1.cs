using Hotel.Oliot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class HotelManhattan : Form
    {
        private List<mokki> mokit = new List<mokki>();
        private List<Toimialue> toimialueet = new List<Toimialue>();
        private Toimialue t;
        private mokki m;
        private MokkiRaportti mr;
        public HotelManhattan()
        {
            InitializeComponent();
        }

        private void HotelManhattan_Load(object sender, EventArgs e)
        {
            mokit = LFDB.getMokit();
            toimialueet = LFDB.GetToimialue();
            int j = 0;
            tcHotelli.SelectedTab = tpToimialue;
            for (int i = 0; i < toimialueet.Count; i++)
            {
                mokki m = new mokki();
                if (i % 4 == 0 &&  i != 0)
                j++;
                t = new Toimialue();
                Button nappi = t.LuoNapit(toimialueet, i,j);
                tpToimialue.Controls.Add(nappi);
                nappi.Click += new EventHandler(ToimialueValinta);
                
            }
           
            cbPoistaToimi.DataSource = toimialueet;
            cbPoistaToimi.ValueMember = "toimintaAlueNimi";
            cbPoistaToimi.Text = "Valitse...";
            tbToimialueMuokkaa.Visible = false;
            

        }
            private void ToimialueValinta(object sender, EventArgs e)
            {
            dgvMokit.DataSource = null;
            int number = int.Parse((sender as Button).Tag.ToString());
            List<mokki> ToimialueenMokit = new List<mokki>();
            ToimialueenMokit = t.Toimialueet(number);
            dgvMokit.DataSource = ToimialueenMokit;
            tcHotelli.SelectedTab = tpMokki;
            cbMRM.DataSource = ToimialueenMokit;
            cbMRM.ValueMember = "mokkinimi";
            

        }

        private void cbPoistaToimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnToimialueMuokkaa.Enabled = true;
            btnToimialuePoista.Enabled = true;
            tbToimialueMuokkaa.Visible = true;
            tbToimialueMuokkaa.Text = cbPoistaToimi.Text;
        }

        private void btnLisaaToimialue_Click(object sender, EventArgs e)
        {
            int index = toimialueet.Count() + 1;
            string uusiToimialue = tbLisaaToimi.Text;
            t.LisaaToimialue(index,uusiToimialue);
            tbLisaaToimi.Text = "";
            
        }

        private void btnToimialueMuokkaa_Click(object sender, EventArgs e)
        {
            int index = cbPoistaToimi.SelectedIndex+1;
            string muokattuToimialue = tbToimialueMuokkaa.Text;
            t.MuokkaaToimialue(index, muokattuToimialue);
            tbToimialueMuokkaa.Text = "";
            tpToimialue.Update();
        }

        private void btnToimialuePoista_Click(object sender, EventArgs e)
        {
            int index = cbPoistaToimi.SelectedIndex + 1;
            t.PoistaToimialue(index);
            tbToimialueMuokkaa.Text = "";
            tpToimialue.Update();
        }

        private void btnMRaportti_Click(object sender, EventArgs e)
        {
            mr = new MokkiRaportti();
            string nimi = cbMRM.Text;
            DateTime alku = dtbMRalku.Value.Date;
            DateTime loppu = dtbMRloppu.Value.Date;
            mr.Raporting(nimi,alku,loppu);
        }

        private void cbMRM_SelectedValueChanged(object sender, EventArgs e)
        {
            btnMRaportti.Enabled = true;
        }

        private void dtbMRalku_ValueChanged(object sender, EventArgs e)
        {
            dtbMRloppu.Visible = true;
            dtbMRloppu.MinDate = dtbMRalku.Value;
            dtbMRloppu.MaxDate = DateTime.Now;

        }
    }
}
