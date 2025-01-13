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
        }
    }
}
