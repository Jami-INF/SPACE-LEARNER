using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text;
using Element;
using Modele;

namespace Element
{
    [DataContract]
    public class Galaxie : Astre, IEquatable<Astre>
    {
        [DataMember]
        public int Nbetoile
        {
            get;
            set;
        }
        public Galaxie()
        {
            Nbetoile = 0;
            TypeAstre = TypeEnum.Galaxie;
        }
        public Galaxie(String nom, string taille, string distanceTA, string description, string illustration, TypeEnum typeAstre, int nbetoile) : base(nom, taille, distanceTA, description, illustration, typeAstre)
        {
            Nbetoile = nbetoile;
        }
        public bool Equals([AllowNull] Galaxie other)/// on regarde si les deux astre on les meme attribut
        {
            return Nbetoile == other.Nbetoile;
        }
        public override int GetHashCode()///retourne le code de hachage de l'objet
        {
            return base.GetHashCode();
        }
        public override bool Equals(object right)
        {
            //check null
            if (right is null)///on regarde si l'objet est null
            {
                return false;
            }

            if (object.ReferenceEquals(this, right))///on regarde si ils ont la meme référence
            {
                return true;
            }

            if (this.GetType() != right.GetType())///on regarde si ils sont du meme type.
            {
                return false;
            }

            return this.Equals(right as Galaxie);
        }
    }
}
