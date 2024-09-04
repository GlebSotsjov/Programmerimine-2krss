using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using TARpv23_Glebsots;

namespace TARpv23_CSharp_Sotsjov.OOP
{
    internal class MainClas
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Inimene> inimesed = new List<Inimene>();

            Inimene inimene1 = new Inimene("Peeter", 18);
            Inimene inimene2 = new Inimene("Jelizaveta", 98);
            Inimene inimene3 = new Inimene("Marina", 45);

            inimesed.Add(inimene1);
            inimesed.Add(inimene2);
            inimesed.Add(inimene3);

            inimesed.Add(new Inimene("Irina", 45));

            foreach (Inimene inimene in inimesed)
            {
                Console.WriteLine($"{inimene.Nimi} on {inimene.Vanus} aastat vana");
            }

            Auto auto1 = new Auto("681MRP", Color.Bisque, inimene1);
            Auto auto2 = new Auto("180ANC", Color.Red, inimene2);
            Auto auto3 = new Auto("079YTF", Color.Blue, inimene3);

            auto1.KelleOmaAuto();
            auto2.KelleOmaAuto();
            auto3.KelleOmaAuto();

            Dictionary<Auto, Inimene> register = new Dictionary<Auto, Inimene>();
            register.Add(auto1, inimene1);
            register.Add(auto2, inimene2);
            register.Add(auto3, inimene3);


            foreach (KeyValuePair<Auto, Inimene> pair in register)
            {
                Console.WriteLine($"{pair.Key.RegNumber} - {pair.Value.Nimi}");
            }
        }
    }
}
