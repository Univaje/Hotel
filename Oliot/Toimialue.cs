using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    class Toimialue
    {
        private int toimintaAlueID;
        private string toimintaAlueNimi;
        private int x = 8;
        private int y = 3;
        public int ToimintaAlueID { get => toimintaAlueID; set => toimintaAlueID = value; }
        public string ToimintaAlueNimi { get => toimintaAlueNimi; set => toimintaAlueNimi = value; }

        public Toimialue()
        {
        }

        public Toimialue(int toimintaAlueID, string toimintaAlueNimi)
        {
            ToimintaAlueID = toimintaAlueID;
            ToimintaAlueNimi = toimintaAlueNimi;
        }

        public Button LuoNapit(List<Toimialue> lista, int i, int j)
        {
            
            if (i >= 1)
            {
                x = x + 212*i;
                if (x >= 212*4)
                {
                    y = y+206*j;
                    x = 8 + 212 * (i - (4*j));
                }
            }
            Button ToimiAlueNappi = new Button();
            ToimiAlueNappi.Location = new System.Drawing.Point(x, y);
            ToimiAlueNappi.Name = "ToimiAlue" + i;
            ToimiAlueNappi.Size = new System.Drawing.Size(206, 190);
            ToimiAlueNappi.TabIndex = i;
            ToimiAlueNappi.Text = lista[i].ToimintaAlueNimi.ToString();
            ToimiAlueNappi.UseVisualStyleBackColor = true;
            ToimiAlueNappi.Tag = i+1;
            
            return ToimiAlueNappi;
        }

        public List<mokki> Toimialueet(int number)
        {
            List<mokki> ToimialueenMokit = new List<mokki>();
            ToimialueenMokit = LFDB.getMokitToiauleittain(number);
            return ToimialueenMokit;
        }

        public void LisaaToimialue(string t)
        {
            LFDB.SetToimialue(t);
        }
        public void MuokkaaToimialue(int i, string t)
        {
            LFDB.UpdateToimialue(i, t);
        }

        public void PoistaToimialue(int i)
        {
            LFDB.RemoveToimialue(i);
        }

    }
}
