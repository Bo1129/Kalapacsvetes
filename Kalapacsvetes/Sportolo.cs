using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalapacsvetes
{
    internal class Sportolo
    {
        public int helyezes { get; set; }
        public double eredmeny { get; set; }
        public string nev { get; set; }
        public string orszag_kod { get; set; }
        public string helyszin { get; set; }
        public string datum { get; set; }

        public Sportolo(string sor)
        {
            string[] s = sor.Split(';');

            helyezes = int.Parse(s[0]);
            eredmeny = double.Parse(s[1]);
            nev = s[2];
            orszag_kod = s[3];
            helyszin = s[4];
            datum = s[5];
        }
    }
}
