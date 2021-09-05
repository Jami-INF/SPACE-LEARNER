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
    public class SysSol : Astre, IEquatable<Astre>
    {

        [DataMember]
        public int Nbplanete
        {
            get;
            set;
        }
        [DataMember]
        public int NbSoleil
        {
            get;
            set;
        }
        public SysSol()
        {
            Nbplanete = 0;
            NbSoleil = 0;
            TypeAstre = TypeEnum.Système_solaire;
        }
        public SysSol(String nom, string taille, string distanceTA, string description, string illustration, TypeEnum typeAstre, int nbplanete, int nbSoleil) : base(nom, taille, distanceTA, description, illustration, typeAstre)
        {

            Nbplanete = nbplanete;
            NbSoleil = nbSoleil;
        }
        public bool Equals([AllowNull] SysSol other)/// on regarde si les deux astre on les meme attribut
        {
            return Nbplanete == other.Nbplanete && NbSoleil == other.NbSoleil;
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

            return this.Equals(right as SysSol);
        }
        public override int GetHashCode()///retourne le code de hachage de l'objet
        {
            return base.GetHashCode();
        }
    }
}