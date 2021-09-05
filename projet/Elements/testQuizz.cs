using System;
using System.Collections.Generic;
using System.Text;
using Modele;
using Element;
using static System.Console;
using System.Collections.ObjectModel;

namespace Test
{
    class testQuizz
    {
        /// <summary>
        /// cette class Quizz avec ses méthodes va nous permettre de pouvoir faire le cas d'utilisation "participer a un quizz"
        /// </summary>
        public void méthodetestmquizz()
        {
            Manager MonManager = new Manager(new Stub.Stub());
            Console.WriteLine("création d'un quizz et son affichage:");
            Quizz testquizz = new Quizz("ceci est la question", "juste", "1 bad", "2 bad", "3 bad");
            Console.WriteLine("la question:" + testquizz.Question);
            Console.WriteLine("la bonne réponse" + testquizz.RepJ);
            Console.WriteLine("1 mauvaise réponse" + testquizz.RepF1);
            Console.WriteLine("2 mauvaise réponse" + testquizz.RepF2);
            Console.WriteLine("3 mauvaise réponse" + testquizz.RepF3);
            Console.WriteLine("On test la méthode SelectRandom qui doit nous envoyé un quizz tiré au hasard que nous allons affiché:");
            Quizz q = Quizz.SelectRandom(MonManager.ReadOnlyQuizs);
            Console.WriteLine("la question:" + q.Question);
            Console.WriteLine("la bonne réponse" + q.RepJ);
            Console.WriteLine("1 mauvaise réponse" + q.RepF1);
            Console.WriteLine("2 mauvaise réponse" + q.RepF2);
            Console.WriteLine("3 mauvaise réponse" + q.RepF3);
            Console.WriteLine("On test la méthode PlayQuizz qui doit créé une nouvelle liste de 10 quizz, nous allons afficher seulement toute les qestion.");
            ReadOnlyCollection<Quizz> listquizz = Quizz.PlayQuizz(MonManager.ReadOnlyQuizs);
            for (int i=0 ; i < listquizz.Count ; i++)
            {
                Console.WriteLine(listquizz[i].Question);
            }
        }
    }
}
