using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using Modele;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;

namespace Element
{
    [DataContract]
    public class Annecdote
    {
        public Annecdote(String description)
        {
            Description = description;
        }
        [DataMember]
        public string Description
        {
            get;
            private set;
        }
        //List<string> annecdotes = new List<string>();



        /*public void Ajouter(string description)
        {
            annecdotes.Add(description);
            //Description = description;
        }
        public string selectRandom()
       {
                Random rnd = new Random();
                int index = rnd.Next(annecdotes.Count);
                return annecdotes[index];
        }*/

        /// <summary>
        /// retourne une annecdote tiré au hasard dans la Liste annecdoteRandom
        /// </summary>
        /// <param name="annecdoteRandom"></param>
        /// <returns></returns>
        public static Annecdote annecdoteRandom(ReadOnlyCollection<Annecdote> annecdoteRandom)
        {
            Random rnd = new Random();
            int index = rnd.Next(annecdoteRandom.Count);
            if (annecdoteRandom == null)
                {
                    return null;
                }

            if (annecdoteRandom.Count <1)
            {
                return null;
            }
            else
                {

                return annecdoteRandom[index];
                }
            }

        

    }
}
