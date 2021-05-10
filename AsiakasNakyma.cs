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
        public AsiakasNakyma()
        {
            InitializeComponent();
            muokkaus = false;
            Lista = p.HaetPostinrot();
            // asiakkaat = LFDB.getAsiakas();
            btnAsiakasMuokTallenna.Text = "Lisää";
            aID = 1;
        }

        internal AsiakasNakyma(Asiakas muokattava)
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


        }

        private void btnAsiakasMuokPeruuta_Click(object sender, EventArgs e)
        {
            AsiakasNakyma.ActiveForm.Close();
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
            
            //dgvAsiakas.DataSource = null;
            //dgvAsiakas.DataSource = asiakkaat;
            AsiakasNakyma.ActiveForm.Close();
        }
    }
}
