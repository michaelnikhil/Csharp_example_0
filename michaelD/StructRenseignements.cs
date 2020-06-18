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

        //constructeur
        public StructRenseignements(string argNom, string argPrenom, string argDate) {
            strNom = argNom;
            strPrenom = argPrenom;
            strDateNaissance = argDate;
        }

        //get
        public string Nom() {
            return strNom;
        }
        public string Prenom() {
            return strPrenom;
        }
        public string DateNaissance() {
            return strDateNaissance;
        }
    }
}
