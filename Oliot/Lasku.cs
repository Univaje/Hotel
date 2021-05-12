﻿using System;
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

        public int LaskuID { get => laskuID; set => laskuID = value; }
        public int VarausID1 { get => VarausID; set => VarausID = value; }
        public double Summa { get => summa; set => summa = value; }
        public double Alv { get => alv; set => alv = value; }

        public Lasku()
        {
        }

        public Lasku(int laskuID, int varausID1, double summa, double alv)
        {
            LaskuID = laskuID;
            VarausID1 = varausID1;
            Summa = summa;
            Alv = alv;
        }
    }
}
