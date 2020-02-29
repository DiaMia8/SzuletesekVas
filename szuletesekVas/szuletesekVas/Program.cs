using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace szuletesekVas
{
    class Program
    {

        static List<Baba> babak = new List<Baba>();

        static void Main(string[] args)
        {
            Console.WriteLine("2. feladat: Adatok beolvasása, tárolása");
            Console.WriteLine("4. feladat: Ellenőrzés");
            foreach (var item in File.ReadAllLines("vas.txt"))
            {
                Baba b = new Baba(item);
                if (b.CdvEll)
                {
                    babak.Add(b);
                }
                else
                {
                    Console.WriteLine($"\tHibás a {item} személyi azonosító!");
                }
                
            }

            Console.WriteLine($"5. feladat: Vas megyében a vizsgált évek alatt {babak.Count} csecsemő született.");
            
           
            Console.WriteLine($"6.feladat: Fiúk száma: {babak.Count(x=>x.nem==Nem.férfi)}.");

            Console.WriteLine($"7. feladat: Vizsgált időszak {babak.Min(x=>x.Szul.Year)} - {babak.Max(x=>x.Szul.Year)}");

            foreach (var item in babak)
            {
                if (item.Szul.Month == 02 && item.Szul.Day== 24 && item.Szul.Year % 4 == 0)
                {
                    Console.WriteLine($"Szökőnapon született baba!");
                    break;
                }
               
            }
            //9. feladat
           

            Console.ReadKey();
        }
    }
}
