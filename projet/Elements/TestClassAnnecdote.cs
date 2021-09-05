using System;
using System.Collections.Generic;
using System.Text;
using Modele;
using Element;
using static System.Console;

namespace Test
{
    /// <summary>
    /// on peut voir ici que le cas d'utilisation "voir une annecdote sur l'espace est respecter car la méthode annecdoteRandom nous permet d'afficher aléatoirement des anecdore
    /// </summary>
    class TestClassAnnecdote
    {
        public void méthodetestannecdote()
        {
            Manager MonManager = new Manager(new Stub.Stub());
            Console.WriteLine("création d'une aneccdote(ceci est une anecdote) et son affichage:");
            Annecdote testannecdote = new Annecdote("ceci est une anecdote");
            Console.WriteLine("l'anecdote créé:" + testannecdote.Description);
            Console.WriteLine("test de la méthode annecdoteRandom et affichage de l'anecdote retourné");
            Annecdote a = Annecdote.annecdoteRandom(MonManager.ReadOnlyannecdotes);
            Console.WriteLine("l'anecdote :" + a.Description);
        }
    }
}