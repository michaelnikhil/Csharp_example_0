using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculAgeDLL;

namespace UnitTestCalculAge {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void CalculAge() {
            // Arrange
            string str_date = "01/01/2000";
            int actualAge;
            int expectedAge = DateTime.Now.Year - 2000;

            // Act
            Age.calculer_age(str_date, out actualAge);

            // Assert
            Assert.AreEqual(expectedAge, actualAge, 0.001, "L'age n'est pas calcule correctement");
        }
        [TestMethod]
        public void GestionFormat() {
            // la methode calculer_age renvoie Faux quand le format est incorrect
            // Arrange
            string str_date = "01/01/o";
            int age;
            bool actualResponse;

            // Act
            actualResponse=Age.calculer_age(str_date, out age);

            // Assert
            Assert.IsFalse(actualResponse, "La gestion du format est incorrecte");
        }
    }
}
