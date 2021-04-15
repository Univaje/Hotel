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
            // TODO: This line of code loads data into the 'manhattanProject.toimintaalue' table. You can move, or remove it, as needed.
            this.toimintaalueTableAdapter.Fill(this.manhattanProject.toimintaalue);
            int x = 8 , y = 3;
            tcHotelli.SelectedTab = tpToimialue;
            for (int i = 1; i < this.manhattanProject.toimintaalue.Count+1; i++)
            {

                Button ToimiAlueNappi= new Button(); 
                ToimiAlueNappi.Location = new System.Drawing.Point(x, y);
                ToimiAlueNappi.Name = "ToimiAlue"+i;
                ToimiAlueNappi.Size = new System.Drawing.Size(206,190);
                ToimiAlueNappi.TabIndex = i;
                ToimiAlueNappi.Text = this.manhattanProject.toimintaalue.nimiColumn.ToString();
                ToimiAlueNappi.UseVisualStyleBackColor = true;
                ToimiAlueNappi.Tag = i;

                this.Controls.Add(ToimiAlueNappi);
               
                ToimiAlueNappi.Click += new EventHandler(ToimialueValinta);
                x = + 212;
                if (x >= 645)
                    y = +206;
            }
        }

        private void ToimialueValinta(object sender, EventArgs e)
        {
            //string s = (sender as Button).Text;
            int number = int.Parse((sender as Button).Tag.ToString());
            ManhattanProject.toimintaalueDataTable ToimialueenHaku = new ManhattanProject.toimintaalueDataTable();
            ManhattanProject.mokkiDataTable MokkiHakuToimiAlueittain = new ManhattanProject.mokkiDataTable();
            toimintaalueTableAdapter.ToimiAlue(ToimialueenHaku,number);
            mokkiTableAdapter1.ToimiAlue(MokkiHakuToimiAlueittain, number);
            dgv11.DataSource = ToimialueenHaku;
            dgvMokit.DataSource = MokkiHakuToimiAlueittain;
            tcHotelli.SelectedTab = tpMokki;


        }

    }
}
