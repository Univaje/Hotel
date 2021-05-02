using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Oliot
{
    class Varaustiedot
    {
        private string toimintaalueNimi;
        private int toimintaalue_id;
        private int varaus_id;
        private int asiakas_ID;
        private string mokkinimi;
        private string etunimi;
        private string sukunimi;
        private DateTime varattu_alkupvm;
        private DateTime varattu_loppupvm;
        private double hinta;

        public int Varaus_id { get => varaus_id; set => varaus_id = value; }
        public string Mokkinimi { get => mokkinimi; set => mokkinimi = value; }
        public string Etunimi { get => etunimi; set => etunimi = value; }
        public string Sukunimi { get => sukunimi; set => sukunimi = value; }
        public DateTime Varattu_alkupvm { get => varattu_alkupvm; set => varattu_alkupvm = value; }
        public DateTime Varattu_loppupvm { get => varattu_loppupvm; set => varattu_loppupvm = value; }
        public double Hinta { get => hinta; set => hinta = value; }
        public int Toimintaalue_id { get => toimintaalue_id; set => toimintaalue_id = value; }
        public string ToimintaalueNimi { get => toimintaalueNimi; set => toimintaalueNimi = value; }
        public int Asiakas_ID { get => asiakas_ID; set => asiakas_ID = value; }

        public Varaustiedot()
        {
        }

        public Varaustiedot(int toimintaalueID, string toimintaalueNimi, int asiakas_ID, int varaus_id, string mokkinimi, string etunimi, string sukunimi, DateTime varattu_alkupvm, DateTime varattu_loppupvm, double hinta)
        {
            Toimintaalue_id = toimintaalueID;
            ToimintaalueNimi = toimintaalueNimi;
            Varaus_id = varaus_id;
            Asiakas_ID = asiakas_ID;
            Mokkinimi = mokkinimi;
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Varattu_alkupvm = varattu_alkupvm;
            Varattu_loppupvm = varattu_loppupvm;
            Hinta = hinta;
        }
    }
}
