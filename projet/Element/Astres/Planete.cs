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
    public class Planete : Astre, IEquatable<Astre>
    {
        [DataMember]
        public String Vivable
        {
            get;
            set;
        }
        [DataMember]
        public int Age
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
        public Planete() : base()
        {
            Vivable = "?";
            Age = 0;
            Masse = 0;
        }


        public Planete(String nom, string taille, string distanceTA, string description, string illustration, TypeEnum typeAstre, string vivable, int age, int masse) : base(nom, taille, distanceTA, description, illustration, typeAstre)
        {
            Vivable = vivable;
            Age = age;
            Masse = masse;
        }
        public bool Equals([AllowNull] Planete other)/// on regarde si les deux astre on les meme attribut
        {
            return Masse == other.Masse && Age == other.Age && Vivable == other.Vivable;
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

            return this.Equals(right as Planete);
        }
    }
}
