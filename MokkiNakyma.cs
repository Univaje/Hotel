using Hotel.Oliot;
using Hotel;
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
    public partial class MokkiNakyma : Form
    {
        private List<Posti> Lista = new List<Posti>();
        private Posti p = new Posti();
        private mokki m = new mokki();
        private int Mokkiid;
        private int Toimiid;
        private HotelManhattan Form1;

        // Formi luonti kun uusi mökki lisätään. Annteaan formille teksit lisää tallennus tarkistusta varten
        public MokkiNakyma(int count, HotelManhattan Formi1)
        {
            InitializeComponent();
            Lista = p.HaetPostinrot();
            Toimiid = count;
            tbMhlomaara.Text = "1";
            btnTallennaMokki.Text = "Lisää";
            this.Form1 = Formi1;

        }
        // Formi luonti kun mökkiä muutetaan. Mökin tiedot lisätään teksti kenttiin. Annetaan formille teksi muokkaa tallennus tarkistusta varten
        internal MokkiNakyma(mokki Uusimokki, HotelManhattan Formi1)
        {
            InitializeComponent();
            btnTallennaMokki.Text = "Muokkaa";
            tbMnimi.Text = Uusimokki.Mokkinimi;
            tbMosoite.Text = Uusimokki.Katuosoite;
            tbMposti.Text = Uusimokki.Postinumero;
            tbMkuvaus.Text = Uusimokki.Kuvaus;
            tbMvarustelu.Text = Uusimokki.Varustelu;
            tbMhlomaara.Text = Uusimokki.Henkilomaara.ToString();
            tbMHinta.Text = Uusimokki.Hinta.ToString();
            Lista = p.HaetPostinrot();

            Mokkiid = Uusimokki.MokkiID;
            Toimiid = Uusimokki.ToimintaalueID;
            Form1 = Formi1;
        }

        public void TallennaMokki_Click(object sender, EventArgs e)
        {

            // Tarkistetaan että validoitavat kentät täyttävät validoinnin määritelmät
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    // Varmistetaan löytyykö postinumero tietokannasta. Postinumeron uupuessa se lisätään tietokantaan 
                    int i = Lista.FindIndex(item => item.Postinro == tbMposti.Text);
                    if (i < 0)
                    {
                        p.Postinro = tbMposti.Text;
                        p.Toimipaikka = tbToimipaikka.Text;
                        LFDB.setPostinro(p);
                    }
                   // Luodaan mökki olio ja syötetään se tietokantaan. tähän olisi voinut tehdä tarkistuksen onko mökki jo olemssa kyseisellä toimialueella.
                    m = new mokki(Mokkiid, Toimiid, tbMposti.Text, tbMnimi.Text, tbMosoite.Text, tbMkuvaus.Text, int.Parse(tbMhlomaara.Text), tbMvarustelu.Text, double.Parse(tbMHinta.Text));
                    //Tarkistetaan formin nimestä onko kyseessä lisäys vai muokkaus ja toimitaan sen mukaisesti
                    if (btnTallennaMokki.Text.Equals("Lisää"))
                        LFDB.SetMokki(m);
                    else
                        LFDB.UpdateMokki(m);

                    // Suljetaan formi ja päivitetään mökkitaulukko pääformilta
                    this.Close();
                    Form1.UpdateMokkiGrid();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnPeruutaLisaus_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        // Postinumero kenttään hyväksytään vain numerot, poistonappi sekä suurin sallittu pituus on 5 merkkiä
        private void tbMposti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
            else if (tbMposti.TextLength >= 5 && e.KeyChar != '\b')
                e.Handled = true;
        }

        // Hinta kenttän oikein syöttö tarkistus. Hyväksytään vain yksi "," merkki sekä vain numerot.
        // Pilkun jälkeen on mahdollista syöttää vain 2 numeroa.
        private void tbMHinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string luku = tbMHinta.Text;

            if (tbMHinta.Text.Contains(','))
            {
                luku = luku.Substring(0, luku.IndexOf(","));
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                    e.Handled = true;
                else if (tbMHinta.TextLength >= luku.Length + 3 && e.KeyChar != '\b')
                    e.Handled = true;
            }
            else if (e.KeyChar != ',' && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }
        // numeron annettua ohjelma tarkistaa tietokannasta haetuista postinumeroista mahdollista jo olemassa olevaa
        // postitoimipaikkaa kyseiselle postinumerolle. tarkistus tehdään jokaisen numeron jälkeen uudelleen
        private void tbMposti_KeyUp(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {


                if (Lista != null && tbMposti.TextLength == i)
                {
                    string vertaa = tbMposti.Text;
                    foreach (Posti p in Lista)
                    {

                        if (vertaa == p.Postinro.Substring(0, i))
                        {
                            tbToimipaikka.Text = p.Toimipaikka;
                        }

                    }
                }
            }
        }

        // Henkilömäärä kenttään hyväksytään vain numerot.
        private void tbMhlomaara_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;

        }

        // Henkilömäärä kentän maksimi luku on 12 henkilöä
        private void tbMhlomaara_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbMhlomaara.Text != "")
            {
                int maara = int.Parse(tbMhlomaara.Text);
                if (maara > 12)
                    tbMhlomaara.Text = "12";
            }
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
        private void ValidoituKentta(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            epVirhe.SetError(tb, "");
        }
    }
}
