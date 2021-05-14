﻿using System;
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
        private HotelManhattan Form1;
        private Posti p = new Posti();

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
            //dtpVarausAlkaa.MinDate = v.Varattu_alkupvm;
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
            this.Hide();
        }
        private void ctpVarausAlkaa_ValueChanged(object sender, EventArgs e)
        {
            dtpVarausLoppuu.MinDate = dtpVarausAlkaa.Value;
        }
        private void btnvTallenna_Click(object sender, EventArgs e)
        {
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

        /*
        private  void Saving()
        {

            Toimialue t = (Toimialue)cbVtoimialue.SelectedItem;
            Asiakas a = (Asiakas)cbVAsiakas.SelectedItem;
            mokki m = (mokki)cbVMokki.SelectedItem;
            DateTime alku = dtpVarausAlkaa.Value;
            DateTime Loppu = dtpVarausLoppuu.Value;

            if (cbUusiAsiakasVarauksessa.Checked)
            {
                a = asiakkaanlisausVarauksenYhteydessa(a);
            }

            int varausaika = (int)Loppu.Subtract(alku).TotalDays;
            varausaika++;
            int ID = 0;
            DateTime Vahvistus = alku.AddDays(-14);
            Varaus uusiVaraus = new Varaus(1, a.AsiakasID, m.MokkiID, varausaika, Vahvistus, alku, Loppu);

            if (btnvTallenna.Text.Equals("Lisää varaus"))
            {
                LFDB.SetVaraus(uusiVaraus);
                ID = LFDB.GetLastVarausID();
                VarausIDsi = ID;
                TallennaPalvelutVarauseen(ID);
            }
            else
            {
                uusiVaraus.VarausID = VarausIDsi;
                LFDB.SetMuokattuVaraus(uusiVaraus);
                PaivitaPalvelutVarauseen();
            }

            this.Hide();

            Form1.UpdateVarausGrid(uusiVaraus.AsiakasID1);
            
        }
       
        */

        private void Saving()
        {

            Toimialue t = (Toimialue)cbVtoimialue.SelectedItem;
            Asiakas a = (Asiakas)cbVAsiakas.SelectedItem;
            mokki m = (mokki)cbVMokki.SelectedItem;
            DateTime alku = dtpVarausAlkaa.Value;
            DateTime Loppu = dtpVarausLoppuu.Value;

            if (cbUusiAsiakasVarauksessa.Checked)
            {
                a = asiakkaanlisausVarauksenYhteydessa(a);
            }

            int varausaika = (int)Loppu.Subtract(alku).TotalDays;
            varausaika++;
            int ID = 0;
            DateTime Vahvistus = alku.AddDays(-14);
            Varaus uusiVaraus = new Varaus(1, a.AsiakasID, m.MokkiID, varausaika, Vahvistus, alku, Loppu);
            Varaus Onjo = new Varaus();
            Onjo = LFDB.selectVaraus(m.MokkiID, alku, Loppu);

            if (Onjo == null || uusiVaraus.VarattuAlku < Onjo.VarattuAlku && uusiVaraus.VarattuAlku > Onjo.VarattuLoppu && uusiVaraus.VarattuLoppu < Onjo.VarattuAlku && uusiVaraus.VarattuLoppu > Onjo.VarattuLoppu)
            {


                if (btnvTallenna.Text.Equals("Lisää varaus"))
                {
                    LFDB.SetVaraus(uusiVaraus);
                    ID = LFDB.GetLastVarausID();
                    VarausIDsi = ID;
                    TallennaPalvelutVarauseen(ID);
                }
                else
                {
                    uusiVaraus.VarausID = VarausIDsi;
                    LFDB.SetMuokattuVaraus(uusiVaraus);
                    PaivitaPalvelutVarauseen();
                }

                this.Hide();

                Form1.UpdateVarausGrid(uusiVaraus.AsiakasID1);
            }
            else MessageBox.Show("Varaus on jo tälle ajalle olemassa!", "Varaus virhe!", MessageBoxButtons.OK);
        }
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

                if (btnvTallenna.Text.Equals("Muokkaa Varausta"))
                {
                    LFDB.RemoveVarauksenPalvelut((PalvelutVaraukseen)lbPalvelut.SelectedItem);
                }
                PalveluidenlisVar.Remove((PalvelutVaraukseen)lbPalvelut.SelectedItem);


                Refressing();
            }
            private void Refressing()
            {
                PalvelutVaraukseen p = new PalvelutVaraukseen();
                lbPalvelut.DataSource = null;
                lbPalvelut.Items.Clear();
                lbPalvelut.DataSource = PalveluidenlisVar;
                lbPalvelut.DisplayMember = "nimi";
                lbPalvelut.ValueMember = "nimi";

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

        private void tbvPostinumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
            else if (tbvPostinumero.TextLength >= 5 && e.KeyChar != '\b')
                e.Handled = true;
        }

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
    }
    }
