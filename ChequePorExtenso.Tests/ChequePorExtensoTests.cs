using ChequePorExtenso.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChequePorExtenso.Tests
{
    [TestClass]
    public class ChequePorExtensoTests
    {
        [TestMethod]
        public void DeveExibirUnidadeCentavo()
        {
            Assert.AreEqual("Cinco centavos de real", Humanizador.EscreverPorExtenso(0.05m));
        }

        [TestMethod]
        public void DeveExibirDezenaCentavo()
        {
            Assert.AreEqual("Dez centavos de real", Humanizador.EscreverPorExtenso(0.10m));
        }

        [TestMethod]
        public void DeveExibirUnidadeReal()
        {
            Assert.AreEqual("Um real", Humanizador.EscreverPorExtenso(1.00m));
        }

        [TestMethod]
        public void DeveExibirUnidadeRealPlural()
        {
            Assert.AreEqual("Dois reais", Humanizador.EscreverPorExtenso(2.00m));
        }

        [TestMethod]
        public void DeveExibirDezenaReal()
        {
            Assert.AreEqual("Vinte e cinco reais", Humanizador.EscreverPorExtenso(25.0m));
        }

        [TestMethod]
        public void DeveExibirCentenaReal()
        {
            Assert.AreEqual("Cento e vinte e cinco reais e vinte centavos", Humanizador.EscreverPorExtenso(125.20m));
        }

        [TestMethod]
        public void DeveExibirMilharReal()
        {
            Assert.AreEqual("Vinte mil e quinhentos reais", Humanizador.EscreverPorExtenso(20500m));
        }
    }
}
