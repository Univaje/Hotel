using System;
using Hotel.Oliot;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// MAIN
namespace Hotel
{
    public partial class VarausNakyma : Form
    {
        private List<Palvelu> Palvelut = new List<Palvelu>();
        private List<PalvelutVaraukseen> PalveluidenlisVar = new List<PalvelutVaraukseen>();
        private List<Toimialue> Toimialueet = new List<Toimialue>();
        private List<mokki> mokit = new List<mokki>();
        private List<Asiakas> asiakkaat = new List<Asiakas>();
        private List<Posti> Lista = new List<Posti>();
        private int VarausIDsi = 0;

        public VarausNakyma(int count)
        {

            InitializeComponent();
            Palvelut = LFDB.getPalvelut();
            Toimialueet = LFDB.GetToimialue();
            asiakkaat = LFDB.getAsiakas();

            cbVtoimialue.DataSource = Toimialueet;
            cbVtoimialue.DisplayMember = "toimintaAlueNimi";
            cbVtoimialue.ValueMember = "toimintaAlueID";
            cbvPalvelunlisäys.DataSource = null;
            cbVAsiakas.DataSource = asiakkaat;
            cbVAsiakas.DisplayMember = "asiakasID";
            cbVMokki.DataSource = null;

            dtpVarausAlkaa.MinDate = DateTime.Now;
            dtpVarausLoppuu.MinDate = DateTime.Now;
            tbvHenkilomaara.Text = "1";
            btnvTallenna.Text = "Lisää varaus";

        }
        internal VarausNakyma(Varaustiedot v)
        {
            InitializeComponent();
            Palvelut = LFDB.getPalvelut();
            Toimialueet = LFDB.GetToimialue();
            asiakkaat = LFDB.getAsiakas();

            cbVtoimialue.DataSource = Toimialueet;
            cbVtoimialue.DisplayMember = "toimintaAlueNimi";
            cbVtoimialue.ValueMember = "toimintaAlueID";
            cbVtoimialue.SelectedValue = v.Toimintaalue_id;

            cbVAsiakas.DataSource = asiakkaat;
            cbVAsiakas.DisplayMember = "asiakasID";
            cbVAsiakas.ValueMember = "asiakasID";
            cbVAsiakas.SelectedValue = v.Asiakas_ID;

            VarausIDsi = v.Varaus_id;
            dtpVarausAlkaa.MinDate = v.Varattu_alkupvm;
            dtpVarausAlkaa.Value = v.Varattu_alkupvm;
            dtpVarausLoppuu.MinDate = v.Varattu_loppupvm;
            dtpVarausLoppuu.Value = v.Varattu_loppupvm;
            tbvHenkilomaara.Text = "1";

            getInfoVar();
            cbVMokki.SelectedValue = v.Mokkinimi;
            PalveluidenlisVar = LFDB.GetVarauksenPalvelut(v.Varaus_id);
            ((ListBox)clbPalvelutVarauksessa).DataSource = null;
            clbPalvelutVarauksessa.Items.Clear();
            Refressing();
            btnvTallenna.Text = "Muokkaa Varausta";

        }
        private void VarausNakyma_Load(object sender, EventArgs e)
        {
            Palvelut = LFDB.getPalvelut();
            Toimialueet = LFDB.GetToimialue();
            asiakkaat = LFDB.getAsiakas();

            cbvPalvelunlisäys.DataSource = Palvelut;
            cbvPalvelunlisäys.DisplayMember = "";
            cbvPalvelunlisäys.ValueMember = "";
            cbVtoimialue.DataSource = Toimialueet;
            cbVtoimialue.DisplayMember = "toimintaAlueID";
            cbVAsiakas.DataSource = asiakkaat;
            cbVAsiakas.DisplayMember = "asiakas_ID";
            cbVMokki.DataSource = null;


        }
        private void UusiAsiakasVarauksessa_CheckedChanged(object sender, EventArgs e)
        {
            if (gbUuVaAs.Visible)
                gbUuVaAs.Visible = false;
            else
                gbUuVaAs.Visible = true;
        }
        private void cbVtoimialue_SelectedIndexChanged(object sender, EventArgs e)
        {
            getInfoVar();
            ((ListBox)clbPalvelutVarauksessa).DataSource = null;
            clbPalvelutVarauksessa.Items.Clear();
            Refressing();
        }
        private void btvCancel_Click(object sender, EventArgs e)
        {
            //miten palataan!!!
        }
        private void ctpVarausAlkaa_ValueChanged(object sender, EventArgs e)
        {
            dtpVarausLoppuu.MinDate = dtpVarausAlkaa.Value;
        }
        private void btnvTallenna_Click(object sender, EventArgs e)
        {

            Toimialue t = (Toimialue)cbVtoimialue.SelectedItem;
            Asiakas a = (Asiakas)cbVAsiakas.SelectedItem;
            mokki m = (mokki)cbVMokki.SelectedItem;
            DateTime alku = dtpVarausAlkaa.Value;
            DateTime Loppu = dtpVarausLoppuu.Value;

            if (cbUusiAsiakasVarauksessa.Checked)
            {
                asiakkaanlisausVarauksenYhteydessa(a);
            }

            int varausaika = (int)Loppu.Subtract(alku).TotalDays;
            varausaika++;
            DateTime Vahvistus = alku.AddDays(-14);
            Varaus uusiVaraus = new Varaus(1, a.AsiakasID, m.MokkiID, varausaika, Vahvistus, alku, Loppu);

            if (btnvTallenna.Text.Equals("Lisää varaus"))
            {
                LFDB.SetVaraus(uusiVaraus);
                int ID = LFDB.GetLastVarausID();
                TallennaPalvelutVarauseen(ID);
            }
            else
            {
                LFDB.SetMuokattuVaraus(uusiVaraus);
                PaivitaPalvelutVarauseen();
            }
        }
        private void asiakkaanlisausVarauksenYhteydessa(Asiakas a)
        {
            a = new Asiakas();
            a.AsiakasID = 0;
            a.Etunimi = tbvEtunimi.Text;
            a.Sukunimi = tbvSukunimi.Text;
            a.Lahiosoite = tbvOsoite.Text;
            a.Postinumero = tbvPostinumero.Text;

            Posti p = new Posti();
            Lista = p.HaetPostinrot();
            int i = Lista.FindIndex(item => p.Postinro == tbvPostinumero.Text);
            if (i <= 0)
            {
                p.Postinro = tbvPostinumero.Text;
                p.Toimipaikka = tbvToimipaikka.Text;
                LFDB.setPostinro(p);
            }

            a.Sahkopostiosoite = tbvSposti.Text;
            a.Puhelinnumero = tbvPuhnum.Text;
            LFDB.SetAsiakasAlt(a);
        }
        private void TallennaPalvelutVarauseen(int ID)
        {
            if (PalveluidenlisVar.Count >= 0)
            {
                foreach (PalvelutVaraukseen item in PalveluidenlisVar)
                {
                    item.VarausID = ID;
                    LFDB.SetVarauksenPalvelut(item);
                }
            }
            tbvHenkilomaara.Text = "1";
        }
        private void PaivitaPalvelutVarauseen()
        {
            if (PalveluidenlisVar.Count >= 0)
            {
                foreach (PalvelutVaraukseen item in PalveluidenlisVar)
                {
                    LFDB.UpdateVarauksenPalvelut(item);
                }
            }
            tbvHenkilomaara.Text = "1";
        }
        private void btnvPalvelunLisaus_Click(object sender, EventArgs e)
        {
            Palvelu p = (Palvelu)cbvPalvelunlisäys.SelectedItem;
            PalvelutVaraukseen pv = new PalvelutVaraukseen(VarausIDsi, p.PalveluID, int.Parse(tbvHenkilomaara.Text), p.Nimi);
            int i = PalveluidenlisVar.FindIndex(item => item.PalveluID == pv.PalveluID);
            if (i < 0)
            {
                if (btnvTallenna.Text.Equals("Muokkaa Varausta"))
                {
                    LFDB.SetVarauksenPalvelut(pv);
                }
                PalveluidenlisVar.Add(pv);
                Refressing();
            }
        }
        private void btnvPoistaPalvelu_Click(object sender, EventArgs e)
        {
            // MIKSI SEKOAA KUN VIIMEISEN POISTAA
            foreach (PalvelutVaraukseen item in clbPalvelutVarauksessa.CheckedItems)
            {
                if (btnvTallenna.Text.Equals("Muokkaa Varausta"))
                {
                    LFDB.RemoveVarauksenPalvelut(item);
                }
                PalveluidenlisVar.Remove(item);
            }
            ((ListBox)clbPalvelutVarauksessa).DataSource = null;
            clbPalvelutVarauksessa.Items.Clear();
            Refressing();
        }
        private void Refressing()
        {
            PalvelutVaraukseen p = new PalvelutVaraukseen();
            ((ListBox)clbPalvelutVarauksessa).DataSource = null;
            clbPalvelutVarauksessa.Items.Clear();
            ((ListBox)clbPalvelutVarauksessa).DataSource = PalveluidenlisVar;
            ((ListBox)clbPalvelutVarauksessa).DisplayMember = "nimi";
            ((ListBox)clbPalvelutVarauksessa).ValueMember = "nimi";
        }
        private void tbHenkilomaara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }
        private void getInfoVar()
        {
            PalveluidenlisVar.Clear();
            tbvHenkilomaara.Text = "1";
            Toimialue t = (Toimialue)cbVtoimialue.SelectedItem;


            mokit = LFDB.getMokitToiauleittain(t.ToimintaAlueID);
            cbVMokki.DataSource = null;
            cbVMokki.Items.Clear();
            cbVMokki.DataSource = mokit;
            cbVMokki.DisplayMember = "Mokkinimi";
            cbVMokki.ValueMember = "Mokkinimi";


            Palvelut = LFDB.getPalvelutToimiAlueella(t.ToimintaAlueID);
            cbvPalvelunlisäys.DataSource = null;
            cbvPalvelunlisäys.Items.Clear();
            cbvPalvelunlisäys.DataSource = Palvelut;
            cbvPalvelunlisäys.DisplayMember = "nimi";
            cbvPalvelunlisäys.ValueMember = "palveluID";
        }

    }
}
