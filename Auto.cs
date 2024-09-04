﻿using System;
using System.Drawing;
using TARpv23_CSharp_Sotsjov.OOP;  // Correctly referencing the namespace where Inimene is located

namespace TARpv23_Glebsots
{
    internal class Auto
    {
        public string RegNumber { get; set; }
        public Color Varv { get; set; }
        public Inimene Omanik { get; set; }

        public Auto() { }

        public Auto(string regNumber, Color varv, Inimene omanik)
        {
            RegNumber = regNumber;
            Varv = varv;
            Omanik = omanik;
        }

        public void KelleOmaAuto()
        {
            Console.WriteLine($"{Varv.Name} auto regnumbriga {RegNumber} on {Omanik.Nimi} oma");
        }
    }
}

