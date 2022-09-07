using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KordamineOOP
{
    class Raccoon: Koduloom
    {
        public enum tougR { Eastern_raccoon, Florida_raccoon, Texas_raccoon }; //tõug - порода
        public tougR tougRaccoon;

        public Raccoon(tougR tougRaccoon, string nimi, string varv, sugu loomaSugu, double kaal, int vanus, string impudence = "") : base(nimi, varv, loomaSugu, kaal, vanus, impudence)
        {
            this.tougRaccoon = tougRaccoon;
        }

        public Raccoon(string nimi, sugu loomaSugu, int vanus, string nahaalsus)
        {
            this.nimi = nimi;
            this.loomaSugu = loomaSugu;
            this.vanus = vanus;
            this.nahaalsus = nahaalsus;
        }
        public Raccoon(Raccoon raccoon) //kloonimiseks
        {
            this.nimi = raccoon.nimi;
            this.varv = raccoon.varv;
            this.loomaSugu = raccoon.loomaSugu;
            this.kaal = raccoon.kaal;
            this.vanus = raccoon.vanus;
            this.tougRaccoon = raccoon.tougRaccoon;
            this.nahaalsus = raccoon.nahaalsus;
        }

        public override void print_Haal()
        {
            Console.WriteLine("I am raccoon motherfucker");
        }
        
        public override string print_Info()
        {
            string text = $"Tõug on {tougRaccoon}, Nimi on {nimi}, Värv on {varv}, Sugu on {loomaSugu} ja tema kaal on {kaal} ja ta on {vanus} aastat vana, nahaalsus on {nahaalsus}";

            return text;
        }

        public void muudaNimi(string uusNimi) { nimi = uusNimi; }
        public void muudaVarv(string uusVarv) { varv = uusVarv; }
        public void muudaSugu(sugu uusSugu) { loomaSugu = uusSugu; }
        public void muudaKaal(double uusKaal) { kaal = uusKaal; }
        public void muudaVanus(int uusVanus) { vanus = uusVanus; }
        public void muudaImpudence(int uusImpudence) { vanus = uusImpudence; }
    }
}