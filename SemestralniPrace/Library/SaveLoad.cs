using SemestralniPrace.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralniPrace.Library
{
    internal class SaveLoad
    {
        public readonly string file;
        public readonly ZaznamyOddeleni oddeleni;
        public readonly ZaznamyZakaznik zakaznici;

        public SaveLoad(string file, ZaznamyOddeleni oddeleni, ZaznamyZakaznik zakaznici)
        {
            this.file = file;
            this.oddeleni = oddeleni;
            this.zakaznici = zakaznici;
        }
        public void Save()
        {
            using (StreamWriter writer = new StreamWriter(file)) { 
            foreach (var odd in oddeleni.oddeleni)
            {
                writer.WriteLine(odd.Nazev + "," + odd.Count);
                foreach (var kniha in odd.knihy)
                {
                    writer.WriteLine(kniha.Nazev + "," + kniha.Autor + "," + kniha.ISBN);
                }
                }
                writer.Write("-----------------------------------\n");
                foreach (var zak in zakaznici.zakaznici)
                {
                    writer.WriteLine(zak.Name + "," + zak.Vypujceno);
                    foreach (var kniha in zak.Pujcene)
                    {
                        writer.WriteLine(kniha.Nazev + "," + kniha.Autor + "," + kniha.ISBN);
                    }
                }
                writer.Write("-----------------------------------\n");
                writer.Close();
            }
        }
        public void Load(out ZaznamyOddeleni oddeleni,out ZaznamyZakaznik zakaznici)
        {
            oddeleni = new ZaznamyOddeleni();
            zakaznici = new ZaznamyZakaznik();
            int id = 0;
            using (StreamReader reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    while (line != "-----------------------------------")
                    {
                        string[] parts = line.Split(',');
                        Oddeleni a = new Oddeleni(parts[0]);
                        int pocet = 0;
                        int.TryParse(parts[1], out pocet);
                        for (int i = 0; i < pocet; i++)
                        {
                           string kniha= reader.ReadLine();
                           string[] split = kniha.Split(',');
                           a.addKniha(new Kniha(split[0], split[1], split[2]));
                        }
                        oddeleni.Add(a);
                        line = reader.ReadLine();
                    }
                    line= reader.ReadLine();
                    while (line != "-----------------------------------")
                    {
                     string[] split = line.Split(',');
                        Zakaznik z = new Zakaznik(split[0], id);
                        id++;
                        int pocet = 0;
                        int.TryParse(split[1], out pocet);
                        for (int i = 0; i < pocet; i++)
                        {
                            string kniha = reader.ReadLine();
                            string[] splitk = kniha.Split(',');
                            Kniha k = new Kniha(splitk[0], splitk[1], splitk[2]);
                            z.AddVypujcku(k);
                        }
                        zakaznici.Add(z);
                        line = reader.ReadLine();
                        Console.WriteLine(z.Name);
                    }

                }
                reader.Close();
            }
        }
    }

}
