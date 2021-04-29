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
    public partial class HotelManhattan : Form
    {
        private List<mokki> mokit = new List<mokki>();
        private List<Toimialue> toimialueet = new List<Toimialue>();
        private List<Asiakas> asiakkaat = new List<Asiakas>();
        private List<mokki> ToimialueenMokit = new List<mokki>();
        private Toimialue t;
        private mokki m = new mokki();
       

        public HotelManhattan()
        {
            InitializeComponent();
        }

        private void HotelManhattan_Load(object sender, EventArgs e)
        {
            // Toimialueet ja mökit
            mokit = LFDB.getMokit();
            toimialueet = LFDB.GetToimialue();
            tcHotelli.SelectedTab = tpToimialue;
            luoNappi();
            cbPoistaToimi.DataSource = toimialueet;
            cbPoistaToimi.ValueMember = "toimintaAlueNimi";
            cbPoistaToimi.Text = "Valitse...";
            tbToimialueMuokkaa.Visible = false;

            // Asiakashallinta
            asiakkaat = LFDB.getAsiakas();
            dgvAsiakas.DataSource = asiakkaat;

        }

        /* Toimialueen toiminnot*/
        public void luoNappi()
        {
            gbToimialueet.Controls.Clear();
            this.Refresh();
            int x = 8;
            int y = 15;
            int j = 0;
            for (int i = 0; i < toimialueet.Count; i++)
            {
                mokki m = new mokki();
                if (i % 4 == 0 && i != 0)
                    j++;
                if (i >= 1)
                {
                    x = x + 212;
                    if (x >= 212 * 4)
                    {
                        y = y + 206;
                        x = 8 + 212 * (i - (4 * j));
                    }
                }
                Button ToimiAlueNappi = new Button();
                ToimiAlueNappi.Location = new System.Drawing.Point(x, y);
                ToimiAlueNappi.Name = "ToimiAlue" + i;
                ToimiAlueNappi.Size = new System.Drawing.Size(206, 190);
                ToimiAlueNappi.TabIndex = i;
                ToimiAlueNappi.Text = toimialueet[i].ToimintaAlueNimi.ToString();
                ToimiAlueNappi.UseVisualStyleBackColor = true;
                ToimiAlueNappi.Tag = toimialueet[i].ToimintaAlueID;
                t = new Toimialue();
                gbToimialueet.Controls.Add(ToimiAlueNappi);
                ToimiAlueNappi.Click += new EventHandler(ToimialueValinta);

            }
        }
        private void ToimialueValinta(object sender, EventArgs e)
        {
            dgvMokit.DataSource = null;
            int number = int.Parse((sender as Button).Tag.ToString());
            ToimialueenMokit = new List<mokki>();
            ToimialueenMokit = t.Toimialueet(number);
            dgvMokit.DataSource = ToimialueenMokit;
            tcHotelli.SelectedTab = tpMokki;
            cbMRM.DataSource = ToimialueenMokit;
            cbMRM.ValueMember = "mokkinimi";


        }
        private void cbPoistaToimi_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnToimialueMuokkaa.Enabled = true;
            btnToimialuePoista.Enabled = true;
            tbToimialueMuokkaa.Visible = true;
            tbToimialueMuokkaa.Text = cbPoistaToimi.Text;
        }
        private void btnLisaaToimialue_Click(object sender, EventArgs e)
        {
            int index = toimialueet.Count() + 1;
            string uusiToimialue = tbLisaaToimi.Text;
            t.LisaaToimialue(index, uusiToimialue);
            tbLisaaToimi.Text = "";
            gbToimialueet.Controls.Clear();
            toimialueet.Clear();
            toimialueet = LFDB.GetToimialue();
            luoNappi();

        }
        private void btnToimialueMuokkaa_Click(object sender, EventArgs e)
        {
            int index = cbPoistaToimi.SelectedIndex + 1;
            string muokattuToimialue = tbToimialueMuokkaa.Text;
            t.MuokkaaToimialue(index, muokattuToimialue);
            tbToimialueMuokkaa.Text = "";
            gbToimialueet.Controls.Clear();
            toimialueet.Clear();
            toimialueet = LFDB.GetToimialue();
            cbPoistaToimi.DataSource = null;
            cbPoistaToimi.DataSource = toimialueet;
            cbPoistaToimi.ValueMember = "toimintaAlueNimi";
            cbPoistaToimi.Refresh();
            luoNappi();
        }
        private void btnToimialuePoista_Click(object sender, EventArgs e)
        {
            int index = cbPoistaToimi.SelectedIndex + 1;
            t.PoistaToimialue(index);
            tbToimialueMuokkaa.Text = "";
            gbToimialueet.Controls.Clear();
            toimialueet.Clear();
            toimialueet = LFDB.GetToimialue();
            luoNappi();

        }

        /* Mokkien toiminnot*/
        private void btnMokkiLisaa_Click(object sender, EventArgs e)
        {
            MokkiNakyma LisaaMokki = new MokkiNakyma(ToimialueenMokit.Count);
            LisaaMokki.Text = "Lisaa mokki";
            LisaaMokki.Show();
        }
        private void btnMokkiMuokkaa_Click(object sender, EventArgs e)
        {
            mokki m = new mokki();
            m = (mokki)dgvMokit.CurrentRow.DataBoundItem;
            MokkiNakyma LisaaMokki = new MokkiNakyma(m,m.MokkiID, m.ToimintaalueID);

            LisaaMokki.Text = "Muokkaa mokkia";
            LisaaMokki.ShowDialog();
        }
        private void btnMokkiPoista_Click(object sender, EventArgs e)
        {
            mokki poista = new mokki();
            poista = (mokki)dgvMokit.CurrentRow.DataBoundItem;
            int mokinpoisto = poista.MokkiID;
            
            ToimialueenMokit.Remove(poista);  
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }

        /* Asiakkaan toiminnot*/


        /* Palvelun toiminnot*/


        /* Laskun toiminnot*/


        /* Varausten toiminnot*/


    }
}
