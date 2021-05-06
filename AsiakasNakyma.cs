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
    public partial class AsiakasNakyma : Form
    {
        List<Asiakas> asiakkaat = new List<Asiakas>();
        public AsiakasNakyma()
        {
            InitializeComponent();
            asiakkaat = LFDB.getAsiakas();
        }

        private void btnAsiakasMuokPeruuta_Click(object sender, EventArgs e)
        {
            AsiakasNakyma.ActiveForm.Close();
        }

        private void btnAsiakasMuokTallenna_Click(object sender, EventArgs e)
        {
            Asiakas lisattava = new Asiakas();
            lisattava.AsiakasID = asiakkaat.Count + 1;
            lisattava.Etunimi = tbAsiakasMuokENimi.Text;
            lisattava.Sukunimi = tbAsiakasMuokSNimi.Text;
            lisattava.Lahiosoite = tbAsiakasMuokOsoite.Text;
            lisattava.Postinumero = tbAsiakasMuokPosti.Text;
            lisattava.Sahkopostiosoite = tbAsiakasMuokEmail.Text;
            lisattava.Puhelinnumero = tbAsiakasMuokPuh.Text;
            LFDB.SetAsiakasAlt(lisattava);
            //Form1.asiakkaat.Add(lisattava);
            //dgvAsiakas.DataSource = null;
            //dgvAsiakas.DataSource = asiakkaat;
            AsiakasNakyma.ActiveForm.Close();
        }
    }
}
