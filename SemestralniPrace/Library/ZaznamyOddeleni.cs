﻿using SemestralniPrace.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralniPrace.Library
{
    public class ZaznamyOddeleni
    {
        public Oddeleni[] oddeleni;
        public int Count { get => oddeleni.Length; }
        public Oddeleni this[int index]
        {
            get
            {
                if (index < 0 || index >= Count) return null;
                else return oddeleni[index];
            }
        }

        public ZaznamyOddeleni()
        {
            oddeleni = new Oddeleni[0]; 
        }
        public void Add(Oddeleni od)
        {
            Array.Resize(ref oddeleni, Count+1);
            oddeleni[Count-1] = od;
        }
    }
}
