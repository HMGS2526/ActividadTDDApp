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
        [TestMethod]
        public void EsContrasenyaValida_Null_DevuelveFalse()
        {
            Assert.IsFalse(Funciones.EsContrasenyaValida(null));
        }

        [TestMethod]
        public void EsContrasenyaValida_Vacia_DevuelveFalse()
        {
            Assert.IsFalse(Funciones.EsContrasenyaValida(""));
        }

        [TestMethod]
        public void EsContrasenyaValida_MenosDe8Caracteres_DevuelveFalse()
        {
            Assert.IsFalse(Funciones.EsContrasenyaValida("abc#123"));
        }

        [TestMethod]
        public void EsContrasenyaValida_SinAlmohadilla_DevuelveFalse()
        {
            Assert.IsFalse(Funciones.EsContrasenyaValida("abcdefgh123"));
        }

        [TestMethod]
        public void EsContrasenyaValida_Exactamente8ConAlmohadilla_DevuelveTrue()
        {
            Assert.IsTrue(Funciones.EsContrasenyaValida("abcdef#1"));
        }

        [TestMethod]
        public void EsContrasenyaValida_LargaConAlmohadilla_DevuelveTrue()
        {
            Assert.IsTrue(Funciones.EsContrasenyaValida("MiClave#Segura2026"));
        }
    }

} 
