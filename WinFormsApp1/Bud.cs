using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Bud
    {
        public string Ägare { get; set; }
        public int Belopp { get; set; }

        public Bud(string ägare, int belopp)
        {
            Ägare = ägare;
            Belopp = belopp;
        }

        public static implicit operator Bud(KeyValuePair<Hund, List<Bud>> v)
        {
            throw new NotImplementedException();
        }
    }
}
