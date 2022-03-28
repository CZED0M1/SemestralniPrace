using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralniPrace
{
    public class Kniha
    {
        public string Nazev { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public bool Vypujceno { get; set; }

        public Kniha(string nazev, string autor, string iSBN)
        {
            Nazev = nazev;
            Autor = autor;
            ISBN = iSBN;
            Vypujceno = false;
        }
    }
}
