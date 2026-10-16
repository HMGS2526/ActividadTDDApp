using ActividadTDDApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        public void CalcularFactorial_NumeroNegativo_DevuelveMenosUno()
        {
            Assert.AreEqual(-1L, Funciones.CalcularFactorial(-5));
        }

        [TestMethod]
        public void CalcularFactorial_Cero_DevuelveUno()
        {
            Assert.AreEqual(1L, Funciones.CalcularFactorial(0));
        }

        [TestMethod]
        public void CalcularFactorial_Uno_DevuelveUno()
        {
            Assert.AreEqual(1L, Funciones.CalcularFactorial(1));
        }

        [TestMethod]
        public void CalcularFactorial_Cinco_Devuelve120()
        {
            Assert.AreEqual(120L, Funciones.CalcularFactorial(5));
        }

        [TestMethod]
        public void CalcularFactorial_Diez_Devuelve3628800()
        {
            Assert.AreEqual(3628800L, Funciones.CalcularFactorial(10));
        }
    }
} 
