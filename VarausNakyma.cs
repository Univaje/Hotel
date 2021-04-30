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
        private List<Toimialue> Toimialueet = new List<Toimialue>();
        private List<mokki> mokit = new List<mokki>();
        private List<Asiakas> asiakkaat = new List<Asiakas>();

        public VarausNakyma(int count)
        {
            InitializeComponent();
            Palvelut = LFDB.getPalvelut();
            Toimialueet = LFDB.GetToimialue();
            asiakkaat = LFDB.getAsiakas();
            ((ListBox)clbPalvelutVarauksessa).DataSource = Palvelut;
            ((ListBox)clbPalvelutVarauksessa).DisplayMember = "nimi";
            ((ListBox)clbPalvelutVarauksessa).ValueMember = "nimi";

            cbVtoimialue.DataSource = Toimialueet;
            cbVtoimialue.DisplayMember = "toimintaAlueNimi";
            cbVAsiakas.DataSource = asiakkaat;
            cbVAsiakas.DisplayMember = "asiakasID";
            cbVMokki.DataSource = null;
        }

        private void VarausNakyma_Load(object sender, EventArgs e)
        {
            Palvelut = LFDB.getPalvelut();
            Toimialueet = LFDB.GetToimialue();
            asiakkaat = LFDB.getAsiakas();
            ((ListBox)clbPalvelutVarauksessa).DataSource = Palvelut;
            ((ListBox)clbPalvelutVarauksessa).DisplayMember = "nimi";
            ((ListBox)clbPalvelutVarauksessa).ValueMember = "nimi";

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
            Toimialue t = (Toimialue)cbVtoimialue.SelectedItem;
            mokit = LFDB.getMokitToiauleittain(t.ToimintaAlueID);
            cbVMokki.DataSource = mokit;
            cbVMokki.DisplayMember = "Mokkinimi";
        }

        private void btvCancel_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
