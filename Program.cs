namespace Banki_rendszer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bool fut = true;
            while(fut)
            {
                Console.WriteLine("\n1. Új számla létrehozása\n2. Befizetés\n3. Kifizetés\n4. Egy számla adatai\n5. Összes számla listázása\n6. Kilépés");
                Console.Write("Válassz egy lehetőséget: ");
                int opcio = Convert.ToInt32(Console.ReadLine());
                
                switch(opcio)
                {
                    case 1:
                        Console.WriteLine("Add meg a tulajdonos nevét:");
                        string nev = Console.ReadLine();
                        Console.WriteLine("Add me a kezdőegyenleget:");
                        int kezdoEgyenleg = Convert.ToInt32(Console.ReadLine());
                        bank.SzamlaLetrehozas(nev, kezdoEgyenleg);
                        break;
                    case 2:
                        Console.WriteLine("Add meg a számlaszámot:");
                        string szamlaszambefizet = Console.ReadLine();
                        var szamlabefizet = bank.SzamlaKeres(szamlaszambefizet);
                        if (szamlabefizet != null)
                        {
                            Console.WriteLine("Add meg a befizetendő összeget:");
                            int osszegBefizet = Convert.ToInt32(Console.ReadLine());
                            szamlabefizet.befizet(osszegBefizet);
                        }
                        else
                        {
                            Console.WriteLine("Nincs ilyen számla");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Add meg a számlaszámot:");
                        string szamlaszamkifizet = Console.ReadLine();
                        var szamlakifizet = bank.SzamlaKeres(szamlaszamkifizet);
                        if (szamlakifizet != null)
                        {
                            Console.WriteLine("Add meg a kifizetendő összeget:");
                            int osszegKifizet = Convert.ToInt32(Console.ReadLine());
                            szamlakifizet.kifizet(osszegKifizet);
                        }
                        else
                        {
                            Console.WriteLine("Nincs ilyen számla");
                        }
                        break;
                    case 4:
                        Console.Write("Add meg a számlaszámot: ");
                        string szamlaszamadatok = Console.ReadLine();
                        var szamlaadatok = bank.SzamlaKeres(szamlaszamadatok);
                        if (szamlaadatok != null)
                        {
                            Console.WriteLine("A számla adatai:");
                            Console.Write(szamlaadatok.GetSzamlaAdatok());
                        }
                        break ;
                    case 5:
                        bank.OsszesSzamlaAdataok();
                        break;
                    case 6:
                        fut = false;
                        Console.WriteLine("Kilépés...");
                        break;
                    default:
                        Console.WriteLine("Érvénytelen választás!");
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
