﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD_04_1302210024
{
    internal class KodeBuah
    {
        public enum Buah
        {
            Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung,
            Kurma, Durian, Anggur, Melon, Semangka
        }
        public String getKodeBuah(Buah buah) 
        {
            string[] KodeBuah = { "A00", "B00", "C00", "D00","E00", "F00", "G00", "H00",
            "I00", "J00", "K00", "L00", "M00","N00", "O00"};
            return KodeBuah[(int)buah];
        }

    }

}