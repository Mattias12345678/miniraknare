using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Hund
    {
        public string Ägare { get; set; }
        public int Ålder { get; set; }
        public string Namn { get; set; }



        internal Hund(string ägare, int ålder, string namn)
        {
            Namn = namn;
            Ålder = ålder;
            Ägare = ägare;
        }
    }

    public class Hundras : Hund
    {
        public string Ras { get; set; }
        public float Längd { get; set; }

        internal Hundras(string ras, float längd, string ägare, int ålder, string namn)
            : base(ägare, ålder, namn)
        {
            Ras = ras;
            Längd = längd;
        }
    }
}

