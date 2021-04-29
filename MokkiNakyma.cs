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
    public partial class MokkiNakyma : Form
    {
        private List<Posti> Lista = new List<Posti>();
        private Posti p = new Posti();
        private mokki m = new mokki();
        private int index;
        private int Mokkiid;
        private int Toimiid;
        private int Count;
        public MokkiNakyma(int count)
        {
            InitializeComponent();
            Lista = p.HaetPostinrot();
            index = 2;
            Mokkiid = count+1;
        }
        internal MokkiNakyma(mokki Uusimokki, int mokkiid, int toimiid)
        {
            InitializeComponent();

            tbMnimi.Text = Uusimokki.Mokkinimi;
            tbMosoite.Text = Uusimokki.Katuosoite;
            tbMposti.Text = Uusimokki.Postinumero;
            tbMkuvaus.Text = Uusimokki.Kuvaus;
            tbMvarustelu.Text = Uusimokki.Varustelu;
            cbMhlmaara.SelectedIndex = Uusimokki.Henkilomaara-1;
            tbMHinta.Text = Uusimokki.Hinta.ToString();
            Lista = p.HaetPostinrot();
            
            index = 1;
            Mokkiid = mokkiid;
            Toimiid = toimiid;
            

        }
        private void TallennaMokki_Click(object sender, EventArgs e)
        {
           
            int i = Lista.FindIndex(item => p.Postinro == tbMposti.Text);
            if (i <= 0)
            {
                p.Postinro = tbMposti.Text;
                p.Toimipaikka = tbToimipaikka.Text;
                p.ViePostinumerot(p);
            }
                m = new mokki(Toimiid, Mokkiid, tbMposti.Text, tbMnimi.Text, tbMosoite.Text, tbMkuvaus.Text, int.Parse(cbMhlmaara.Text), tbMvarustelu.Text, double.Parse(tbMHinta.Text));
            m.lisaaMokki(m);
            MokkiNakyma.ActiveForm.Close();

        }
        private void btnPeruutaLisaus_Click(object sender, EventArgs e)
        {
            MokkiNakyma.ActiveForm.Close();

        }
        private void tbMposti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && tbMposti.TextLength > 5)
                e.Handled = true;
        }
        private void tbMHinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbMHinta.Text.Contains(','))
                if ( !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                    e.Handled = true;
            else if(e.KeyChar != ',' &&  !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void tbMposti_KeyUp(object sender, KeyEventArgs e)
       {

            for (int i = 0; i < 5; i++)
            {


                if (Lista != null && tbMposti.TextLength == i)
                {
                    string vertaa = tbMposti.Text;
                    foreach (Posti postinumero in Lista)
                    {

                        if (vertaa == postinumero.Postinro.Substring(0, i))
                        {
                            tbToimipaikka.Text = postinumero.Toimipaikka;
                        }

                    }
                }
            }
        }
    }
}
