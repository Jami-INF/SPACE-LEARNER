using Element;
using Modele;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text;

namespace Element
{
    [DataContract]
    public class Etoile : Astre, IEquatable<Astre>
    {
        [DataMember]
        public int Luminiosite
        {
            get;
            set;
        }
        [DataMember]
        public int Masse
        {
            get;
            set;
        }
        public Etoile()
        {
            Luminiosite = 0;
            Masse = 0;
            TypeAstre = TypeEnum.Etoile;
        }

        public Etoile(String nom, string taille, string distanceTA, string description, string illustration, TypeEnum typeAstre, int masse, int luminiosite) : base(nom, taille, distanceTA, description, illustration, typeAstre)
        {

            Luminiosite = luminiosite;
            Masse = masse;
        }
        public bool Equals([AllowNull] Etoile other)/// on regarde si les deux astre on les meme attribut
        {
            return Luminiosite == other.Luminiosite && Masse == other.Masse;
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

            return this.Equals(right as Etoile);
        }
    }

    
}
