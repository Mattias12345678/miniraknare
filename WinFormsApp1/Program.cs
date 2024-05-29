namespace WinFormsApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hund hund1 = new Hund("olle", 12, "rufus");
            Hund hund2 = new Hund("kung", 3, "tutti");

            Ägare ägare1 = new Ägare("memem", 00000000);
            Ägare ägare2 = new Ägare("ememem", 11111111);

            Auktion auktion = new Auktion();

            // läggs till hundar i auktionen
            auktion.LäggTillHund(hund1);
            auktion.LäggTillHund(hund2);

            // ägare lägger bud på hunden
            auktion.LäggBud(hund1, new Bud("kung", 500));
            auktion.LäggBud(hund2, new Bud("olle", 300));

            // listar alla bud för varje hund
            auktion.ListaBudFörHund(hund1);
            auktion.ListaBudFörHund(hund2);

            // avslutar auktionen för hundar och visa vinnare
            auktion.AvslutaAuktionFörHund(hund1);
            auktion.AvslutaAuktionFörHund(hund2);

            Console.WriteLine("Tryck på en knapp för att avsluta...");
            Console.ReadKey();
        }

    }
}
