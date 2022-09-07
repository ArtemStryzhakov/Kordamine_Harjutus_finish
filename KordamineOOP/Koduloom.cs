
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KordamineOOP
{
    abstract class Koduloom
    {
        public string nimi;
        public string varv;
        //public string sugu;

        public enum sugu { isane, emane};
        public sugu loomaSugu;
        public double kaal;
        public int vanus;
        public string nahaalsus;

        public Koduloom(string nimi, sugu loomaSugu, int vanus, string nahaalsus)
        {
            this.nimi = nimi;
            this.loomaSugu = loomaSugu;
            this.vanus = vanus;
            this.varv = nahaalsus;
        }

        public Koduloom(string nimi, string varv, sugu loomaSugu, double kaal = 0.0, int vanus = 0, string nahaalsus = "")
        {
            this.nimi = nimi;
            this.varv = varv;
            this.loomaSugu = loomaSugu;
            this.kaal = kaal;
            this.vanus = vanus;
            this.nahaalsus = nahaalsus;
        }

        public Koduloom() { }
        public abstract string print_Info();
        public abstract void print_Haal();
    }
}