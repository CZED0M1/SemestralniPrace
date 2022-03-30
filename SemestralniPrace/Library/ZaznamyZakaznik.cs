using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralniPrace.Library
{
    public class ZaznamyZakaznik
    {
        public Zakaznik[] zakaznici;
        public int Count { get => zakaznici.Length; }
        public Zakaznik this[int index]
        {
            get
            {
                if (index < 0 || index >= Count) return null;
                else return zakaznici[index];
            }
        }

        public ZaznamyZakaznik()
        {
            zakaznici = new Zakaznik[0];
        }

        public void Add(Zakaznik zz)
        {
            Array.Resize(ref zakaznici, Count + 1);
            zakaznici[Count - 1] = zz;
        }
        public void Remove(int index)
        {
            if (index < 0 || index >= Count) return;
            else
                zakaznici[index] = null;
            for (int i = 0; i < Count; i++)
            {
                if (i >= index && i < Count - 1)
                {
                    Zakaznik temp = zakaznici[i];
                    zakaznici[i] = zakaznici[i + 1];
                    zakaznici[i + 1] = temp;
                }
            }
            Array.Resize(ref zakaznici, Count - 1);
        }
    }
}
