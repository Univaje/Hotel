using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Oliot
{
    class Varaustiedot
    {
        private int varaus_id;
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

        public Varaustiedot()
        {
        }

        public Varaustiedot(int varaus_id, string mokkinimi, string etunimi, string sukunimi, DateTime varattu_alkupvm, DateTime varattu_loppupvm, double hinta)
        {
            Varaus_id = varaus_id;
            Mokkinimi = mokkinimi;
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Varattu_alkupvm = varattu_alkupvm;
            Varattu_loppupvm = varattu_loppupvm;
            Hinta = hinta;
        }
    }
}
