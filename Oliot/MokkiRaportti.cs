using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Oliot
{
    class MokkiRaportti
    {
        private int varaus_id;
        private string mokkinimi;
        private string katuosoite;
        private string postinro;
        private DateTime varattu_alkupvm;
        private DateTime varattu_loppupvm;
        private double hinta;

        public int Varaus_id { get => varaus_id; set => varaus_id = value; }
        public string Mokkinimi { get => mokkinimi; set => mokkinimi = value; }
        public string Katuosoite { get => katuosoite; set => katuosoite = value; }
        public string Postinro { get => postinro; set => postinro = value; }
        public DateTime Varattu_alkupvm { get => varattu_alkupvm; set => varattu_alkupvm = value; }
        public DateTime Varattu_loppupvm { get => varattu_loppupvm; set => varattu_loppupvm = value; }
        public double Hinta { get => hinta; set => hinta = value; }

        public MokkiRaportti()
        {
        }

        public MokkiRaportti(int varaus_id, string mokkinimi, string katuosoite, string postinro, DateTime varattu_alkupvm, DateTime varattu_loppupvm, double hinta)
        {
            Varaus_id = varaus_id;
            Mokkinimi = mokkinimi;
            Katuosoite = katuosoite;
            Postinro = postinro;
            Varattu_alkupvm = varattu_alkupvm;
            Varattu_loppupvm = varattu_loppupvm;
            Hinta = hinta;
        }
        public void Raporting(string n, DateTime a, DateTime l)
        {
            List<MokkiRaportti> Raportti = new List<MokkiRaportti>();
            Raportti = LFDB.getMokkiRaportti(n,a,l);
            //Generate PDF!
        }
    }
}
