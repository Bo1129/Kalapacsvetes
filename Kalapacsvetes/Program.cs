using System.Buffers;

namespace Kalapacsvetes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sportolo> sportolok = new();

            foreach (var sor in File.ReadAllLines("kalapacsvetes.txt").Skip(1))
            {
                sportolok.Add(new Sportolo(sor));
            }
            Console.WriteLine($"4.feladat: {sportolok.Count} dobás eredménye található.");
            //5.feladat
            double osszeg = 0;
            int db = 0;
            foreach (var s in sportolok)
            {
                if (s.orszag_kod == "HUN")
                {
                    osszeg += s.eredmeny;
                    db++;
                }

            }
            Console.WriteLine($"5.feladat: A magyar sportolók átlagosan {osszeg/db} métert dobtak");

            //LinQ
            double atlag = sportolok.Where(s => s.orszag_kod == "HUN").Average(s => s.eredmeny);
            Console.WriteLine($"5.feladat: A magyar sportolók átlagosan {atlag} métert dobtak");
        }
    }
}
