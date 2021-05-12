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
    public partial class LaskuNakyma : Form
    {
        
        
        
        private HotelManhattan Form1;
        public LaskuNakyma(HotelManhattan tullutformiL)
        {
            InitializeComponent();
            TallennaLasku.Text = "Lisää";

            this.Form1 = tullutformiL;
        }
        public LaskuNakyma()
        {
            InitializeComponent();
        }
        internal LaskuNakyma(Lasku muokattava, HotelManhattan tullutformiL)
        {
            InitializeComponent();
            TallennaLasku.Text = "Muokkaa";



            LaskuIdtxt.Text = muokattava.LaskuID.ToString();
            Varausid1tx.Text = muokattava.VarausID1.ToString();
            Summatxt.Text = muokattava.Summa.ToString();
            ALVtxt.Text = muokattava.Alv.ToString();
            
           
            this.Form1 = tullutformiL;

        }
        private void TallennaLasku_Click(object sender, EventArgs e)
        {
            Lasku lisutettu = new Lasku();
            
            lisutettu.LaskuID = int.Parse(LaskuIdtxt.Text);
            lisutettu.VarausID1 = int.Parse(Varausid1tx.Text);
            lisutettu.Summa = double.Parse(Summatxt.Text);
            lisutettu.Alv = double.Parse(ALVtxt.Text);


            if (TallennaLasku.Text == "Lisää")
            {
                LFDB.UusiLasku(lisutettu);
            }

            else
            {
                LFDB.UpdateLasku(lisutettu);
            }

            this.Hide();
            Form1.UpdateGridLaskut();
        }

        private void PeruutaLasku_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
