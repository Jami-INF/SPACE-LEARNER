using System;
using System.Collections.Generic;
using System.Text;
using Modele;
using Element;
using static System.Console;
namespace Test
{
    class TestManager
    {
        /// <summary>
        /// Permet de tester le fonctionnement des classes et méthodes de manager
        /// elle permet aussi de garder les astres que l'utilisateur aura rentré avec la méthode ajouter.
        /// </summary>
        /// <param name="args"></param>

        Manager MonManager = new Manager(new Stub.Stub());
        public void méthodetestmanager()
        {
            Manager MonManager = new Manager(new Stub.Stub());
            Console.WriteLine("Test astre");
            Etoile testetoile = new Etoile();//on créé une étoile qui est une étoile par default.
            Console.WriteLine("création d'un astre par default et son affichage:");
            Console.WriteLine("nom : " + testetoile.Nom);
            Console.WriteLine("Taille : " + testetoile.Taille);
            Console.WriteLine("Distance terre-astre : " + testetoile.DistanceTA);
            Console.WriteLine("Description : " + testetoile.Description);
            Console.WriteLine("Luminosite : " + testetoile.Luminiosite);
            Console.WriteLine("Masse : " + testetoile.Masse);
            Console.WriteLine("on l'ajoute a la liste astres");
            MonManager.Ajouter(testetoile);
            Console.WriteLine("affichage de la liste:");
            for (int i = 0; i < MonManager.astres.Count; i++)
            {
                Console.WriteLine("nom : " + MonManager.astres[i].Nom);
            }
            Console.WriteLine("on le supprime de la liste");
            Console.WriteLine("affichage de la liste:");
            MonManager.Supprimer(testetoile);
            for (int i = 0; i < MonManager.astres.Count; i++)//on regarde si il est dans la liste
            {
                Console.WriteLine("nom : " + MonManager.astres[i].Nom);
            }
            Console.WriteLine("test pour savoir si la liste des astre est null ou non:");
            bool ouinon = MonManager.Listevideounon();
            Console.WriteLine("se que la fonction nous renvoie:" + ouinon);
            Console.WriteLine("Si la liste n'est pas null alors la méthode nous renvoie false");
            Console.WriteLine("affichage d'une anecdote random:");
            Annecdote A;
            A = Annecdote.annecdoteRandom(MonManager.ReadOnlyannecdotes);
            Console.WriteLine("L'anecdote:" + A.Description);
            Console.WriteLine("affichage d'un astre random:");
            Astre B;
            B = Astre.AstrRandom(MonManager.astres);
            Console.WriteLine("le nom de l'astre:" + B.Nom);
            Console.WriteLine("affichage d'un astre random:");

            /*AffAstre astres = new Element.AffAstre();
            Etoile soleil = new Etoile("soleil", "10^10 km", "2", "Descritionblablabla","Ill1",20000,2500);
            Planete terre = new Planete("Terre", "10^10 km", "2", "Descritionblablabla", "Ill1", true, 2000, 25000);
            Planete mars = new Planete("mars", "10^10 km", "2", "Descritionblablabla",  "Ill1", false, 600, 8000);
            astres.Ajouter(soleil);
            astres.Ajouter(terre);
            astres.Ajouter(mars);
            string tipe = "Element.Planete";
            astres.TrierPar(tipe);

            Annecdote annecdotes = new Annecdote();
            annecdotes.Ajouter("blabla");
            annecdotes.Ajouter("buuhhh");
            annecdotes.Ajouter("bljjjjjaa");
            annecdotes.Ajouter("bllllil");
            annecdotes.Ajouter("bloblob");
            annecdotes.Ajouter("blahh");
            string annec = annecdotes.selectRandom();
            WriteLine(annec);


            JouerQuizz Quizs = new JouerQuizz();
            Quizz q1 = new Quizz("quelle est la couleur d'un trou noir ?", "noire", "blanche", "jaune", "rouge");
            Quizz q2 = new Quizz("quelle est la couleur du soleil ?", "noire", "blanche", "jaune", "rouge");
            Quizz q3 = new Quizz("quelle est la couleur d'une galaxie ?", "noire", "blanche", "jaune", "rouge");
            Quizs.Ajouter(q1);
            Quizs.Ajouter(q2);
            Quizs.Ajouter(q3);
            Quizs.PlayQuizz();*/
        }
    }
}
