using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingTeht3
{
    class Henkilo
    {
        public string Sotu { get; set; }
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public DateTime SyntymaAika { get; set; }
        public string Kokonimi{ get { return Etunimi + " " + Sukunimi; } }
        private int Ika { get; }
       

         public Henkilo ()
        { }

    }


    class Tyontekija : Henkilo
    {
        public string Nimike { get; set; }
        public int TTN { get; }
        public DateTime AloitusPvm { get; set; }

        public float Palkka { get; set; }

        public float LaskePalkka()
        {
            return 4.2f;
        }

        public Tyontekija(string enimi, string snimi, int ttn, float palkka, string titteli)
        {
            Etunimi = enimi;
            Sukunimi = snimi;
            TTN = ttn;
            Palkka = palkka;
            Nimike = titteli;
        }

        public override string ToString()
        {
            return TTN + " = " + Kokonimi + ", " + Nimike;
        }

    }
}
