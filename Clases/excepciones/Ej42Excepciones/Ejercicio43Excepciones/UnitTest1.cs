using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej42;

namespace Ejercicio43Excepciones
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ConstructorMiClase()
        {
            MiClase miClase = new MiClase();
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion), "esta es UnaExcepcion")]
        public void ConstructorMiClaseConParametros()
        {
            MiClase miClase = new MiClase(1);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void MetodoEstaticoDeMiClase()
        {
            MiClase.MiMetodoEstatico();
        }

        [TestMethod]
        [ExpectedException(typeof(MiException), "esta es MiException de mi otra clase")]
        public void MetodoDeInstanciaDeMiOtraClase()
        {
            MiOtraClase miOtraClase = new MiOtraClase();
            miOtraClase.MiMetodoDeInstancia();
        }
        
    }
}
