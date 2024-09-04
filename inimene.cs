using System;

namespace TARpv23_CSharp_Sotsjov.OOP
{
    internal class Inimene
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }

        public Inimene() { }

        public Inimene(string nimi)
        {
            Nimi = nimi;
            Vanus = 0;  // Set a default value if needed
        }

        public Inimene(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
    }
}
