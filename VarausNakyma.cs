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
        public VarausNakyma(int count)
        {
            InitializeComponent();

        }

        private void VarausNakyma_Load(object sender, EventArgs e)
        {
            Palvelut = LFDB.getPalvelut();
            ((ListBox)clbPalvelutVarauksessa).DataSource = Palvelut;
            ((ListBox)clbPalvelutVarauksessa).DisplayMember = "nimi";
            ((ListBox)clbPalvelutVarauksessa).ValueMember = "nimi";
        }

        private void UusiAsiakasVarauksessa_CheckedChanged(object sender, EventArgs e)
        {
            if (gbUuVaAs.Visible)
                gbUuVaAs.Visible = false;
            else
                gbUuVaAs.Visible = true;
        }

        
    }
}
