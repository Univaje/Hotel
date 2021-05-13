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
        private BindingList<Asiakas> asiakkaatB = new BindingList<Asiakas>();
        private BindingList<Asiakas> asiakkaatSuodatinT = new BindingList<Asiakas>();
        private List<Asiakas> asiakkaatSuodatinS = new List<Asiakas>();
        private BindingList<Asiakas> asiakkaatSuodatinSB = new BindingList<Asiakas>();
        private List<Varaustiedot> varauksetAsiakasSuodatus = new List<Varaustiedot>();
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
            asiakkaatB = convertToBindingAsiakas(asiakkaat);
            cbVaraukset.DataSource = asiakkaatB;
            cbVaraukset.DisplayMember = "AsiakasID";
            cbVaraukset.ValueMember = "AsiakasID";
            dgvAsiakas.DataSource = asiakkaatB;
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

            UpdateMokkiGrid();

            cbMRM.DataSource = null;
            cbMRM.Items.Clear();
            cbMRM.DataSource = ToimialueenMokit;
            cbMRM.DisplayMember = "mokkinimi";
            cbMRM.ValueMember = "mokkinimi";
            btnMokkiLisaa.Enabled = true;
            btnMokkiMuokkaa.Enabled = true;
            btnMokkiPoista.Enabled = true;

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
            DialogResult result = MessageBox.Show("Haluatko varmasti poistaa Toimialueen?\nHuomioithan ettei toimialuetta voi poistaa jos sillä on mökkejä", "Poisto", MessageBoxButtons.OKCancel);
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
            MokkiNakyma LisaaMokki = new MokkiNakyma(currToimAlue, this);
            LisaaMokki.Text = "Lisaa mokki";
            LisaaMokki.Show();
        }
        private void btnMokkiMuokkaa_Click(object sender, EventArgs e)
        {

            mokki m = new mokki();
            m = (mokki)dgvMokit.CurrentRow.DataBoundItem;
            MokkiNakyma LisaaMokki = new MokkiNakyma(m, this);

            LisaaMokki.Text = "Muokkaa mokkia";
            LisaaMokki.ShowDialog();

        }
        private void btnMokkiPoista_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Haluatko varmasti poistaa mökin?\nHuomioithan ettei mökkiä voi poistaa jos sillä on varauksia", "Poisto", MessageBoxButtons.OKCancel);
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
        public void UpdateMokkiGrid()
        {
            dgvMokit.DataSource = null;
            ToimialueenMokit = t.Toimialueet(currToimAlue);
            dgvMokit.DataSource = ToimialueenMokit;
            tcHotelli.SelectedTab = tpMokki;
        }

        /* Asiakkaan toiminnot*/
        public void UpdateGridAsiakas()
        {
            asiakkaat = LFDB.getAsiakas();
            asiakkaatB = convertToBindingAsiakas(asiakkaat);
            dgvAsiakas.DataSource = null;
            dgvAsiakas.DataSource = asiakkaatB;
            rbtnAsiakasKaikki.Checked = true;
            asiakasCountCheck(asiakkaat);

            // Päivitetään combon datasource
            cbVaraukset.DataSource = asiakkaatB;
            cbVaraukset.DisplayMember = "AsiakasID";
            cbVaraukset.ValueMember = "AsiakasID";
        }     
        private void asiakasCountCheck(List<Asiakas> listToCheck)
        {
            if (listToCheck.Count < 1)
            {
                btnAsiakasMuokkaa.Enabled = false;
                btnAsiakasPoista.Enabled = false;
                btnAsiakasSiirryVaraus.Enabled = false;
            }
            else
            {
                btnAsiakasMuokkaa.Enabled = true;
                btnAsiakasPoista.Enabled = true;
                btnAsiakasSiirryVaraus.Enabled = true;
            }
        }
        private void asiakasCountCheck(BindingList<Asiakas> listToCheck)
        {
            if (listToCheck.Count < 1)
            {
                btnAsiakasMuokkaa.Enabled = false;
                btnAsiakasPoista.Enabled = false;
                btnAsiakasSiirryVaraus.Enabled = false;
            }
            else
            {
                btnAsiakasMuokkaa.Enabled = true;
                btnAsiakasPoista.Enabled = true;
                btnAsiakasSiirryVaraus.Enabled = true;
            }
        }
        private void btnAsiakasLisaa_Click(object sender, EventArgs e)
        {
            AsiakasNakyma an = new AsiakasNakyma(this);
            an.ShowDialog();
        }
        private void btnAsiakasMuokkaa_Click(object sender, EventArgs e)
        {
            Asiakas a = new Asiakas();
            a = (Asiakas)dgvAsiakas.CurrentRow.DataBoundItem;
            AsiakasNakyma an = new AsiakasNakyma(a, this);
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
                UpdateGridAsiakas();                
            }
            else
                return;
        }
        private void btnAsiakasSiirryVaraus_Click(object sender, EventArgs e)
        {
            tcHotelli.SelectedTab = tpVaraus;                                   
        }
        private void rbtnAsiakasKaikki_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAsiakasKaikki.Checked)
            {
                UpdateGridAsiakas();                                
            }
        }
        private void cmbAsiakasToimialue_SelectedIndexChanged(object sender, EventArgs e)
        {
            asiakashakuToimipaikalla();
        }
        private void rbtnAsiakasToimi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAsiakasToimi.Checked)
            {
                asiakashakuToimipaikalla();                
                cmbAsiakasToimialue.Enabled = true;
            }
            else
                cmbAsiakasToimialue.Enabled = false;
        }
        private void asiakashakuToimipaikalla()
        {
            asiakkaatSuodatinT.Clear();
                        
            asiakkaat = LFDB.getAsiakas();
            Toimialue asiakasSuodToimi = (Toimialue)cmbAsiakasToimialue.SelectedItem;

            foreach (Asiakas a in asiakkaat)
            {
                varauksetAsiakasSuodatus.Clear();
                varauksetAsiakasSuodatus = LFDB.getVarausAsiakkaan(a.AsiakasID);
                foreach (Varaustiedot v in varauksetAsiakasSuodatus)
                {
                    if (v.ToimintaalueNimi.ToString() == asiakasSuodToimi.ToimintaAlueNimi.ToString() && !asiakkaatSuodatinT.Contains(a))                        
                        asiakkaatSuodatinT.Add(a);
                }
            }
            dgvAsiakas.DataSource = null;
            if (asiakkaatSuodatinT.Count() > 0)
                dgvAsiakas.DataSource = asiakkaatSuodatinT;
            asiakasCountCheck(asiakkaatSuodatinT);

            // Vaihdetaan combon datasource
            cbVaraukset.DataSource = asiakkaatSuodatinT;
            cbVaraukset.DisplayMember = "AsiakasID";
            cbVaraukset.ValueMember = "AsiakasID";
        }
        private void rbtnAsiakasHakuNimi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAsiakasHakuNimi.Checked)
            {
                tbAsiakasHakuNimi.Enabled = true;
                asiakashakuSukunimella();                
            }
            else
                tbAsiakasHakuNimi.Enabled = false;
        }
        private void tbAsiakasHakuNimi_KeyUp(object sender, KeyEventArgs e)
        {
            asiakashakuSukunimella();
        }
        private void asiakashakuSukunimella()
        {
            asiakkaatSuodatinS.Clear();
            asiakkaatSuodatinSB.Clear();
            asiakkaatSuodatinS = LFDB.getAsiakasBySukunimi(tbAsiakasHakuNimi.Text);
            asiakkaatSuodatinSB = convertToBindingAsiakas(asiakkaatSuodatinS);

            dgvAsiakas.DataSource = null;
            dgvAsiakas.DataSource = asiakkaatSuodatinSB;
            asiakasCountCheck(asiakkaatSuodatinS);

            // Vaihdetaanko combon datasource
            cbVaraukset.DataSource = asiakkaatSuodatinSB;
            cbVaraukset.DisplayMember = "AsiakasID";
            cbVaraukset.ValueMember = "AsiakasID";
        }
        private BindingList<Asiakas> convertToBindingAsiakas(List<Asiakas> listToConvert)
        {
            BindingList<Asiakas> listToMake = new BindingList<Asiakas>();
            foreach (Asiakas a in listToConvert)
            {
                listToMake.Add(a);
            }
            return listToMake;
        }

        /* Laskun toiminnot*/
        private void button9_Click(object sender, EventArgs e)
        {
            Lasku la = (Lasku)dgvLaskut.CurrentRow.DataBoundItem;

            LaskuRaportti.Reportteri();
            MessageBox.Show("Tiedosto Tallennettiin tulostettavaksi", "Laskutus", MessageBoxButtons.OK);
        }

        private void button10_Click(object sender, EventArgs e)
        {

            Lasku la = (Lasku)dgvLaskut.CurrentRow.DataBoundItem;

            LaskuRaportti.Reportteri();
            MessageBox.Show("Tiedosto Tallennettiin sähköpostiin lähetettäväksi", "Laskutus", MessageBoxButtons.OK);
        }
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

        private void MuokkaaLAsku_Click(object sender, EventArgs e)
        {
            Lasku oo = new Lasku();
            oo = (Lasku)dgvLaskut.CurrentRow.DataBoundItem;
            LaskuNakyma uu = new LaskuNakyma(oo, this);
            uu.ShowDialog();
            dgvLaskut.DataSource = null;
            dgvLaskut.DataSource = Laskut;
        }

        private void LisaaLasku_Click(object sender, EventArgs e)
        {
            LaskuNakyma uu = new LaskuNakyma(this);
            uu.ShowDialog();
            dgvLaskut.DataSource = null;
            dgvLaskut.DataSource = Laskut;
        }

        public void UpdateGridLaskut()
        {

            dgvLaskut.Refresh();
            Laskut = LFDB.getLasku();
            dgvLaskut.DataSource = null;
            dgvLaskut.DataSource = Laskut;


        }

        /* Varausten toiminnot*/
        private void btnUusiVaraus_Click(object sender, EventArgs e)
        {
            VarausNakyma LisaaVaraus = new VarausNakyma(Varaukset.Count, this);
            LisaaVaraus.Text = "Lisaa Varaus";
            LisaaVaraus.Show();
        }
        private void cbVaraukset_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgvVaraus.DataSource = null;
            
            if (cbVaraukset.SelectedItem != null) 
            { 
            Asiakas A = (Asiakas)cbVaraukset.SelectedItem;
            VarauksienTiedot = LFDB.getVarausAsiakkaan(A.AsiakasID);
            dgvVaraus.DataSource = VarauksienTiedot;
            }


        }
        private void btnMuokkaaVarausta_Click(object sender, EventArgs e)
        {
            Varaustiedot VarausM = (Varaustiedot)dgvVaraus.CurrentRow.DataBoundItem;
            VarausNakyma MuokkaaVarausta = new VarausNakyma(VarausM, this);
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
        public void UpdateVarausGrid(int asiakasID)
        {

            dgvVaraus.DataSource = null;
            Asiakas A = (Asiakas)cbVaraukset.SelectedItem;
            VarauksienTiedot = LFDB.getVarausAsiakkaan(asiakasID);
            dgvVaraus.DataSource = VarauksienTiedot;

            cbVaraukset.DataSource = null;
            cbVaraukset.Items.Clear();
            asiakkaat.Clear();
            asiakkaat = LFDB.getAsiakas();
            cbVaraukset.DataSource = asiakkaat;
            cbVaraukset.DisplayMember = "AsiakasID";
            cbVaraukset.ValueMember = "AsiakasID";
        }
        private void btnVarausHae_Click(object sender, EventArgs e)
        {
            int i = asiakkaat.FindIndex(item => item.AsiakasID == int.Parse(tbVarausHaku.Text));
            if (i > 0)
            {
                
                cbVaraukset.SelectedValue = int.Parse(tbVarausHaku.Text);
            }
        }
        private void tbVarausHaku_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        /* Palvelun toiminnot*/
        private void lisääp_btn(object sender, EventArgs e)
        {
            PalveluNakyma lisaaPalvelu = new PalveluNakyma(this);
            lisaaPalvelu.Text = "Lisaa uusi palvelu";
            lisaaPalvelu.Show();
        }
        public void UpdatePalveluGrid()
        {
            

            dgv_palvelut.Refresh();
            palvelut.Clear();
            palvelut = LFDB.getPalvelut();
            dgv_palvelut.DataSource = null;
            dgv_palvelut.DataSource = palvelut;


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
            PalveluNakyma muokkaaPalvelua = new PalveluNakyma(muokkaaPalvelu, this);
            muokkaaPalvelua.Text = "Muokkaa palvelua";
            muokkaaPalvelua.Show();
            
        }
        private void btnPalveluRaportti_Click(object sender, EventArgs e)
        {
            Palvelu p = (Palvelu)cbRpalvelu.SelectedItem;
            DateTime a = dtpPRalku.Value;
            DateTime l = dtpPRloppu.Value;
            PalveluRaportti.ServiceRaporting(p.PalveluID, a, l);
            MessageBox.Show("Tiedosto Tallennettiin", "Raportointi", MessageBoxButtons.OK);
        }
    }
}
