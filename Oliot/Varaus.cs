using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Oliot
{
    class Varaus
    {
        private int varausID;
        private int AsiakasID;
        private int mokkiID;
        private int varattuPvm;
        private DateTime vahvistettuPvm;
        private DateTime varattuAlku;
        private DateTime varattuLoppu;

        public int VarausID { get => varausID; set => varausID = value; }
        public int AsiakasID1 { get => AsiakasID; set => AsiakasID = value; }
        public int MokkiID { get => mokkiID; set => mokkiID = value; }
        public int VarattuPvm { get => varattuPvm; set => varattuPvm = value; }
        public DateTime VahvistettuPvm { get => vahvistettuPvm; set => vahvistettuPvm = value; }
        public DateTime VarattuAlku { get => varattuAlku; set => varattuAlku = value; }
        public DateTime VarattuLoppu { get => varattuLoppu; set => varattuLoppu = value; }

        public Varaus()
        {
        }

        public Varaus(int varausID, int asiakasID1, int mokkiID, int varattuPvm, DateTime vahvistettuPvm, DateTime varattuAlku, DateTime varattuLoppu)
        {
            VarausID = varausID;
            AsiakasID1 = asiakasID1;
            MokkiID = mokkiID;
            VarattuPvm = varattuPvm;
            VahvistettuPvm = vahvistettuPvm;
            VarattuAlku = varattuAlku;
            VarattuLoppu = varattuLoppu;
        }
    }
}
