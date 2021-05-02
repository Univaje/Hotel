using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    internal class mokki
    {
        private int mokkiID;
        private int toimintaalueID;
        private string postinumero;
        private string mokkinimi;
        private string katuosoite;
        private string kuvaus;
        private int henkilomaara;
        private string varustelu;
        private double hinta;

        public mokki()
        {
        }

        public mokki(int mokkiID, int toimintaalueID, string postinumero, string mokkinimi, string katuosoite, string kuvaus, int henkilomaara, string varustelu, double hinta)
        {
            MokkiID = mokkiID;
            ToimintaalueID = toimintaalueID;
            Postinumero = postinumero;
            Mokkinimi = mokkinimi;
            Katuosoite = katuosoite;
            Kuvaus = kuvaus;
            Henkilomaara = henkilomaara;
            Varustelu = varustelu;
            Hinta = hinta;
        }

        public int MokkiID { get => mokkiID; set => mokkiID = value; }
        public int ToimintaalueID { get => toimintaalueID; set => toimintaalueID = value; }
        public string Postinumero { get => postinumero; set => postinumero = value; }
        public string Mokkinimi { get => mokkinimi; set => mokkinimi = value; }
        public string Katuosoite { get => katuosoite; set => katuosoite = value; }
        public string Kuvaus { get => kuvaus; set => kuvaus = value; }
        public int Henkilomaara { get => henkilomaara; set => henkilomaara = value; }
        public string Varustelu { get => varustelu; set => varustelu = value; }
        public double Hinta { get => hinta; set => hinta = value; }

    }
}
