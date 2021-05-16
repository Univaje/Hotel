using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Lasku
    {
        private int laskuID;
        private int VarausID;
        private double summa;
        private double alv;
        private int Maksettu;

        private DateTime vahvistus_pvm;
        public DateTime VahvistusPVM { get => vahvistus_pvm; set => vahvistus_pvm = value; }

        public int LaskuID { get => laskuID; set => laskuID = value; }
        public int VarausID1 { get => VarausID; set => VarausID = value; }
        public double Summa { get => summa; set => summa = value; }
        public double Alv { get => alv; set => alv = value; }

        public int maksettu { get => Maksettu; set => Maksettu = value; }

        public Lasku()
        {
        }
        public Lasku(int laskuID, int varausID1, double summa, double alv, int Maksettu, DateTime vahvistus_pvm)
        {

            LaskuID = laskuID;
            VarausID1 = varausID1;
            Summa = summa;
            Alv = alv;
            maksettu = Maksettu;
            VahvistusPVM = vahvistus_pvm;
        }

        internal static void Pvmhaku(DateTime a, DateTime l)
        {

          LFDB.Pvmhaku(a, l);
        }

        public Lasku(int laskuID, int varausID1, double summa, double alv, int Maksettu)
        {
            LaskuID = laskuID;
            VarausID1 = varausID1;
            Summa = summa;
            Alv = alv;
            maksettu = Maksettu;
        }
    }
}
