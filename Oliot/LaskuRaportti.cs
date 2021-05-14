using ceTe.DynamicPDF;
using ceTe.DynamicPDF.PageElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Oliot
{
    class LaskuRaportti
    {
        private int laskuID;
        private int VarausID;
        private double summa;
        private double alv;
        private int Maksettu;

        public int LaskuID { get => laskuID; set => laskuID = value; }
        public int VarausID1 { get => VarausID; set => VarausID = value; }
        public double Summa { get => summa; set => summa = value; }
        public double Alv { get => alv; set => alv = value; }

        public int maksettu { get => Maksettu; set => Maksettu = value; }

        public LaskuRaportti()
        {
        }

        public LaskuRaportti(int laskuID, int varausID1, double summa, double alv, int Maksettu)
        {

            LaskuID = laskuID;
            VarausID1 = varausID1;
            Summa = summa;
            Alv = alv;
            maksettu = Maksettu;
        }
        internal static void Reportteri(int la)
        {
            List<LaskuRaportti> Report = new List<LaskuRaportti>();
            Report = LFDB.getLaskuTuloste(la);
            if (Report.Count > 0)
            {
                LaskuRaportti Tuloste = Report.ElementAt(0);
                int floaty = 0;
                Document LTuloste = new Document();
                Page Sivu = new Page(PageSize.A4, PageOrientation.Portrait, 54.0f);
                LTuloste.Pages.Add(Sivu);

                Label Otsikko = new Label("Lasku", 0, floaty, 504, 100, Font.Helvetica, 18, TextAlign.Center);
                Sivu.Elements.Add(Otsikko);
                floaty += 20;
                Label LaskunTiedot = new Label("Lasku numero:" + Tuloste.LaskuID + ", Varauksen numero " + Tuloste.VarausID + ", Laskun summa " + Tuloste.Summa + " € Arvonlisävero " + Tuloste.Alv + " € ", 0, floaty, 504, 100, Font.Helvetica, 16, TextAlign.Center);
                Sivu.Elements.Add(LaskunTiedot);
                System.IO.Directory.CreateDirectory(@"C:\\laskupdf\\");            

                LTuloste.Draw(@"C:\\laskupdf\\Laskupdf "+DateTime.Now+".pdf");

            }
        }
    }
}
