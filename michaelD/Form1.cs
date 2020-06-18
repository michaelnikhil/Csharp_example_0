using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculAgeDLL;

namespace michaelD {
    public partial class Form1 : Form {

        ////instanciation de l'objet globale, pour reutilisation dans les differentes methodes 
        ClassRenseignements objRensC;
        StructRenseignements objRensS;

        public Form1() {
            InitializeComponent();
        }

        private void CollecteInfos(object sender, EventArgs e) {

            //collecte des infos dans la class renseignements
            objRensC = new ClassRenseignements(this.textNom.Text, this.textPrenom.Text, this.textNaissance.Text);

            //collecte des infos dans la struct renseignements
            objRensS = new StructRenseignements(this.textNom.Text, this.textPrenom.Text, this.textNaissance.Text);

            butAffichInfos.Enabled = true;
        }

        private void AffichageInfos(object sender, EventArgs e) {

            string nom;   //lecture du nom
            string prenom; //lecture du prenom
            string str_naissance; //lecture de la date de naissance en string
            string source;

            //choix de l'origine des infos en fonction de la checkbox

            if (lectureDepuisStruct.Checked) {
                nom = objRensS.Nom();
                prenom = objRensS.Prenom();
                str_naissance = objRensS.DateNaissance();
                source = "StructRenseigments";

            } else {
                nom = objRensC.Nom();
                prenom = objRensC.Prenom();
                str_naissance = objRensC.DateNaissance();
                source = "ClassRenseigments";
            }

            //appel de la DLL
            int age;

            if (!Age.calculer_age(str_naissance, out age)) {
                MessageBox.Show("Format de la date de naissance : " +
                        "jj/mm/yyyy", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                string reponse = "Bonjour " + prenom + " " + nom + "\n" +
                "vous avez " + age.ToString() + " ans" + "\n"
                + "source : " + source;
                MessageBox.Show(reponse);
            }
            butAffichInfos.Enabled = false;

        }

    }
}
