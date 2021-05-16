using ceTe.DynamicPDF;
using ceTe.DynamicPDF.PageElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class PalveluRaportti
    {
        private int palveluID;
        private string nimi;
        private double hinta;
        private double alv;
        private int lukumaara;
        private DateTime varauspvm;
        private DateTime varausAlku;
        private DateTime varausLoppu;

        public int PalveluID { get => palveluID; set => palveluID = value; }
        public string Nimi { get => nimi; set => nimi = value; }
        public double Hinta { get => hinta; set => hinta = value; }
        public double Alv { get => alv; set => alv = value; }
        public int Lukumaara { get => lukumaara; set => lukumaara = value; }
        public DateTime Varauspvm { get => varauspvm; set => varauspvm = value; }
        public DateTime VarausAlku { get => varausAlku; set => varausAlku = value; }
        public DateTime VarausLoppu { get => varausLoppu; set => varausLoppu = value; }

        public PalveluRaportti(int palveluID, string nimi, double hinta, double alv, int lukumaara, DateTime varauspvm, DateTime varausAlku, DateTime varausLoppu)
        {
            PalveluID = palveluID;
            Nimi = nimi;
            Hinta = hinta;
            Alv = alv;
            Lukumaara = lukumaara;
            Varauspvm = varauspvm;
            VarausAlku = varausAlku;
            VarausLoppu = varausLoppu;
        }

        public PalveluRaportti()
        {
        }
        // Palvelu Raportin luonti ceTe.DynamicPDF.coresuit nugettia käyttäen
        internal static void ServiceRaporting(int n, DateTime a, DateTime l)
        {
            List<PalveluRaportti> Raportti = new List<PalveluRaportti>();
            Raportti = LFDB.getPalveluRaportti(n, a, l);
            if (Raportti.Count > 0)
            {
                PalveluRaportti Info = Raportti.ElementAt(0);
                int floaty = 0;
                Document MRaport = new Document();
                Page Sivu = new Page(PageSize.A4, PageOrientation.Portrait, 54.0f);
                MRaport.Pages.Add(Sivu);
                Label Otsikko = new Label("Palvelu Raportti", 0, floaty, 504, 100, Font.Helvetica, 18, TextAlign.Center);
                Sivu.Elements.Add(Otsikko);
                floaty += 20;
                Label PalveluTiedot = new Label("Palvelu: " + Info.Nimi + ", \nTuottoraportti aikavälille " + a + " - " + l + " \n Palvelun hinta: " + Info.hinta + "€", 0, floaty, 504, 100, Font.Helvetica, 16, TextAlign.Center);
                Sivu.Elements.Add(PalveluTiedot);
                floaty += 60;
                double loppusumma = 0;
                foreach (PalveluRaportti pr in Raportti)
                {
                    floaty += 20;
                    double summa = pr.Hinta * pr.lukumaara;
                    loppusumma += summa;


                    Label Rivi = new Label("" + pr.Nimi + " palvelua varattiin: " + pr.Lukumaara + " Tuotto: " + summa + "€, alv% " + (summa * 0.24) + "€", 0, floaty, 504, 100, Font.Helvetica, 12, TextAlign.Center);
                    Sivu.Elements.Add(Rivi);
                }
                floaty += 50;
                Label Loppurivi = new Label("Palveluiden kokonaistuotto: " + loppusumma + "€, alv% " + (loppusumma * 0.24) + "€", 0, floaty, 504, 100, Font.Helvetica, 12, TextAlign.Center);
                Sivu.Elements.Add(Loppurivi);
                System.IO.Directory.CreateDirectory(@"C:\CabinReports\");
                MRaport.Draw(@"C:\\ServiceReports\\ServiceRaport-" + n + "-" + a + "-" + l + ".pdf");
            }
        }


    }
}
