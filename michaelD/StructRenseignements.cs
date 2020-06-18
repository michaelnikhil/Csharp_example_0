using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace michaelD {
    public struct StructRenseignements {
        private string strNom;
        public string Prenom;
        public string DateNaissance;

        ////propriete pour faire une verification sur le set
        public string Nom { 
            get => strNom;
            //code de verification
            set { 
                if (!value.StartsWith("X")) {
                    strNom = value;
                } else {
                    strNom = "invalid name";
                }
            } 
        }
    }
}
