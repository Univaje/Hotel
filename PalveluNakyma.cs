using Hotel.Oliot;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hotel
{
    public partial class PalveluNakyma : Form

    {
        private HotelManhattan Form1;
        private List<Palvelu> Palvelut = new List<Palvelu>();
        private List<Toimialue> Toimialueet = new List<Toimialue>();
        private int PalveluID;
       // private int ToimialueID;
        private Palvelu pali = new Palvelu();
       


        
        public PalveluNakyma(int count)
        {
            InitializeComponent();
            Palvelut = LFDB.getPalvelut();
            Toimialueet = LFDB.GetToimialue();
            PalveluID = count;
            //Palvelut = pali.

            
            
           
        }

        internal PalveluNakyma(Palvelu uusiPalvelu)
        {
            InitializeComponent();
           //  p.Text = uusiPalvelu;
           
            pkuvaus_tb.Text = uusiPalvelu.Kuvaus;
            
           // phinta_tb.Text = uusiPalvelu.Hinta.ToString;
            //  ptyyppi_tb.Text = uusiPalvelu.Tyyppi;
           //palv_tb.Text = uusiPalvelu.Alv;

            PalveluID = uusiPalvelu.PalveluID;

            uusiPalvelu.Nimi = ppalvelu_tb.Text;
            uusiPalvelu.Kuvaus = pkuvaus_tb.Text;
            // uusiPalvelu.Hinta = phinta_tb.Text.ToString;
           // uusiPalvelu.Tyyppi = ptyyppi_tb.Text;

        }

        

        private void lisää_btn_Click(object sender, EventArgs e)
        {
          
            pali = new Palvelu(PalveluID, int.Parse(ptoimialue_tb.Text), ppalvelu_tb.Text, int.Parse(ptyyppi_tb.Text),
            pkuvaus_tb.Text, double.Parse(phinta_tb.Text), double.Parse(palv_tb.Text));
            if (lisää_btn.Text.Equals("Lisää"))
                LFDB.setPalvelu(pali);
            else
                LFDB.UpdatePalvelu(pali);

          
            PalveluNakyma.ActiveForm.Close();
            Form1.UpdatePalveluGrid();
        }

        private void peruuta_btn_Click(object sender, EventArgs e)
        {
            PalveluNakyma.ActiveForm.Close();

        }

        

        //ylimääräsiä
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void phinta_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
