using System;
using System.Collections.Generic;
using System.Text;

namespace GithubDemo26
{
    public class KlasseFraThor
    {
        public KlasseFraThor(string kortnummer)
        {
            KortNummer = kortnummer;
        }

    public string KortNummer { get; set; }

        public void GivKortOplysningerTilThor()
        {
            Console.WriteLine(KortNummer);
        }


        public void PrintHej()
        {
            Console.WriteLine("Hej");
        }
    }
}
