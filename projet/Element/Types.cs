using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text;

namespace Element
{
    [DataContract]
    public class Types : IEquatable<Types>
    {
        [DataMember]
        public string Nom
        {
            get;
            private set;
        }
        [DataMember]
        public string Description
        {
            get;
            private set;
        }
        [DataMember]
        public string Illustration
        {
            get;
            private set;
        }
        public Types(String nom, string description, string illustration)
        {
            Nom = nom;
            Description = description;
            Illustration = illustration;
        }


        public override string ToString()
        {
            return new StringBuilder().AppendFormat("Nom, Description, Illustration", Nom, Description, Illustration).ToString();
        }
        internal bool GetType(string v1, bool v2)
        {
            throw new NotImplementedException();
        }

        /*public override bool Equals(object right)
        {
            //check null
            if (object.ReferenceEquals(right, null))
            {
                return false;
            }

            if (object.ReferenceEquals(this, right))
            {
                return true;
            }

            if (this.GetType() != right.GetType())
            {
                return false;
            }

            return this.Equals(right as Types);
        }*/
        public bool Equals([AllowNull] Types other) => true;
    }
}
