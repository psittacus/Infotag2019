using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Infotag.Tests
{
    [TestClass]
    public class RechnerTests
    {
        [TestMethod]
        public void AddierenEingabe10Erwartet11()
        {
            //Arrange - Anordnen
            int prüfsumme = 11;

            //Act - Ausführen
            int summe = Umrechner.Addieren(10);

            //Assert - Überprüfen
            Assert.AreEqual(prüfsumme, summe);


        }

        [TestMethod]
        public void UmrechnenEingabe1ErwartetI()
        {
            //Arrange - Anordnen
            string prüfziffer = "I";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(1);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);


        }
    }
}