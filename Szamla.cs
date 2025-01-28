using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banki_rendszer
{
    internal class Szamla
    {

        //osztály atribútumok
        //statikus lényege hogy nem változik
        private static int KovetkezoSzamlaSzam = 1000;
        public string SzamlaSzam {  get; private set; }
        public string Tulaj {  get; private set; }
        public int Egynleg {  get; private set; }

        //konstruktor (kezdeti értéke a változóknak)

        public Szamla(string tulaj, int kezdoEgyenleg)
        {
            SzamlaSzam = $"ACC{KovetkezoSzamlaSzam++}";
            Tulaj = tulaj ;
            Egynleg = kezdoEgyenleg;
        }

        public void befizet(int osszeg)
        {
            if (osszeg > 0)
            {
                Egynleg += osszeg;
                Console.WriteLine($"{osszeg} HUF befizetve a(z) {SzamlaSzam} számlára");
            }
            else
            {
                Console.WriteLine("Hibás összeg, nem lehet negatív vagy 0");
            }
        }

        public void kifizet(int osszeg) 
        {
            if(osszeg > 0 && osszeg <= Egynleg)
            {
                Egynleg -= osszeg;
                Console.WriteLine($"{osszeg} HUF kifizetve a(z) {SzamlaSzam} számláról. Megmaradt összeg a számlán: {Egynleg} HUF");
            }
            else
            {
                Console.WriteLine("Hibás összeg vagy nincs elég pénz a számlán");
            }
        }

        public string GetSzamlaAdatok() 
        {
            return $"\nSzámlaszám: {SzamlaSzam}\nTulajdonos: {Tulaj}\nEgyenleg: {Egynleg} HUF\n";
        }
    }
}
