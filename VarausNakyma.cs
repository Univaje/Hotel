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
        private HotelManhattan Form1;
        private Posti p = new Posti();

        // Formin luonti kun lisätään uusi asiakas
        public VarausNakyma(int count, HotelManhattan from1)
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
            this.Form1 = from1;
            getInfoVar();

        }
        // Formi luonti kun varaus tietoja muokataan
        internal VarausNakyma(Varaustiedot v, HotelManhattan from1)
        {

            InitializeComponent();
            Palvelut = LFDB.getPalvelut();
            Toimialueet = LFDB.GetToimialue();
            asiakkaat = LFDB.getAsiakas();

            VarausIDsi = v.Varaus_id;
            cbVtoimialue.DataSource = Toimialueet;
            cbVtoimialue.DisplayMember = "toimintaAlueNimi";
            cbVtoimialue.ValueMember = "toimintaAlueID";
            cbVtoimialue.SelectedValue = v.Toimintaalue_id;

            cbVAsiakas.DataSource = asiakkaat;
            cbVAsiakas.DisplayMember = "asiakasID";
            cbVAsiakas.ValueMember = "asiakasID";
            cbVAsiakas.SelectedValue = v.Asiakas_ID;

            VarausIDsi = v.Varaus_id;
            dtpVarausAlkaa.Value = v.Varattu_alkupvm;
            dtpVarausLoppuu.Value = v.Varattu_loppupvm;
            tbvHenkilomaara.Text = "1";

            getInfoVar();
            cbVMokki.SelectedValue = v.Mokkinimi;
            PalveluidenlisVar = LFDB.GetVarauksenPalvelut(v.Varaus_id);
            Refressing();
            btnvTallenna.Text = "Muokkaa Varausta";
            this.Form1 = from1;

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
            cbVtoimialue.ValueMember = "toimintaAlueID";
            cbVAsiakas.DataSource = asiakkaat;
            cbVAsiakas.DisplayMember = "asiakas_ID";
            cbVMokki.DataSource = null;


        }
        private void UusiAsiakasVarauksessa_CheckedChanged(object sender, EventArgs e)
        {
            // tuodaan esille uuden asiakkaan kentät
            if (gbUuVaAs.Visible)
                gbUuVaAs.Visible = false;
            else
                gbUuVaAs.Visible = true;
        }
        private void cbVtoimialue_SelectedIndexChanged(object sender, EventArgs e)
        {
            getInfoVar();
            Refressing();
        }
        private void btvCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ctpVarausAlkaa_ValueChanged(object sender, EventArgs e)
        {
            // määritetään loppu päivämäärä niin ettei se voi olla ennen alku päivämäärää
            dtpVarausLoppuu.MinDate = dtpVarausAlkaa.Value;
        }
        private void btnvTallenna_Click(object sender, EventArgs e)
        {
            // Validointi kenttien toiminnot toimivat vain jos uusi asiakas kenttä on valittuna
            if (cbUusiAsiakasVarauksessa.Checked)
            {
                try
                {

                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                        int i = Lista.FindIndex(item => item.Postinro == tbvPostinumero.Text);
                        if (i < 0)
                        {
                            p.Postinro = tbvPostinumero.Text;
                            p.Toimipaikka = tbvToimipaikka.Text;
                            LFDB.setPostinro(p);
                        }
                        Saving();

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
                Saving();
        }

        // Varauksen tekoa varten tehty metodi joka tallentaa tiedot kentistä.
        private void Saving()
        {

            Toimialue t = (Toimialue)cbVtoimialue.SelectedItem;
            Asiakas a = (Asiakas)cbVAsiakas.SelectedItem;
            mokki m = (mokki)cbVMokki.SelectedItem;
            DateTime alku = dtpVarausAlkaa.Value;
            DateTime Loppu = dtpVarausLoppuu.Value;

            // Tarkistetaan lisätäänkö uusi asiakas tietokantaan
            if (cbUusiAsiakasVarauksessa.Checked)
            {
                a = asiakkaanlisausVarauksenYhteydessa(a);
            }
            // Lasketaan varausaika päivänä laskua varten
            int varausaika = (int)Loppu.Subtract(alku).TotalDays;
            varausaika++;
            int ID = 0;
            // määritetään viimeinen vahvistus päivämäärä jolloin varausta ei voi perua enää.
            DateTime Vahvistus = alku.AddDays(-14);
            // luodaan varaus olio sekä mahdollinen jo olemassa oleva varaus
            Varaus uusiVaraus = new Varaus(1, a.AsiakasID, m.MokkiID, varausaika, Vahvistus, alku, Loppu);
            Varaus Onjo = new Varaus();
            Onjo = LFDB.selectVaraus(m.MokkiID, alku, Loppu);
            // Tarkistetaan onko kyseisellä ajalla jo valmiiksi varaus ja annetaan virhe ilmoitus jos on
            if (Onjo == null || uusiVaraus.VarattuAlku < Onjo.VarattuAlku && uusiVaraus.VarattuAlku > Onjo.VarattuLoppu && uusiVaraus.VarattuLoppu < Onjo.VarattuAlku && uusiVaraus.VarattuLoppu > Onjo.VarattuLoppu)
            {

                // Jos varaus on uusi 
                if (btnvTallenna.Text.Equals("Lisää varaus"))
                {
                    LFDB.SetVaraus(uusiVaraus);
                    ID = LFDB.GetLastVarausID();
                    uusiVaraus.VarausID = ID;
                    VarausIDsi = ID;
                    TallennaPalvelutVarauseen(ID);
                }
                // jos varausta muokataan
                else
                {
                    uusiVaraus.VarausID = VarausIDsi;
                    LFDB.SetMuokattuVaraus(uusiVaraus);
                    PaivitaPalvelutVarauseen();
                }
                GenerateLasku(uusiVaraus);
                this.Close();
                // päivitetään pääformin gridi
                Form1.UpdateVarausGrid(uusiVaraus.AsiakasID1);
            }
            else MessageBox.Show("Varaus on jo tälle ajalle olemassa!", "Varaus virhe!", MessageBoxButtons.OK);
        }


        // Metodi asiakkaan lisäämiseen varauksen yhteydessä.
        private Asiakas asiakkaanlisausVarauksenYhteydessa(Asiakas a)
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
            a.AsiakasID = LFDB.GetLastAsiakasID();
            return a;
        }

        // Palveluiden lisäämienn uudelle varaukselle
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

        // Palveluiden päivittäminen varauksen muokkauksen yhteydessä
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
        // Lisätään varaukseen palvelu. Tässä on huomioitu että muokkauksen yhteydessä palvelu lisätään suoraan tietokantaan
        // Helpottaakseen tallennus napin toimintaa
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

        // palveluiden poisto varauksesta. Tässä on huomioitu että muokkauksen yhteydessä palvelu poistetaan
        // varauksesta suoraan helpottaakseen tallennus napin toimintaa.
        private void btnvPoistaPalvelu_Click(object sender, EventArgs e)
        {

            if (btnvTallenna.Text.Equals("Muokkaa Varausta"))
            {
                LFDB.RemoveVarauksenPalvelut((PalvelutVaraukseen)lbPalvelut.SelectedItem);
            }
            PalveluidenlisVar.Remove((PalvelutVaraukseen)lbPalvelut.SelectedItem);


            Refressing();
        }

        // palveluiden päivittämis metodi listboxille
        private void Refressing()
        {
            PalvelutVaraukseen p = new PalvelutVaraukseen();
            lbPalvelut.DataSource = null;
            lbPalvelut.Items.Clear();
            lbPalvelut.DataSource = PalveluidenlisVar;
            lbPalvelut.DisplayMember = "nimi";
            lbPalvelut.ValueMember = "nimi";

        }

        // Henkilömäärä kenttä hyväksyy vain numeroita
        private void tbHenkilomaara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        // Haetaan tiedot tietokannasta ja syötetään ne combo boxeihin
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

        // Täytettävien kenttien validointi. Validoinnissa huomioidaan ettei kenttä ole tyhjä.
        private void Validoikentta(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                this.epVirhe.SetError(tb, "Pakollinen kenttä!");
                e.Cancel = true;
            }
        }
        private void Validoitukentta(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            epVirhe.SetError(tb, "");
        }
        // Postinumero kenttään hyväksytään vain numerot, poistonappi sekä suurin sallittu pituus on 5 merkkiä
        private void tbvPostinumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
            else if (tbvPostinumero.TextLength >= 5 && e.KeyChar != '\b')
                e.Handled = true;
        }

        // numeron annettua ohjelma tarkistaa tietokannasta haetuista postinumeroista mahdollista jo olemassa olevaa
        // postitoimipaikkaa kyseiselle postinumerolle. tarkistus tehdään jokaisen numeron jälkeen uudelleen
        private void tbvPostinumero_KeyUp(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {


                if (Lista != null && tbvPostinumero.TextLength == i)
                {
                    string vertaa = tbvPostinumero.Text;
                    foreach (Posti p in Lista)
                    {

                        if (vertaa == p.Postinro.Substring(0, i))
                        {
                            tbvToimipaikka.Text = p.Toimipaikka;
                        }

                    }
                }
            }
        }



        /*TUOTETTU KATSELMOINNIN JÄLKEEN*/
        private void GenerateLasku(Varaus v)
        {
            // Laskun tuottaminen varauksessa
            double Summa = 0;
            double alv = 0;
            int maksettu = 0;
            mokki m = (mokki)cbVMokki.SelectedItem; 
            

            foreach (PalvelutVaraukseen palvelu in PalveluidenlisVar)
            {
                double hinta = LFDB.getPalveluHinta(palvelu.PalveluID);
                Summa += (palvelu.Lkm * hinta)* v.VarattuPvm;

            }
            Summa += v.VarattuPvm * m.Hinta;
            alv = (Summa*0.24);
            Lasku Lasku = new Lasku(0, v.VarausID, Summa, alv, maksettu);
            
            if (btnvTallenna.Text.Equals("Lisää varaus"))
            {
                LFDB.TeeLasku(Lasku);
            }
            else
            {
                int LID = LFDB.getLaskuIDVaraukseen(v.VarausID);
                Lasku.LaskuID = LID;
                LFDB.UpdateLasku(Lasku);
            }
        }


    }
}
