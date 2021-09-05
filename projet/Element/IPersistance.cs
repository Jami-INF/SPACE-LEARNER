using Element;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Modele
{
    public interface IPersistance
    {
        /// <summary>
        /// Interface Charge données lie MyDataContractPers et le manager
        /// </summary>
        /// <returns></returns>
        public(List<Astre> astres, ReadOnlyCollection<Quizz> Quizs, ReadOnlyCollection<Types> types, ReadOnlyCollection<Annecdote> annecdotes) ChargeDonnees();
        public void SauvegardeDonnees(List<Astre> astres, ReadOnlyCollection<Quizz> Quizs, ReadOnlyCollection<Types> types, ReadOnlyCollection<Annecdote>annecdotes);
    }
}
