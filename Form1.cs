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
        public HotelManhattan()
        {
            InitializeComponent();



        }

        private void HotelManhattan_Load(object sender, EventArgs e)
        {
            mokit = LFDB.getMokit();
            toimialueet = LFDB.GetToimialue();
            int j = 0;
            tcHotelli.SelectedTab = tpToimialue;
            for (int i = 0; i < toimialueet.Count; i++)
            {
                mokki m = new mokki();
                if (i % 4 == 0 &&  i != 0)
                j++;
                Toimialue t = new Toimialue();
                Button nappi = t.LuoNapit(toimialueet, i,j);
                tpToimialue.Controls.Add(nappi);
                nappi.Click += new EventHandler(ToimialueValinta);
                
            }
        }
            private void ToimialueValinta(object sender, EventArgs e)
            {
            dgvMokit.DataSource = null;
            int number = int.Parse((sender as Button).Tag.ToString());
            List<mokki> ToimialueenMokit = new List<mokki>();
            ToimialueenMokit = LFDB.getMokitToiauleittain(number);
            dgvMokit.DataSource = ToimialueenMokit;
            tcHotelli.SelectedTab = tpMokki;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        /*
                   ***********************
                   Ylijäämä ja testikoodit         
                   ***********************

 private void ToimialueValinta(object sender, EventArgs e)

 string s = (sender as Button).Text;
 ManhattanProject.toimintaalueDataTable ToimialueenHaku = new ManhattanProject.toimintaalueDataTable();
 ManhattanProject.mokkiDataTable MokkiHakuToimiAlueittain = new ManhattanProject.mokkiDataTable();
 toimintaalueTableAdapter.ToimiAlue(ToimialueenHaku,number);
 mokkiTableAdapter1.ToimiAlue(MokkiHakuToimiAlueittain, number);
 dgv11.DataSource = ToimialueenHaku;
 dgvMokit.DataSource = MokkiHakuToimiAlueittain;


private void HotelManhattan_Load(object sender, EventArgs e)

TODO: This line of code loads data into the 'manhattanProject.toimintaalue' table. You can move, or remove it, as needed.
this.toimintaalueTableAdapter.Fill(this.manhattanProject.toimintaalue);
int x = 8 , y = 3;
ManhattanProject.toimintaalueDataTable ToimialueenHaku = new ManhattanProject.toimintaalueDataTable();
for (int i = 1; i < manhattanProject.toimintaalue.Count+1; i++)
{
toimintaalueTableAdapter.ToimiAlue(ToimialueenHaku,i);
string Toimialue = "1";// ToimialueenHaku[i].nimi.ToString();
Button ToimiAlueNappi= new Button(); 
ToimiAlueNappi.Location = new System.Drawing.Point(x, y);
ToimiAlueNappi.Name = "ToimiAlue"+i;
ToimiAlueNappi.Size = new System.Drawing.Size(206,190);
ToimiAlueNappi.TabIndex = i;
ToimiAlueNappi.Text = Toimialue;
ToimiAlueNappi.UseVisualStyleBackColor = true;
ToimiAlueNappi.Tag = i;
tpToimialue.Controls.Add(ToimiAlueNappi);
ToimiAlueNappi.Click += new EventHandler(ToimialueValinta);
}

*/

    }
}
