using System;
using Element;

namespace mainessais
{
 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test astre");
            Astre soleil = new Astre("soleil", "10^10 km", "2", "Descritionblablabla");
            Astre terre = new Astre("Terre", "10^10 km", "2", "Descritionblablabla");
            Astre mars = new Astre("mars", "10^10 km", "2", "Descritionblablabla");
            Annecdote un = new Annecdote(1, "blablabla");
            Console.Write(un.Description);
            Console.ReadKey();

        }
    }
}
