using ceTe.DynamicPDF;
using ceTe.DynamicPDF.PageElements;
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
        private int varattuPvm;
        private DateTime varattu_alkupvm;
        private DateTime varattu_loppupvm;
        private double hinta;

        public int Varaus_id { get => varaus_id; set => varaus_id = value; }
        public string Mokkinimi { get => mokkinimi; set => mokkinimi = value; }
        public string Katuosoite { get => katuosoite; set => katuosoite = value; }
        public string Postinro { get => postinro; set => postinro = value; }

        public int VarattuPvm { get => varattuPvm; set => varattuPvm = value; }

        public DateTime Varattu_alkupvm { get => varattu_alkupvm; set => varattu_alkupvm = value; }
        public DateTime Varattu_loppupvm { get => varattu_loppupvm; set => varattu_loppupvm = value; }
        public double Hinta { get => hinta; set => hinta = value; }

        public MokkiRaportti()
        {
        }

        public MokkiRaportti(int varaus_id, string mokkinimi, string katuosoite, string postinro, int varattuPvm, DateTime varattu_alkupvm, DateTime varattu_loppupvm, double hinta)
        {

            Varaus_id = varaus_id;
            Mokkinimi = mokkinimi;
            Katuosoite = katuosoite;
            Postinro = postinro;
            VarattuPvm = varattuPvm;
            Varattu_alkupvm = varattu_alkupvm;
            Varattu_loppupvm = varattu_loppupvm;
            Hinta = hinta;
        }
        // Mökki Raportin luonti ceTe.DynamicPDF.coresuit nugettia käyttäen
        internal static void Raporting(int n, DateTime a, DateTime l)
        {
            List<MokkiRaportti> Raportti = new List<MokkiRaportti>();
            Raportti = LFDB.getMokkiRaportti(n, a, l);
            if (Raportti.Count > 0)
            {
                MokkiRaportti Info = Raportti.ElementAt(0);
                int floaty = 0;
                Document MRaport = new Document();
                Page Sivu = new Page(PageSize.A4, PageOrientation.Portrait, 54.0f);
                MRaport.Pages.Add(Sivu);
                Label Otsikko = new Label("Mökki Raportti", 0, floaty, 504, 100, Font.Helvetica, 18, TextAlign.Center);
                Sivu.Elements.Add(Otsikko);
                floaty += 20;
                Label Mokintieodot = new Label("Mökki: " + Info.Mokkinimi + ", " + Info.katuosoite + " \nTuottoraportti aikavälille " + a + " - " + l + " \nMökin päivähinta: " + Info.hinta + "€", 0, floaty, 504, 100, Font.Helvetica, 16, TextAlign.Center);
                Sivu.Elements.Add(Mokintieodot);
                floaty += 60;
                double loppusumma = 0;
                foreach (MokkiRaportti mr in Raportti)
                {
                    floaty += 20;
                    double summa = mr.VarattuPvm * mr.Hinta;
                    loppusumma += summa;


                    Label Rivi = new Label("Varaus aika: " + mr.varattu_alkupvm + " - " + mr.varattu_loppupvm + " Tuotto: " + summa + "€, alv% " + (summa * 0.24) + "€", 0, floaty, 504, 100, Font.Helvetica, 12, TextAlign.Left);
                    Sivu.Elements.Add(Rivi);
                }
                floaty += 50;
                Label Loppurivi = new Label("Varaus-ajan " + a + " - " + l + " Kokonaistuotto: " + loppusumma + "€, alv% " + (loppusumma * 0.24) + "€", 0, floaty, 504, 100, Font.Helvetica, 12, TextAlign.Left);
                Sivu.Elements.Add(Loppurivi);
                MRaport.Draw(@"C:\\CabinRaports\\Raport1-" + n + "-" + a + "-" + l + ".pdf");
                
            }
        }
    }
}
