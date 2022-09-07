
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KordamineOOP
{
    class Koer: Koduloom
    {
        public enum toug { Mops, Buldog, ShibaInu}; //tõug - порода
        public toug loomaToug;
        public Koer(toug toug, string nimi, string varv, sugu loomaSugu, double kaal, int vanus) : base(nimi, varv, loomaSugu, kaal, vanus)
        {
            this.loomaToug = toug;
        }   

        public Koer(Koer koer) //kloonimiseks
        {
            this.nimi = koer.nimi;
            this.varv = koer.varv;
            this.loomaSugu = koer.loomaSugu;
            this.kaal = koer.kaal;
            this.vanus = koer.vanus;
            this.loomaToug = koer.loomaToug;
        }

        public override void print_Haal()
        {
            Console.WriteLine("KuKu");
        }

        public override string print_Info()
        {
            string text = $"Tõug on {loomaToug}, Värv on {varv}, Nimi on {nimi}, ta on {loomaSugu} ja tema kaal on {kaal} ja ta on {vanus} aastat vana, nahaalsus on {nahaalsus}";
            Console.WriteLine($"Tõug on {loomaToug}, Värv on {varv}, Nimi on {nimi}, ta on {loomaSugu} ja tema kaal on {kaal} ja ta on {vanus} aastat vana, nahaalsus on {nahaalsus}");
            return text;
        }

        public void muudaNimi(string uusNimi) { nimi = uusNimi; }
        public void muudaVarv(string uusVarv) { varv = uusVarv; }
        public void muudaSugu(sugu uusSugu) { loomaSugu = uusSugu; }
        public void muudaKaal(double uusKaal) { kaal = uusKaal; }
        public void muudaVanus(int uusVanus) { vanus = uusVanus; }
    }
}