using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel.Oliot;

namespace Hotel
{
    public partial class AsiakasNakyma : Form
    {
        // List<Asiakas> asiakkaat = new List<Asiakas>();
        private List<Posti> Lista = new List<Posti>();
        private Posti p = new Posti();
        private bool muokkaus = false;
        private int aID;
        private HotelManhattan Form1;
        public AsiakasNakyma(HotelManhattan tullutformi)
        {
            InitializeComponent();
            muokkaus = false;
            Lista = p.HaetPostinrot();
            // asiakkaat = LFDB.getAsiakas();
            btnAsiakasMuokTallenna.Text = "Lisää";
            aID = 1;
            this.Form1 = tullutformi;
        }

        internal AsiakasNakyma(Asiakas muokattava, HotelManhattan tullutformi)
        {
            InitializeComponent();
            muokkaus = true;
            btnAsiakasMuokTallenna.Text = "Muokkaa";
            aID = muokattava.AsiakasID;
            tbAsiakasMuokENimi.Text = muokattava.Etunimi;
            tbAsiakasMuokSNimi.Text = muokattava.Sukunimi;
            tbAsiakasMuokOsoite.Text = muokattava.Lahiosoite;
            tbAsiakasMuokPosti.Text = muokattava.Postinumero;
            tbAsiakasMuokEmail.Text = muokattava.Sahkopostiosoite;
            tbAsiakasMuokPuh.Text = muokattava.Puhelinnumero;
            Lista = p.HaetPostinrot();
            ToimipaikanHaku(muokattava.Postinumero.ToString());
            this.Form1 = tullutformi;

        }

        private void btnAsiakasMuokPeruuta_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAsiakasMuokTallenna_Click(object sender, EventArgs e)
        {
            Asiakas lisattava = new Asiakas();
            lisattava.AsiakasID = aID;
            lisattava.Etunimi = tbAsiakasMuokENimi.Text;
            lisattava.Sukunimi = tbAsiakasMuokSNimi.Text;
            lisattava.Lahiosoite = tbAsiakasMuokOsoite.Text;
            lisattava.Postinumero = tbAsiakasMuokPosti.Text;
            lisattava.Sahkopostiosoite = tbAsiakasMuokEmail.Text;
            lisattava.Puhelinnumero = tbAsiakasMuokPuh.Text;

            int i = Lista.FindIndex(item => item.Postinro == tbAsiakasMuokPosti.Text);
            if (i < 0)
            {
                p.Postinro = tbAsiakasMuokPosti.Text;
                p.Toimipaikka = tbAsiakasMuokToimipaikka.Text;
                LFDB.setPostinro(p);
            }

            if (!muokkaus)
                LFDB.SetAsiakasAlt(lisattava);
            else
                LFDB.UpdateAsiakas(lisattava);

            this.Hide();
            Form1.UpdateGridAsiakas();
        }

        private void tbAsiakasMuokPosti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
            else if (tbAsiakasMuokPosti.TextLength >= 5 && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void tbAsiakasMuokPosti_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbAsiakasMuokPosti.TextLength > 0)
                ToimipaikanHaku();
            else
                tbAsiakasMuokToimipaikka.Text = "";
        }

        private void ToimipaikanHaku()
        {
            for (int i = 0; i < 5; i++)
            {


                if (Lista != null && tbAsiakasMuokPosti.TextLength == i)
                {
                    string vertaa = tbAsiakasMuokPosti.Text;
                    foreach (Posti p in Lista)
                    {

                        if (vertaa == p.Postinro.Substring(0, i))
                        {
                            tbAsiakasMuokToimipaikka.Text = p.Toimipaikka;
                        }

                    }
                }
            }
        }
        private void ToimipaikanHaku(string vertaa)
        {
            foreach (Posti p in Lista)
            {          
            if (vertaa == p.Postinro.Substring(0, 5))
            {
                tbAsiakasMuokToimipaikka.Text = p.Toimipaikka;
            }
            }
        }
    }
}
