using ObjectOrientierungEinführung.EinfacheKlassen;
using System;

namespace ObjectOrientierungEinführung
{
    class Program
    {
        static void Main(string[] args)
        {

            Buch buch = new Buch(20,"Mein Text");

            Console.WriteLine(buch.ToString());

            buch.Text = "Mein Buch";
            //buch.SeitenAnzahl = 20; --> geht nicht, weil kein Set definiert wurde.
            //buch.IstEinKrimi = true; --> geht nicht, weil kein Set definiert wurde.

            Console.WriteLine(buch.ToString());

            buch.FügeTextHinzu(" Hallo Welt");

            Console.WriteLine(buch.ToString());

            buch.LöscheText(buch.Text.Length - 4, 4);

            Console.WriteLine(buch.ToString());


            Buch buchzumVergleichen = new Buch(100,"Mein zweiter Text");

            if(buchzumVergleichen.IstLängerAls(buch))
            {
                Console.WriteLine($"Buch {buchzumVergleichen} ist größer als {buch}");
            }
            else
            {
                Console.WriteLine($"Buch {buchzumVergleichen} ist kleiner oder gleich groß wie {buch}");
            }

            Konstructoren();

            InstanzierungUndRefernzierung();

        }


        public static void Konstructoren()
        {
            Buch buch1 = new Buch(); // Leerer Konstruktor.
            Buch buch2 = new Buch(20, "Buch2 Text"); // Leerer Konstruktor.
            Buch buch3 = new Buch(50, "Buch3 Text", true); // Leerer Konstruktor.

        }
        public static void InstanzierungUndRefernzierung()
        {

            Buch buch1 = new Buch(20, "Das ist Buch 1", false); // verweist auf  Instanz 1
            


            Buch buch2 = new Buch(50, "Das ist Buch 2", true); // verweist auf Instaz 2

            Console.WriteLine($"Augabe buch1: {buch1.ToString()}");
            Console.WriteLine($"Augabe buch2: {buch2.ToString()}");
            
            
            Buch buch3 = buch1; // verweist auf Instanz 1 

            Console.WriteLine($"Augabe buch3: {buch3.ToString()}");

            buch3 = new Buch(80, "Das ist Buch 3", false);

            Console.WriteLine($"Augabe buch3: {buch3.ToString()}");
        }
    }
}
