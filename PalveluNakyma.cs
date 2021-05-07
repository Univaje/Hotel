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
    public partial class PalveluNakyma : Form
    {
        private List<Palvelu> Palvelut = new List<Palvelu>();
        
        public PalveluNakyma()
        {
            InitializeComponent();
            Palvelut = LFDB.getPalvelut();
            

            
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
