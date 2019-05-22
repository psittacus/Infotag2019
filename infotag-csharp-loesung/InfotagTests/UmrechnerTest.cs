using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Infotag.Tests
{
    [TestClass]
    public class RechnerTests_GanzeZahlen
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

        [TestMethod]
        public void UmrechnenEingabe5ErwartetV()
        {
            //Arrange - Anordnen
            string prüfziffer = "V";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(5);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);


        }

        [TestMethod]
        public void UmrechnenEingabe10ErwartetX()
        {
            //Arrange - Anordnen
            string prüfziffer = "X";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(10);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);


        }

        [TestMethod]
        public void UmrechnenEingabe50ErwartetL()
        {
            //Arrange - Anordnen
            string prüfziffer = "L";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(50);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);


        }

        [TestMethod]
        public void UmrechnenEingabe100ErwartetC()
        {
            //Arrange - Anordnen
            string prüfziffer = "C";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(100);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);


        }

        [TestMethod]
        public void UmrechnenEingabe500ErwartetD()
        {
            //Arrange - Anordnen
            string prüfziffer = "D";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(500);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);


        }

        [TestMethod]
        public void UmrechnenEingabe1000ErwartetM()
        {
            //Arrange - Anordnen
            string prüfziffer = "M";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(1000);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);


        }
    }

    [TestClass]
    public class RechnerTests_EinesGroesser
    {

        [TestMethod]
        public void UmrechnenEingabe2ErwartetII()
        {
            //Arrange - Anordnen
            string prüfziffer = "II";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(2);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);


        }

        [TestMethod]
        public void UmrechnenEingabe6ErwartetVI()
        {
            //Arrange - Anordnen
            string prüfziffer = "VI";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(6);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);


        }

        [TestMethod]
        public void UmrechnenEingabe11ErwartetXI()
        {
            //Arrange - Anordnen
            string prüfziffer = "XI";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(11);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);
        }

        [TestMethod]
        public void UmrechnenEingabe51ErwartetLI()
        {
            //Arrange - Anordnen
            string prüfziffer = "LI";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(51);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);
        }

        [TestMethod]
        public void UmrechnenEingabe101ErwartetCI()
        {
            //Arrange - Anordnen
            string prüfziffer = "CI";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(101);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);
        }

        [TestMethod]
        public void UmrechnenEingabe501ErwartetDI()
        {
            //Arrange - Anordnen
            string prüfziffer = "DI";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(501);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);
        }

        [TestMethod]
        public void UmrechnenEingabe1001ErwartetMI()
        {
            //Arrange - Anordnen
            string prüfziffer = "MI";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(1001);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);
        }
    }

    [TestClass]
    public class RechnerTests_EinesKleiner
    {

        [TestMethod]
        public void UmrechnenEingabe4ErwartetIV()
        {
            //Arrange - Anordnen
            string prüfziffer = "IV";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(4);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);


        }

        [TestMethod]
        public void UmrechnenEingabe9ErwartetIX()
        {
            //Arrange - Anordnen
            string prüfziffer = "IX";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(9);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);


        }

        [TestMethod]
        public void UmrechnenEingabe49ErwartetXLIX()
        {
            //Arrange - Anordnen
            string prüfziffer = "XLIX";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(49);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);
        }

        [TestMethod]
        public void UmrechnenEingabe99ErwartetXCIX()
        {
            //Arrange - Anordnen
            string prüfziffer = "XCIX";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(99);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);
        }

        [TestMethod]
        public void UmrechnenEingabe499ErwartetCDXCIX()
        {
            //Arrange - Anordnen
            string prüfziffer = "CDXCIX";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(499);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);
        }

        [TestMethod]
        public void UmrechnenEingabe999ErwartetCMXCIX()
        {
            //Arrange - Anordnen
            string prüfziffer = "CMXCIX";

            //Act - Ausführen
            string ergebnis = Umrechner.Umrechnen(999);

            //Assert - Überprüfen
            Assert.AreEqual(prüfziffer, ergebnis);
        }
    }
}