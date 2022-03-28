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
        public int PocetKnih { get; set; }

        public Oddeleni(string nazev)
        {
            Nazev = nazev;
            PocetKnih = 0;
        }
    }
}
