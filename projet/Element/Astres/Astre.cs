using Modele;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Element
{
    [DataContract]
    [KnownType(typeof(Etoile))]
    [KnownType(typeof(Galaxie))]
    [KnownType(typeof(Planete))]
    [KnownType(typeof(Satellite))]
    [KnownType(typeof(SysSol))]
    [KnownType(typeof(TrNoir))]
    public abstract class Astre : IEquatable<Astre>, INotifyPropertyChanged///on se sert de iequatable pour comprarer des astre en eux dans la suppression. INotifyPropertyChanged est utilisé pour l'attribut illustration
    {
        [DataMember]
        public string Nom
        {
            get;
            set;
        }
        [DataMember]
        public string Taille
        {
            get;
            set;
        }
        [DataMember]
        public string DistanceTA
        {
            get;
            set;
        }
        [DataMember]

        public string Description
        {
            get;
            set;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        [DataMember]

        private string illustration;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Illustration
        {
            get { return illustration; }
            set
            {
                if (illustration != value)
                {
                    illustration = value;
                    OnPropertyChanged(nameof(Illustration));///Illustration peut changer dans les ajout et les modicattion
                }///on doit donc utilisé INotifyPropertyChanged pour prévenir que Illustration change et ainsi mettre a jour le binding
            }
        }
        [DataMember]

        public TypeEnum TypeAstre
        {
            get;
            set;
        }


        public Astre(String nom, string taille, string distanceTA, string description, string illustration, TypeEnum typeAstre)
        {///ce contructeur sert a créé un astre avec tout les attribut qui sont donné.
            Nom = nom;
            Taille = taille;
            DistanceTA = distanceTA;
            Description = description;
            Illustration = illustration;
            TypeAstre = typeAstre;

        }
        public Astre()///ce constructeur sert a créé un astre par default
        {
            Nom = "aucun nom";
            Taille = "0";
            DistanceTA = "0";
            Description = "aucune";
            Illustration = "illastre.jpg";
            TypeAstre = TypeEnum.Planete;

        }

        internal bool GetType(string v1, bool v2)
        {
            throw new NotImplementedException();
        }
        

        public override string ToString()
        {
            return new StringBuilder().AppendFormat(" Nom, Taille, DistanceTA, Description, Illustration", Nom, Taille, DistanceTA, Description, Illustration).ToString();
        }


        public override bool Equals(object right)
        {
            //check null
            if (right is null)///test si l'objet est null
            {
                return false;
            }

            if (object.ReferenceEquals(this, right))///test si ils ont la meme référence
            {
                return true;
            }

            if (this.GetType() != right.GetType())///test le type
            {
                return false;
            }

            return this.Equals(right as Astre);
        }
        public bool Equals([AllowNull] Astre other)///on regarde si ils ont les memes attributs. si c'est le cas on return true
        {
            return Nom.Equals(other.Nom) && Description.Equals(other.Description) && Taille.Equals(other.Taille) && TypeAstre.Equals(other.TypeAstre);
        }


        public static Astre AstrRandom(List <Astre> astres) ///retourne un astre aléatoire si la liste n'est pas vide
        {
            Random rnd = new Random();
            int index = rnd.Next(astres.Count);
            if (index >= 0)
            {
                return astres[index];
            }
            else
            {
                return null;
            }

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
