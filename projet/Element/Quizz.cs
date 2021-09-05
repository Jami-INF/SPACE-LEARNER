using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Text;
using static System.Console;

namespace Element
{
    [DataContract]
    public class Quizz
    {
        [DataMember]
        public string Question
        {
            get;
            private set;
        }
        [DataMember]
        public string RepJ
        {
            get;
            private set;
        }
        [DataMember]
        public string RepF1
        {
            get;
            private set;
        }
        [DataMember]
        public string RepF2
        {
            get;
            private set;
        }
        [DataMember]
        public string RepF3
        {
            get;
            private set;
        }
        public Quizz(String question, string repJ, string repF1, string repF2, string repF3)
        {
            Question = question;
            RepJ = repJ;
            RepF1 = repF1;
            RepF2 = repF2;
            RepF3 = repF3;
        }
        public static ReadOnlyCollection<Quizz> PlayQuizz(ReadOnlyCollection<Quizz> Quizs)///permet de jouer au quizz
        {

            List<Quizz> Quest = new List<Quizz>();

            for (int i = 0; i < 11; i++)
            {
                Quizz quize = SelectRandom(Quizs);///on séléectionne 10 quizz tiré au hasard
                Quest.Add(quize);///on les ajoute a une nouvelle liste de quizz

            }
            ReadOnlyCollection<Quizz> QuestQuizz = new ReadOnlyCollection<Quizz>(Quest);

            return QuestQuizz;
        }

        public static Quizz SelectRandom(ReadOnlyCollection<Quizz> Quizs)///permet de renvoyé un quizz tiré au hasard
        {
            Random rnd = new Random();
            int index = rnd.Next(Quizs.Count);
            if (Quizs == null)
            {
                return null;
            }

            if (Quizs.Count < 1)
            {
                return null;
            }
            else
            {
                return Quizs[index];
            }
            

        }
    }
    
}