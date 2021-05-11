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
        private List<Asiakas> asiakkaat = new List<Asiakas>();
        private List<Asiakas> asiakkaatSuodatin = new List<Asiakas>();
        private List<mokki> ToimialueenMokit = new List<mokki>();
        private List<Varaus> Varaukset = new List<Varaus>();
        private List<Varaustiedot> VarauksienTiedot = new List<Varaustiedot>();
        private int currToimAlue;
        private Toimialue t;
        private mokki m = new mokki();
        private Asiakas a = new Asiakas();
        private Palvelu p = new Palvelu();
        private List<Palvelu> palvelut = new List<Palvelu>();
        private List<Lasku> Laskut = new List<Lasku>();


        public HotelManhattan()
        {
            InitializeComponent();



        }

        private void HotelManhattan_Load(object sender, EventArgs e)
        {
   
            // Toimialueet ja mökit
            mokit = LFDB.getMokit();
            toimialueet = LFDB.GetToimialue();
            tcHotelli.SelectedTab = tpToimialue;
            luoNappi();
            cbPoistaToimi.DataSource = toimialueet;
            cbPoistaToimi.ValueMember = "toimintaAlueNimi";
            cbPoistaToimi.Text = "Valitse...";
            tbToimialueMuokkaa.Visible = false;

            //Varaukset ja asiakashallinta
            asiakkaat = LFDB.getAsiakas();
            cbVaraukset.DataSource = asiakkaat;
            cbVaraukset.DisplayMember = "AsiakasID";
            cbVaraukset.ValueMember = "AsiakasID";
            dgvAsiakas.DataSource = asiakkaat;
            cmbAsiakasToimialue.DataSource = toimialueet;
            cmbAsiakasToimialue.DisplayMember = "toimintaAlueNimi";
            cmbAsiakasToimialue.ValueMember = "toimintaAlueNimi";
            cmbAsiakasToimialue.Enabled = false;
            tbAsiakasHakuNimi.Enabled = false;
            rbtnAsiakasKaikki.Checked = true;

            //Laskut
            Laskut = LFDB.getLasku();
            dgvLaskut.DataSource = Laskut;
            

            //Palvelut
            dgv_palvelut.DataSource = LFDB.getPalvelut();

        }
        private void HotelManhattan_Activated(object sender, EventArgs e)
        {
            asiakkaat = LFDB.getAsiakas();
            dgvAsiakas.DataSource = null;
            dgvAsiakas.DataSource = asiakkaat;
            rbtnAsiakasKaikki.Checked = true;

            cbVaraukset.DataSource = asiakkaat;
            cbVaraukset.DisplayMember = "AsiakasID";
            cbVaraukset.ValueMember = "AsiakasID";



        }
        /* Toimialueen toiminnot*/
        public void luoNappi()
        {
            gbToimialueet.Controls.Clear();
            this.Refresh();
            int x = 8;
            int y = 15;
            int j = 0;
            for (int i = 0; i < toimialueet.Count; i++)
            {
                mokki m = new mokki();
                if (i % 4 == 0 && i != 0)
                    j++;
                if (i >= 1)
                {
                    x = x + 212;
                    if (x >= 212 * 4)
                    {
                        y = y + 206;
                        x = 8 + 212 * (i - (4 * j));
                    }
                }
                Button ToimiAlueNappi = new Button();
                ToimiAlueNappi.Location = new System.Drawing.Point(x, y);
                ToimiAlueNappi.Name = "ToimiAlue" + i;
                ToimiAlueNappi.Size = new System.Drawing.Size(206, 190);
                ToimiAlueNappi.TabIndex = i;
                ToimiAlueNappi.Text = toimialueet[i].ToimintaAlueNimi.ToString();
                ToimiAlueNappi.UseVisualStyleBackColor = true;
                ToimiAlueNappi.Tag = toimialueet[i].ToimintaAlueID;
                t = new Toimialue();
                gbToimialueet.Controls.Add(ToimiAlueNappi);
                ToimiAlueNappi.Click += new EventHandler(ToimialueValinta);

            }
        }
        private void ToimialueValinta(object sender, EventArgs e)
        {
            dgvMokit.DataSource = null;
            currToimAlue = int.Parse((sender as Button).Tag.ToString());
            ToimialueenMokit = new List<mokki>();

            ToimialueenMokit = t.Toimialueet(currToimAlue);
            dgvMokit.DataSource = ToimialueenMokit;
            tcHotelli.SelectedTab = tpMokki;

            cbMRM.DataSource = null;
            cbMRM.Items.Clear();
            cbMRM.DataSource = ToimialueenMokit;
            cbMRM.DisplayMember = "mokkinimi";
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
            string uusiToimialue = tbLisaaToimi.Text;
            t.LisaaToimialue(uusiToimialue);
            tbLisaaToimi.Text = "";
            gbToimialueet.Controls.Clear();
            toimialueet.Clear();
            toimialueet = LFDB.GetToimialue();
            luoNappi();
            FormatDisplay();

        }
        private void btnToimialueMuokkaa_Click(object sender, EventArgs e)
        {
            t = (Toimialue)cbPoistaToimi.SelectedItem;

            string muokattuToimialue = tbToimialueMuokkaa.Text;
            t.MuokkaaToimialue(t.ToimintaAlueID, muokattuToimialue);
            tbToimialueMuokkaa.Text = "";
            gbToimialueet.Controls.Clear();
            toimialueet.Clear();
            toimialueet = LFDB.GetToimialue();
            luoNappi();
            FormatDisplay();
        }
        private void btnToimialuePoista_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Haluatko varmasti poistaa Toimialueen?\nHuomioithan, ettei toimialuetta voi poistaa, jos sillä on mökkejä.", "Poisto", MessageBoxButtons.OKCancel);
            if (result != DialogResult.Cancel)
            {
                t = (Toimialue)cbPoistaToimi.SelectedItem;
                t.PoistaToimialue(t.ToimintaAlueID);
                tbToimialueMuokkaa.Text = "";
                gbToimialueet.Controls.Clear();
                toimialueet.Clear();
                toimialueet = LFDB.GetToimialue();
                luoNappi();
                FormatDisplay();
            }
            else
                return;

        }
        private void FormatDisplay()
        {
            cbPoistaToimi.DataSource = null;
            cbPoistaToimi.Items.Clear();
            cbPoistaToimi.DataSource = toimialueet;
            cbPoistaToimi.DisplayMember = "toimintaAlueNimi";
            cbPoistaToimi.ValueMember = "toimintaAlueNimi";
            cbPoistaToimi.Text = "Valitse...";
            tbToimialueMuokkaa.Visible = false;
        }

        /* Mokkien toiminnot*/

        private void btnMokkiLisaa_Click(object sender, EventArgs e)
        {
            MokkiNakyma LisaaMokki = new MokkiNakyma(currToimAlue);
            LisaaMokki.Text = "Lisaa mokki";
            LisaaMokki.Show();
        }
        private void btnMokkiMuokkaa_Click(object sender, EventArgs e)
        {

            mokki m = new mokki();
            m = (mokki)dgvMokit.CurrentRow.DataBoundItem;
            MokkiNakyma LisaaMokki = new MokkiNakyma(m);

            LisaaMokki.Text = "Muokkaa mokkia";
            LisaaMokki.ShowDialog();

        }
        private void btnMokkiPoista_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Haluatko varmasti poistaa mökin?\nHuomioithan, ettei mökkiä voi poistaa, jos sillä on varauksia.", "Poisto", MessageBoxButtons.OKCancel);
            if (result != DialogResult.Cancel)
            {
                mokki poista = new mokki();
                poista = (mokki)dgvMokit.CurrentRow.DataBoundItem;
                int mokinpoisto = poista.MokkiID;
                LFDB.RemoveMokki(mokinpoisto);
                ToimialueenMokit.Clear();
                ToimialueenMokit = t.Toimialueet(currToimAlue);
                dgvMokit.DataSource = null;
                dgvMokit.DataSource = ToimialueenMokit;
            }
            else
                return;

        }
        private void btnMRaportti_Click(object sender, EventArgs e)
        {
            mokki m = (mokki)cbMRM.SelectedItem;
            DateTime a = dtbMRalku.Value;
            DateTime l = dtbMRloppu.Value;
            MokkiRaportti.Raporting(m.MokkiID, a, l);
            MessageBox.Show("Tiedosto Tallennettiin", "Raportointi", MessageBoxButtons.OK);

        }
        private void dtbMRalku_ValueChanged(object sender, EventArgs e)
        {
            dtbMRloppu.MinDate = dtbMRalku.Value;
            dtbMRloppu.Visible = true;
            dtbMRloppu.Value = DateTime.Now;
            btnMRaportti.Enabled = true;
        }

        /* Asiakkaan toiminnot*/
        private void btnAsiakasLisaa_Click(object sender, EventArgs e)
        {
            AsiakasNakyma an = new AsiakasNakyma();
            an.ShowDialog();
        }
        private void btnAsiakasMuokkaa_Click(object sender, EventArgs e)
        {
            Asiakas a = new Asiakas();
            a = (Asiakas)dgvAsiakas.CurrentRow.DataBoundItem;
            AsiakasNakyma an = new AsiakasNakyma(a);
            an.ShowDialog();
        }
        private void btnAsiakasPoista_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Haluatko varmasti poistaa asiakkaan?\nHuomioithan, ettei asiakasta voi poistaa, jos hänellä on varauksia.", "Poisto", MessageBoxButtons.OKCancel);
            if (result != DialogResult.Cancel)
            {
                Asiakas poista = new Asiakas();
                poista = (Asiakas)dgvAsiakas.CurrentRow.DataBoundItem;
                LFDB.RemoveAsiakas(poista.AsiakasID);
                //asiakkaat.Remove(poista);
                asiakkaat.Clear();
                asiakkaat = LFDB.getAsiakas();
                dgvAsiakas.DataSource = null;
                dgvAsiakas.DataSource = asiakkaat;
            }
            else
                return;
        }
        private void btnAsiakasSiirryVaraus_Click(object sender, EventArgs e)
        {
            tcHotelli.SelectedTab = tpVaraus;
        }

        private void cmbAsiakasToimialue_SelectedIndexChanged(object sender, EventArgs e)
        {
            asiakkaatSuodatin.Clear();
            Toimialue asiakasSuodToimi = (Toimialue)cmbAsiakasToimialue.SelectedItem;
            foreach (Asiakas a in asiakkaat)
            {
                List<Varaustiedot> varauksetSuodatus = new List<Varaustiedot>();
                varauksetSuodatus = LFDB.getVarausAsiakkaan(a.AsiakasID);
                foreach (Varaustiedot v in varauksetSuodatus)
                {
                    if (v.ToimintaalueNimi.ToString() == asiakasSuodToimi.ToimintaAlueNimi.ToString() && !asiakkaatSuodatin.Contains(a))
                    asiakkaatSuodatin.Add(a);
                }
            }
            dgvAsiakas.DataSource = null;
            dgvAsiakas.DataSource = asiakkaatSuodatin;
        }

        private void rbtnAsiakasKaikki_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAsiakasKaikki.Checked)
            {
                asiakkaat.Clear();
                asiakkaat = LFDB.getAsiakas();
                dgvAsiakas.DataSource = null;
                dgvAsiakas.DataSource = asiakkaat;                
            }
        }
        private void rbtnAsiakasToimi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAsiakasToimi.Checked)
            {
                cmbAsiakasToimialue.Enabled = true;
                asiakkaatSuodatin.Clear();
                Toimialue asiakasSuodToimi = (Toimialue)cmbAsiakasToimialue.SelectedItem;
                foreach (Asiakas a in asiakkaat)
                {
                    List<Varaustiedot> varauksetSuodatus = new List<Varaustiedot>();
                    varauksetSuodatus = LFDB.getVarausAsiakkaan(a.AsiakasID);
                    foreach (Varaustiedot v in varauksetSuodatus)
                    {
                        if (v.ToimintaalueNimi.ToString() == asiakasSuodToimi.ToimintaAlueNimi.ToString() && !asiakkaatSuodatin.Contains(a))
                            asiakkaatSuodatin.Add(a);
                    }
                }
                dgvAsiakas.DataSource = null;
                dgvAsiakas.DataSource = asiakkaatSuodatin;
            }
            else
                cmbAsiakasToimialue.Enabled = false;
        }

        private void rbtnAsiakasHakuNimi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAsiakasHakuNimi.Checked)
            {
                tbAsiakasHakuNimi.Enabled = true;
                asiakkaatSuodatin.Clear();
                asiakkaatSuodatin = LFDB.getAsiakasBySukunimi(tbAsiakasHakuNimi.Text);
                dgvAsiakas.DataSource = null;
                dgvAsiakas.DataSource = asiakkaatSuodatin;
            }
            else
                tbAsiakasHakuNimi.Enabled = false;
        }
        private void tbAsiakasHakuNimi_KeyUp(object sender, KeyEventArgs e)
        {
            asiakkaatSuodatin.Clear();
            asiakkaatSuodatin = LFDB.getAsiakasBySukunimi(tbAsiakasHakuNimi.Text);
            dgvAsiakas.DataSource = null;
            dgvAsiakas.DataSource = asiakkaatSuodatin;
        }

        /* Laskun toiminnot*/
        private void HaelaskutNappi_Click(object sender, EventArgs e)
        {

        }

        private void PoistaLasku_Click(object sender, EventArgs e)
        {
            Lasku poista = new Lasku();
            poista = (Lasku)dgvLaskut.CurrentRow.DataBoundItem;
            LFDB.RemoveLasku(poista.LaskuID);
            Laskut.Remove(poista);
            dgvLaskut.DataSource = null;
            dgvLaskut.DataSource = Laskut;
        }

        /* Varausten toiminnot*/
        private void btnUusiVaraus_Click(object sender, EventArgs e)
        {
            VarausNakyma LisaaVaraus = new VarausNakyma(Varaukset.Count);
            LisaaVaraus.Text = "Lisaa Varaus";
            LisaaVaraus.Show();
        }
        private void cbVaraukset_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgvVaraus.DataSource = null;
            Asiakas A = (Asiakas)cbVaraukset.SelectedItem;
            VarauksienTiedot = LFDB.getVarausAsiakkaan(A.AsiakasID);
            dgvVaraus.DataSource = VarauksienTiedot;



        }
        private void btnMuokkaaVarausta_Click(object sender, EventArgs e)
        {
            Varaustiedot VarausM = (Varaustiedot)dgvVaraus.CurrentRow.DataBoundItem;
            VarausNakyma MuokkaaVarausta = new VarausNakyma(VarausM);
            MuokkaaVarausta.Text = "Muokkaa Varausta";
            MuokkaaVarausta.Show();
        }
        
        private void btnPoistaVaraus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Haluatko varmasti poistaa varaukset?", "Poisto", MessageBoxButtons.OKCancel);
            if (result != DialogResult.Cancel)
            {
                Varaustiedot VarausP = (Varaustiedot)dgvVaraus.CurrentRow.DataBoundItem;
                List<PalvelutVaraukseen> PoistettavatPalvelut = new List<PalvelutVaraukseen>();
                PoistettavatPalvelut = LFDB.GetVarauksenPalvelut(VarausP.Varaus_id);
                foreach (PalvelutVaraukseen pv in PoistettavatPalvelut)
                {
                    LFDB.RemoveVarauksenPalvelut(pv);
                }
                LFDB.RemoveVaraus(VarausP.Varaus_id);

                dgvVaraus.DataSource = null;
                Asiakas A = (Asiakas)cbVaraukset.SelectedItem;
                VarauksienTiedot = LFDB.getVarausAsiakkaan(A.AsiakasID);
                dgvVaraus.DataSource = VarauksienTiedot;
            }
            else
                return;
        }


        /* Palvelun toiminnot*/
        private void lisääp_btn(object sender, EventArgs e)
        {
            PalveluNakyma lisaaPalvelu = new PalveluNakyma(palvelut.Count);
            lisaaPalvelu.Text = "Lisaa palvelu varaus";
            lisaaPalvelu.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            

        }

        private void poistapalvelu_btn_Click(object sender, EventArgs e)
        {
            Palvelu poistaPalvelu = new Palvelu();
            poistaPalvelu = (Palvelu)dgv_palvelut.CurrentRow.DataBoundItem;
            LFDB.RemovePalvelu(poistaPalvelu.PalveluID);
            palvelut.Remove(poistaPalvelu);
            dgv_palvelut.DataSource = null;
            dgv_palvelut.DataSource = palvelut;
        }

        private void muokkaapalvelua_btn_Click(object sender, EventArgs e)
        {
            Palvelu muokkaaPalvelu = (Palvelu)dgv_palvelut.CurrentRow.DataBoundItem;
            PalveluNakyma muokkaaPalvelua = new PalveluNakyma(muokkaaPalvelu);
            muokkaaPalvelua.Text = "Muokkaa palvelua";
            muokkaaPalvelua.Show();
            
        }

        private void praportti_btn_Click(object sender, EventArgs e)
        {

        }

        
    }
}
