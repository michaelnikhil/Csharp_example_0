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
        public Form1() {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e) {
            //lecture du nom et prenom
            string nom = textNom.Text;
            string prenom = textPrenom.Text;

            //lecture de la date de naissance en string
            string str_naissance = textNaissance.Text;

            //appel de la DLL
            int age;
            
            if (!  Age.calculer_age(str_naissance, out age)){
                MessageBox.Show("Format de la date de naissance : " +
                        "jj/mm/yyyy","Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                string reponse = "Bonjour " + prenom + " " + nom + "\n" +
                "vous avez " + age.ToString() + " ans";
                MessageBox.Show(reponse);
            }
        }
    }
}
