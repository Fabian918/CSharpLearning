using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientierungEinführung.EinfacheKlassen
{
    public class Buch
    {
        /*
         *  Variablen ,
         *  sollten nur Private deklariert werden ( also nur intern, in der Klasse zugreifbar) 
         * führen keinen Code aus, zeigen direkt auf den Wert im Speicher 
         */

        private int seitenAnzahl;

        private string text;

        private bool istEinKrimi;


        /* 
         * Properties,
         * können Code ausführen, und müssen nicht direkt auf einen Speicher zeigen. 
         * Wichtig ist: sie verhalten sich für den Aufrufer WIE eine Variable. 
         * Intern müssen wir mit get & set dafür sorgen dass sie das auch tun.
         *  
         *  GET -> ist der lesende Zugriff.
         *  SET -> ist der schreibende Zugriff (gibt eine value vom typ der Property mit)
         * 
         */

        public int SeitenAnzahl
        {
            get
            {
                return this.seitenAnzahl;
            }
        }

        public string Text
        {
            get
            {
                return this.text;
            }
            set
            {
                this.text = value;
            }
        }

        public bool IstEinKrimi
        {
            get
            {
                return this.istEinKrimi;
            }
        }

        
        /* 
         * Konstruktoren
         *  --> über Konstruktoren werden Instancen der Klasse erstellt. 
         *  wenn kein Konstruktor definiert wird, gibt uns C# einen leeren Konstruktor vor.
         * Wir können so kontrollieren, wie Instancen unserer Klassen erstellt werden
         *   -> welche Parameter (Variablen) brauchen wir auf jeden Fall, welche sind optional
         *   -> welche Dinge müssen direkt beim erstellen erledigt werden
         */

        public Buch()
        {
            this.seitenAnzahl = 0;
            this.text = "";
            this.istEinKrimi = false;
        }

        public Buch(int seitenAnzahl, string text)
        {
            this.seitenAnzahl = seitenAnzahl;
            this.text = text;
            this.istEinKrimi = false;
        }

        public Buch(int seitenAnzahl, string text, bool istEinKrimi)
        {
            this.seitenAnzahl = seitenAnzahl;
            this.text = text;
            this.istEinKrimi = istEinKrimi;
        }

        /*
         * Methoden,
         * können Private oder Public sein
         *  --> Methoden können 
         *      --> void zurückgeben (Keinen Rückgabewert) 
         *      --> Belibige Datentypen zurückgeben (string, int , bool, ...) 
         * --> Methoden füren aktiv Code aus, wenn sie aufgerufen werden.
         * --> Methoden arbeiten mit ihren Übergabeparamter ( -> von extern) und den Instanzvariablen ( -> Klassen intern)  
         */ 

        public void FügeTextHinzu(string textZumHinzufügen)
        {
            this.text = this.text + textZumHinzufügen;
        }

        public void LöscheText(int anfang, int länge)
        {
            this.text.Remove(anfang, länge);
        }


        
        /*
         * Hier würde sich auch eine Property eignen.
         * Der RückgabeWert berechnet sich komplett aus Variablen.
         * Die Methode verändert keine Instanzvariablen. 
         * 
         * Property oder Methdode: 
         * die Property MUSS sich wie eine Variable verhalten, d.h: 
         *  - keine Langen Opertation (Zeit) 
         *  - keine Operationen die die Klasse mehr als im Erwarteten Maße beeinflussen
         * 
         * Im Allgemeine gilt: 
         * wenn Komplex, groß --> Methode, 
         * wenn nicht und komplett aus internen Variablen konstruirbar --> Property
         */

        public bool IstLängerAls(Buch buchZumVergleichen)
        {
            if(buchZumVergleichen.SeitenAnzahl > this.SeitenAnzahl)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"Buch mit {this.seitenAnzahl} Seiten und folgendem Text : \'{this.text}\'. Es ist {(this.istEinKrimi ? "ein" : "kein")} Krimi";
        }



    }
}
