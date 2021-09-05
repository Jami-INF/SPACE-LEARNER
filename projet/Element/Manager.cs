using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Element;
using Modele;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Modele
{
    public class Manager
    {
        /// dépendance gestionnaire de persistance
        public IPersistance Persistance { get; /*private*/ set; }

        /// liste des types d'astre de type Type
        private static List<Types> types = new List<Types>();
        public ReadOnlyCollection<Types> ReadOnlytypes { get; set; } = new ReadOnlyCollection<Types>(types);

        ///liste des astres de type Astre
        public List<Astre> astres { get; set; } = new List<Astre>();

        ///liste des anecdotes de type Anecdote
        private static List<Annecdote> annecdotes  = new List<Annecdote>();
        public ReadOnlyCollection<Annecdote> ReadOnlyannecdotes = new ReadOnlyCollection<Annecdote>(annecdotes);

        ///liste des quizz de type Quizz
        private static List<Quizz> Quizs = new List<Quizz>();
        public ReadOnlyCollection<Quizz> ReadOnlyQuizs = new ReadOnlyCollection<Quizz>(Quizs);

        ///renvoie un astre tiré au hasard
        public Astre RandAstre  => Astre.AstrRandom(astres);

        ///renvoie une anecdote tiré au hasard
        public Annecdote Randannec => Annecdote.annecdoteRandom(ReadOnlyannecdotes);

        public ReadOnlyCollection<Quizz> jouQuizz { get; }

        /// <summary>
        /// on initialise les listes avec les valeurs de donnes qui sont la lecture des fichiers xml

        /// </summary>
        public void ChargeDonnees()
        {
            astres.Clear();
            Quizs.Clear();
            annecdotes.Clear();
            types.Clear();

            var donnees = Persistance.ChargeDonnees();

            foreach (Quizz i in donnees.Quizs)
            {
                Quizs.Add(i);
            }
            foreach (Astre j in donnees.astres)
            {
                astres.Add(j);
            }
            foreach (Annecdote k in donnees.annecdotes)
            {
                annecdotes.Add(k);
            }
            foreach (Types l in donnees.types)
            {
                types.Add(l);
            }

        }
        /// <summary>
        /// sert a auvegarder les données
        /// </summary>
        public void SauvegardeDonnees()
        {
            Persistance.SauvegardeDonnees(astres, ReadOnlyQuizs, ReadOnlytypes, ReadOnlyannecdotes);
        }

        /// <summary>
        /// permet de sauvegarder les modifications qui ont été faite sur les listes
        /// </summary>
        /// <param name="persistance"></param>
        public Manager(IPersistance persistance)
        {
            Persistance = persistance;

            var donnees = Persistance.ChargeDonnees();

            astres = donnees.astres;
            ReadOnlyQuizs = donnees.Quizs;
            ReadOnlyannecdotes = donnees.annecdotes;
            ReadOnlytypes = donnees.types;


            jouQuizz = Quizz.PlayQuizz(ReadOnlyQuizs);

        }

        /// <summary>
        /// constructeur de Manager utilisé dans les tests
        /// </summary>
        public Manager()
        {
            jouQuizz = Quizz.PlayQuizz(ReadOnlyQuizs);
        }
        /// <summary>
        /// permet d'ajouter un astre a la liste d'astre
        /// </summary>
        /// <param name="astre"></param>
        public void Ajouter(Astre astre)
        {
            astres.Add(astre);
        }
        /// <summary>
        /// supprime un astre de la liste astres puis on fais appel a la méthode SauvegarderDonnees pour garder en mémoire la suppression de l'astre
        /// </summary>
        /// <param name="astre"></param>
        public void Supprimer(Astre astre)
        {
            astres.Remove(astre);///
            Persistance.SauvegardeDonnees(astres, ReadOnlyQuizs, ReadOnlytypes, ReadOnlyannecdotes);
        }
        /// <summary>
        /// sert a savoir si la liste astres ne contient aucun élément retourne trur si vide et return false si pas vide
        /// </summary>
        /// <returns></returns>
        public bool Listevideounon()
        {
            int a = astres.Count;
            if (a == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
