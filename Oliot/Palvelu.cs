using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Oliot
{
    class Palvelu
    {
        private int palveluID;
        private int ToimintaalueID;
        private string nimi;
        private int tyyppi;
        private string kuvaus;
        private double hinta;
        private double alv;

        public int PalveluID { get => palveluID; set => palveluID = value; }
        public int ToimintaalueID1 { get => ToimintaalueID; set => ToimintaalueID = value; }
        public string Nimi { get => nimi; set => nimi = value; }
        public int Tyyppi { get => tyyppi; set => tyyppi = value; }
        public string Kuvaus { get => kuvaus; set => kuvaus = value; }
        public double Hinta { get => hinta; set => hinta = value; }
        public double Alv { get => alv; set => alv = value; }

        public Palvelu()
        {
        }

        public Palvelu(int palveluID, int toimintaalueID1, string nimi, int tyyppi, string kuvaus, double hinta, double alv)
        {
            PalveluID = palveluID;
            ToimintaalueID1 = toimintaalueID1;
            Nimi = nimi;
            Tyyppi = tyyppi;
            Kuvaus = kuvaus;
            Hinta = hinta;
            Alv = alv;
        }
    }
}
