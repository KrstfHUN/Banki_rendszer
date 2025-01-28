using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banki_rendszer
{
    internal class Bank
    {
        //atribútum
        private List<Szamla> szamlak = new List<Szamla>();
        
        //új számla
        public void SzamlaLetrehozas(string tulaj, int kezdoEgyneleg)
        {
            Szamla ujSZamla = new Szamla(tulaj, kezdoEgyneleg);
            szamlak.Add(ujSZamla);
            Console.WriteLine($"\nÚj számla létrehozva! {ujSZamla.GetSzamlaAdatok()}");
        }

        //számla keresés
        public Szamla SzamlaKeres(string szamlaszam)
        {
            foreach (var szamla in szamlak)
            {
                if (szamla.SzamlaSzam == szamlaszam)
                {
                    return szamla;
                }
            }
            return null;
        }

        public void OsszesSzamlaAdataok()
        {
            if (szamlak.Count == 0) 
            {
                Console.WriteLine("Nincs egyetlen számla sem a rendszerben");
            }
            else
            {
                Console.WriteLine("Összes számla:");
                foreach (var szamla in szamlak)
                {
                    Console.WriteLine(szamla.GetSzamlaAdatok());
                }
            }
        }
    }

}
