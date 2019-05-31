using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace CentralitaTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListaDeLlamadasInstanciadas()
        {
            //arrange
            Centralita centralita = new Centralita();
            //act

            //assert
            Assert.IsNotNull(centralita.Llamadas);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void LlamadaLocalYaRealizadaArrojaExcepcion()
        {
            //arrange 
            Centralita centralita = new Centralita();
            Local llamada1 = new Local("1122", 13.4f, "1133", 2.6f);
            Local llamada2 = new Local("1122", 33.2f, "1133", 2.8f);
            //act
            centralita = centralita + llamada1;
            centralita = centralita + llamada2;
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void LlamadaProvincialExistenteFalla()
        {
            //arrange 
            Centralita centralita = new Centralita();
            Provincial llamada1 = new Provincial("1122", Provincial.Franja.Franja_1, 12.3f, "1155");
            Provincial llamada2 = new Provincial("1122", Provincial.Franja.Franja_2, 55.5f, "1155");
            //act
            centralita = centralita + llamada1;
            centralita = centralita + llamada2;
        }

        [TestMethod]
        public void LlamadasSonIguales()
        {
            //arrange
            Local l1 = new Local("1122", 17.4f, "1155", 12.5f);
            Local l2 = new Local("1122", 11.2f, "1155", 13.5f);

            Provincial p1 = new Provincial("3344", Provincial.Franja.Franja_3, 32.5f, "5544");
            Provincial p2 = new Provincial("3344", Provincial.Franja.Franja_1, 2.0f, "5544");

            // assert
            Assert.AreEqual(l1, l2);
            Assert.AreNotEqual(l1, p1);
            Assert.AreNotEqual(l1, p2);
            Assert.AreEqual(p1, p2);
            Assert.AreNotEqual(p1, l2);
            Assert.AreNotEqual(p2, l1);
        }
    }
}
