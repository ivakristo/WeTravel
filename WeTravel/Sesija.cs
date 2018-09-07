using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeTravel
{
    public class Sesija
    {
        public static string KorisnickoIme;
        public static int RazinaPrava;
        public static int ZaposlenikId;
        public Sesija(string korime, int razina, int id)
        {
            KorisnickoIme = korime;
            RazinaPrava = razina;
            ZaposlenikId = id;
        }
    }
}
