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
        private int Mokkiid;
        private int Toimiid;
        public MokkiNakyma(int count)
        {
            InitializeComponent();
            Lista = p.HaetPostinrot();
            Mokkiid = count + 1;
            tbMhlomaara.Text = "1";
        }
        internal MokkiNakyma(mokki Uusimokki, int mokkiid, int toimiid)
        {
            InitializeComponent();

            tbMnimi.Text = Uusimokki.Mokkinimi;
            tbMosoite.Text = Uusimokki.Katuosoite;
            tbMposti.Text = Uusimokki.Postinumero;
            tbMkuvaus.Text = Uusimokki.Kuvaus;
            tbMvarustelu.Text = Uusimokki.Varustelu;
            tbMhlomaara.Text = Uusimokki.Henkilomaara.ToString();
            tbMHinta.Text = Uusimokki.Hinta.ToString();
            Lista = p.HaetPostinrot();

            Mokkiid = mokkiid;
            Toimiid = toimiid;


        }
        private void TallennaMokki_Click(object sender, EventArgs e)
        {

            int i = Lista.FindIndex(item => item.Postinro == tbMposti.Text);
            if (i < 0)
            {
                p.Postinro = tbMposti.Text;
                p.Toimipaikka = tbToimipaikka.Text;
                p.ViePostinumerot(p);
            }
            m = new mokki(Toimiid, Mokkiid, tbMposti.Text, tbMnimi.Text, tbMosoite.Text, tbMkuvaus.Text, int.Parse(tbMhlomaara.Text), tbMvarustelu.Text, double.Parse(tbMHinta.Text));
            LFDB.SetMokki(m);
            MokkiNakyma.ActiveForm.Close();

        }
        private void btnPeruutaLisaus_Click(object sender, EventArgs e)
        {
            MokkiNakyma.ActiveForm.Close();

        }
        private void tbMposti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && tbMposti.TextLength < 5)
                e.Handled = true;
            else if (tbMposti.TextLength >= 5)
                e.Handled = true;
        }
        private void tbMHinta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbMHinta.Text.Contains(','))
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                    e.Handled = true;
                else if (e.KeyChar != ',' && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                    e.Handled = true;
        }
        private void tbMposti_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void tbMhlomaara_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;

        }
        private void tbMhlomaara_KeyUp(object sender, KeyEventArgs e)
        {
            int maara = int.Parse(tbMhlomaara.Text);
            if (maara > 12)
                tbMhlomaara.Text = "12";
        }
    }
}
