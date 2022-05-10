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
        public void removeKniha(Kniha kniha)
        {
            int inde=0;
            foreach (var item in knihy)
            {
                if (kniha.Equals(item))
                {
                    while(inde+1 < Count)
                    {
                        knihy[inde] = knihy[inde + 1];
                        inde++;
                    }
                    knihy[Count-1] = null;
                    Array.Resize(ref knihy, Count - 1);
                    break;
                }
                inde++;
            }
        }
    }
}
