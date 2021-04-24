using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    class mokki
    {
        private int mokkiID;
        private int ToimintaalueID;
        private string postinumero;
        private string mokkinimi;
        private string Katuosoite;
        private string Kuvaus;
        private int henkilomaara;
        private string Varustelu;
        private double hinta;

        public mokki()
        {
        }

        public mokki(int mokkiID, int toimintaalueID, string postinumero, string mokkinimi, string katuosoite,
            string kuvaus, int henkilomaara, string varustelu, double hinta)
        {
            this.mokkiID = mokkiID;
            ToimintaalueID = toimintaalueID;
            this.postinumero = postinumero;
            this.mokkinimi = mokkinimi;
            Katuosoite = katuosoite;
            Kuvaus = kuvaus;
            this.henkilomaara = henkilomaara;
            Varustelu = varustelu;
            Hinta = hinta;
        }

        public int MokkiID { get => mokkiID; set => mokkiID = value; }
        public int ToimintaalueID1 { get => ToimintaalueID; set => ToimintaalueID = value; }
        public string Postinumero { get => postinumero; set => postinumero = value; }
        public string Mokkinimi { get => mokkinimi; set => mokkinimi = value; }
        public string Katuosoite1 { get => Katuosoite; set => Katuosoite = value; }
        public string Kuvaus1 { get => Kuvaus; set => Kuvaus = value; }
        public int Henkilomaara { get => henkilomaara; set => henkilomaara = value; }
        public string Varustelu1 { get => Varustelu; set => Varustelu = value; }
        public double Hinta { get => hinta; set => hinta = value; }
    
    
   } 
}
