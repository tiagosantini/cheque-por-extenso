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
        public void DeveExibirUnidadeReal()
        {
            Assert.AreEqual("Dois reais e vinte e cinco centavos",
                Humanizador.EscreverPorExtenso(2.25m));
        }

        [TestMethod]
        public void DeveExibirDezenaReal()
        {
            Assert.AreEqual("Trinta e sete reais",
                Humanizador.EscreverPorExtenso(37.00m));
        }

        [TestMethod]
        public void DeveExibirCentenaReal()
        {
            Assert.AreEqual("Seiscentos e trinta e sete reais",
                Humanizador.EscreverPorExtenso(637.00m));
        }

        [TestMethod]
        public void DeveExibirUnidadeMilharReal()
        {
            Assert.AreEqual("Um mil seiscentos e trinta e sete reais",
                Humanizador.EscreverPorExtenso(1637.00m));
        }

        [TestMethod]
        public void DeveExibirDezenaMilharReal()
        {
            Assert.AreEqual("Quinze mil quatrocentos e quinze reais e dezesseis centavos",
                Humanizador.EscreverPorExtenso(15415.16m));
        }

        [TestMethod]
        public void DeveExibirCentenaMilharReal()
        {
            Assert.AreEqual("Novecentos e sessenta e um mil seiscentos e trinta e sete reais",
                Humanizador.EscreverPorExtenso(961637.00m));
        }

        [TestMethod]
        public void DeveExibirUnidadeMilhaoReal()
        {
            Assert.AreEqual("Um milhão oitocentos e cinquenta e dois mil setecentos reais",
                Humanizador.EscreverPorExtenso(1852700.00m));
        }

        [TestMethod]
        public void DeveExibirUnidadeMilhaoRealPlural()
        {
            Assert.AreEqual("Cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais",
                Humanizador.EscreverPorExtenso(5961637.00m));
        }

        [TestMethod]
        public void DeveExibirDezenaMilhaoReal()
        {
            Assert.AreEqual("Vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais",
                Humanizador.EscreverPorExtenso(25961637.00m));
        }

        [TestMethod]
        public void DeveExibirCentenaMilhaoReal()
        {
            Assert.AreEqual("Quatrocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais",
                Humanizador.EscreverPorExtenso(425961637.00m));
        }

        [TestMethod]
        public void DeveExibirUnidadeBilhaoReal()
        {
            Assert.AreEqual("Oito bilhões quatrocentos e vinte e cinco milhões novecentos" +
                " e sessenta e um mil seiscentos e trinta e sete reais",
                Humanizador.EscreverPorExtenso(8425961637.00m));
        }
    }
}
