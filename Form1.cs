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
        public HotelManhattan()
        {
            InitializeComponent();
        }

        private void HotelManhattan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.mokki' table. You can move, or remove it, as needed.
            this.mokkiTableAdapter.Fill(this.dataSet1.mokki);

        }

        private void ToimialueValinta(object sender, EventArgs e)
        {

        }
    }
}
