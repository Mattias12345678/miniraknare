using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Ägare
    {
        public string Namn { get; set; }
        public int Telefonnummer { get; set; }

        public Ägare(string namn, int telefonnummer)
        {
            Namn = namn;
            Telefonnummer = telefonnummer;
        }

    }
}

