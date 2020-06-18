using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace michaelD {
    public struct StructRenseignements {
        private string strNom;
        private string strPrenom;
        private string strDateNaissance;

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
        public string Prenom { 
            get => strPrenom; 
            set => strPrenom = value; 
        }
        public string DateNaissance { 
            get => strDateNaissance; 
            set => strDateNaissance = value; 
        }
    }
}
