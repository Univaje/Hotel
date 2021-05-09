﻿using Hotel.Oliot;
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
            Toimiid = count;
            tbMhlomaara.Text = "1";
            btnTallennaMokki.Text = "Lisää";
        }
        internal MokkiNakyma(mokki Uusimokki)
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


        }
        private void TallennaMokki_Click(object sender, EventArgs e)
        {

            int i = Lista.FindIndex(item => item.Postinro == tbMposti.Text);
            if (i < 0)
            {
                p.Postinro = tbMposti.Text;
                p.Toimipaikka = tbToimipaikka.Text;
                LFDB.setPostinro(p);
            }
            m = new mokki(Mokkiid, Toimiid, tbMposti.Text, tbMnimi.Text, tbMosoite.Text, tbMkuvaus.Text, int.Parse(tbMhlomaara.Text), tbMvarustelu.Text, double.Parse(tbMHinta.Text));
            if (btnTallennaMokki.Text.Equals("Lisää"))
                LFDB.SetMokki(m);
            else
                LFDB.UpdateMokki(m);
            Form.ActiveForm.Close();

        }
        private void btnPeruutaLisaus_Click(object sender, EventArgs e)
        {
            MokkiNakyma.ActiveForm.Close();

        }
        private void tbMposti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
            else if (tbMposti.TextLength >= 5 && e.KeyChar != '\b')
                e.Handled = true;
        }
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
        private void tbMhlomaara_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;

        }
        private void tbMhlomaara_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbMhlomaara.Text != "")
            {
                int maara = int.Parse(tbMhlomaara.Text);
                if (maara > 12)
                    tbMhlomaara.Text = "12";
            }
        }
    }
}
