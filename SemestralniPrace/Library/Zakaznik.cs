using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralniPrace
{
    public class Zakaznik
    {
        public static int Pocet=0;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Vypujceno { get; set; }

        public Zakaznik(string name)
        {
            Id = Pocet;
            Pocet++;
            Name = name;
            Vypujceno = 0;
        }
    }
}
