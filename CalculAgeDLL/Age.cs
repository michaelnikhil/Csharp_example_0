using System;
using System.Globalization;

namespace CalculAgeDLL {
    public static class Age {

        // methode qui parse la date et renvoie vrai/age is la date est ok, et renvoie faux/age=0 si la date n'est pas ok
        public static bool calculer_age(string str_naissance, out int age) {
            DateTime dateNaissance;
            
            if (!DateTime.TryParseExact(str_naissance,
                       "dd/MM/yyyy",
                       CultureInfo.InvariantCulture,
                       DateTimeStyles.None,
                       out dateNaissance)) {
                age = 0;
                return false;
            } else {
                //calcul de l'age
                TimeSpan dt_age = DateTime.Now - dateNaissance;
                age = (int)dt_age.TotalDays / 365;
                return true;
            }
        }
    }
}
