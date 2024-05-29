namespace WinFormsApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hund hund1 = new Hund("olle", 12, "rufus");
            Hund hund2 = new Hund("kung", 3, "tutti");

            �gare �gare1 = new �gare("memem", 00000000);
            �gare �gare2 = new �gare("ememem", 11111111);

            Auktion auktion = new Auktion();

            // l�ggs till hundar i auktionen
            auktion.L�ggTillHund(hund1);
            auktion.L�ggTillHund(hund2);

            // �gare l�gger bud p� hunden
            auktion.L�ggBud(hund1, new Bud("kung", 500));
            auktion.L�ggBud(hund2, new Bud("olle", 300));

            // listar alla bud f�r varje hund
            auktion.ListaBudF�rHund(hund1);
            auktion.ListaBudF�rHund(hund2);

            // avslutar auktionen f�r hundar och visa vinnare
            auktion.AvslutaAuktionF�rHund(hund1);
            auktion.AvslutaAuktionF�rHund(hund2);

            Console.WriteLine("Tryck p� en knapp f�r att avsluta...");
            Console.ReadKey();
        }

    }
}
