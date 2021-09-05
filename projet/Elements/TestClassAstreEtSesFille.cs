using System;
using System.Collections.Generic;
using System.Text;
using Modele;
using Element;
using static System.Console;
using System.Collections.ObjectModel;

namespace Test
{
    /// <summary>
    /// les class fille de astre se resemble, il n'est dont pas nécessaire de toute les tester
    /// ces class filles vont permettre a l'utilisateur d'avoir une grand variété d'astre.
    /// Dans ce test on va pouvoir voir que l'utilisateur pourra supprimer un astre précis grace a la méthode equal
    /// il pourra donc gerer ses astres comme il le veut se qui remplira les cas d'utilisation "ajouter un astre", "pouvoir modifier un astre" et pouvoir modifier un astre
    /// </summary>
    class TestClassAstreEtSesFille
    {
        public void méthodetestAstreEtFille()
        {
            Console.WriteLine("Nous allons créé une étoile et un trou noir pas default.");
            Etoile testetoile = new Etoile();
            TrNoir testtrounoir = new TrNoir();
            Console.WriteLine("on les ajoute a une liste d'astre");
            List<Astre> listastretest = new List<Astre>();
            listastretest.Add(testetoile);
            listastretest.Add(testtrounoir);
            Console.WriteLine("affichage de l'étoile:");
            Console.WriteLine("nom : " + testetoile.Nom);
            Console.WriteLine("Taille : " + testetoile.Taille);
            Console.WriteLine("Distance terre-astre : " + testetoile.DistanceTA);
            Console.WriteLine("Description : " + testetoile.Description);
            Console.WriteLine("Luminosite : " + testetoile.Luminiosite);
            Console.WriteLine("Masse : " + testetoile.Masse);

            Console.WriteLine("affichage du trou noir:");
            Console.WriteLine("nom : " + testtrounoir.Nom);
            Console.WriteLine("Taille : " + testtrounoir.Taille);
            Console.WriteLine("Distance terre-astre : " + testtrounoir.DistanceTA);
            Console.WriteLine("Description : " + testtrounoir.Description);
            Console.WriteLine("Luminosite : " + testtrounoir.Type);
            Console.WriteLine("on peut voir que ces deux astres on les meme attribut de la class mere");
            Console.WriteLine("On va essayer de supprimé le trou noir de la liste.");
            listastretest.Remove(testtrounoir);
            Console.WriteLine("affichage de la liste");
            for (int i = 0; i < listastretest.Count; i++)
            {
                Console.WriteLine(listastretest[i].TypeAstre);
            }
            Console.WriteLine("on peut voir que c'est bien le trou noir qui a était supprimé. Les méthode equals fonctionne donc bien.");
            Console.WriteLine("On va maintenant modifier notre étoile pour voir si il est possible de modifier un astre puis on va l'afficher");
            testetoile.Nom = "Neptune";
            testetoile.Masse = 40000;
            Console.WriteLine("affichage de l'étoile:");
            Console.WriteLine("nom : " + testetoile.Nom);
            Console.WriteLine("Taille : " + testetoile.Taille);
            Console.WriteLine("Distance terre-astre : " + testetoile.DistanceTA);
            Console.WriteLine("Description : " + testetoile.Description);
            Console.WriteLine("Luminosite : " + testetoile.Luminiosite);
            Console.WriteLine("Masse : " + testetoile.Masse);
        }
    }
}
