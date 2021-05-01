using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Oliot
{
    class PalvelutVaraukseen
    {
        private int varausID;
        private int palveluID;
        private int lkm;
        private string nimi;

        public int VarausID { get => varausID; set => varausID = value; }
        public int PalveluID { get => palveluID; set => palveluID = value; }
        public int Lkm { get => lkm; set => lkm = value; }
        public string Nimi { get => nimi; set => nimi = value; }

        public PalvelutVaraukseen(int varausID, int palveluID, int lkm, string nimi)
        {
            VarausID = varausID;
            PalveluID = palveluID;
            Lkm = lkm;
            Nimi = nimi;
        }

        public PalvelutVaraukseen()
        {
        }
    }
}
