using System;
using System.Collections.Generic;
using System.Text;

namespace Element
{

    public class AffAstre
    {
        List<Astre> astres = new List<Astre>();

        public void Ajouter(Astre astre)
        {
            astres.Add(astre);
        }
        /// <summary>
        /// permet d'afficher le nom des astres d'un type passé en parametre au format Element.type
        /// </summary>
        /// <param name="tipe"></param>
        public void TrierPar(string tipe)
        {
            foreach (Astre astre in astres)
            {
                Type type = astre.GetType();
                if (Convert.ToString(type).Equals(tipe))
                    Console.WriteLine(astre.Nom); 
            }
        }
    }
}
