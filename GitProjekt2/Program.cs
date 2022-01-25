using System;

namespace GitProjekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Osoba osoba1 = new Osoba();

            Console.WriteLine(osoba1.Narozeni);

            Console.WriteLine("Zadejte datum narození");
            DateTime datum = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(osoba1.Vek());

            Console.ReadKey();
        }
    }
}
