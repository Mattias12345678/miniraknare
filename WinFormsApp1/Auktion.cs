using System;
using System.Collections.Generic;

namespace WinFormsApp1
{
    internal class Auktion
    {
        //listan för hundarna
        internal List<Hund> HundarTillAuktion { get; set; } = new List<Hund>();
        //listan för buden
        private Dictionary<Hund, List<Bud>> Budgivning { get; set; } = new Dictionary<Hund, List<Bud>>();

        internal void LäggTillHund(Hund hund)
        {
            if (!HundarTillAuktion.Contains(hund))
            {
                //om nån lägger en bud på en hund läggs hunden till i auktion
                HundarTillAuktion.Add(hund);
                Budgivning[hund] = new List<Bud>();
                Console.WriteLine($"{hund.Namn} har lagts till i auktionen.");
            }
        }

        internal void LäggBud(Hund hund, Bud bud)
        {
            if (HundarTillAuktion.Contains(hund))
            {
                //om nån lägger till en bud på en hund kommer programmet lägga till buden på hunden och skriva texten under
                Budgivning[hund].Add(bud);
                Console.WriteLine($"{bud.Ägare} lade ett bud på {bud.Belopp} kr på {hund.Namn}.");
            }
            else
            {
                //annars
                Console.WriteLine($"{hund.Namn} är inte med i auktionen.");
            }
        }

        internal void ListaBudFörHund(Hund hund)
        {
            if (Budgivning.ContainsKey(hund))
            {
                Console.WriteLine($"Bud för {hund.Namn}:");
                //för varje bud som läggs på en hund kommer programmet att skriva ned texten under
                foreach (var bud in Budgivning[hund])
                {
                    Console.WriteLine($"{bud.Ägare} budade {bud.Belopp} kr");
                }
            }
            else
            {
                Console.WriteLine($"{hund.Namn} har inga bud.");
            }
        }

        internal void AvslutaAuktionFörHund(Hund hund)
        {
            //kortfattat, om inga fler bud läggs på en hund kommer det högsta budet vinna 
            if (Budgivning.ContainsKey(hund))
            {
                var budLista = Budgivning[hund];
                if (budLista.Count > 0)
                {
                    Bud högstaBud = budLista[0];
                    foreach (var bud in budLista)
                    {
                        if (bud.Belopp > högstaBud.Belopp)
                        {
                            högstaBud = bud;
                        }
                    }

                    Console.WriteLine($"{hund.Namn} såldes till {högstaBud.Ägare} för {högstaBud.Belopp} kr.");
                }
                else
                {
                    Console.WriteLine($"{hund.Namn} fick inga bud.");
                }
            }
            else
            {
                Console.WriteLine($"{hund.Namn} är inte med i auktionen.");
            }
        }
    }
}
