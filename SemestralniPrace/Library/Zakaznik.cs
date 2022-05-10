using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralniPrace
{
    public class Zakaznik
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Vypujceno { get => Pujcene.Length; }
        public Kniha[] Pujcene;
        public int Count { get => Pujcene.Length; }

        public Zakaznik(string name,int id)
        {
            Id = id;
            Name = name;
            Pujcene = new Kniha[0];
        }
        public void AddVypujcku(Kniha kniha)
        {
            Array.Resize(ref Pujcene, Pujcene.Length+1);
            Pujcene[Pujcene.Length-1] = kniha;
        }
        public void RemoveVypujcku(Kniha kniha)
        {
            int inde = 0;
            foreach (Kniha item in Pujcene)
            {
                while (inde + 1 < Count)
                {
                    Pujcene[inde] = Pujcene[inde + 1];
                    inde++;
                }
                Pujcene[Count - 1] = null;
                Array.Resize(ref Pujcene, Count - 1);
                break;
            }
        }
    }
}
