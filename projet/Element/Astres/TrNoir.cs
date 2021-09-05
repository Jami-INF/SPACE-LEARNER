using System;
using Element;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.Text;
using Modele;
using System.Runtime.Serialization;

namespace Element
{
    [DataContract]
    public class TrNoir : Astre, IEquatable<Astre>
    {
        [DataMember]
        public string Type
        {
            get;
            set;
        }
        public TrNoir()
        {
            Type = "inconnu";
            TypeAstre = TypeEnum.Trou_Noir;
        }

        public TrNoir(String nom, string taille, string distanceTA, string description, string illustration, TypeEnum typeAstre, string type) : base(nom, taille, distanceTA, description, illustration, typeAstre)
        {

            Type = type;
        }
        public bool Equals([AllowNull] TrNoir other)/// on regarde si les deux astre on les meme attribut
        {
            return Type.Equals(other.Type);
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

            return this.Equals(right as TrNoir);
        }
        public override int GetHashCode()///retourne le code de hachage de l'objet
        {
            return base.GetHashCode();
        }
    }
}
