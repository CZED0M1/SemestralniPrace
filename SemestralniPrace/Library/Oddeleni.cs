using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralniPrace.Entity
{
    public class Oddeleni
    {
        public string Nazev { get; set; }

        public Kniha[] knihy;
        public int Count { get => knihy.Length; }
        public Kniha this[int index]
        {
            get
            {
                if (index < 0 || index >= Count) return null;
                else return knihy[index];
            }
        }

        public Oddeleni(string nazev)
        {
            Nazev = nazev;
            knihy = new Kniha[0];
        }
        public void addKniha(Kniha kniha)
        {
            if (kniha != null)
            {
                Array.Resize(ref knihy, Count+1);
                knihy[Count - 1] = kniha;
            }
        }
    }
}
