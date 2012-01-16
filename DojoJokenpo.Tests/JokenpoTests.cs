using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DojoJokenpo;

namespace DojoJokenpo.Tests
{
    [TestClass]
    public class JokenpoTests
    {
        Jokenpo jokenpo = new Jokenpo();

        [TestMethod]
        public void TestaSeAClasseJokenpoExiste()
        {
            Assert.IsNotNull(jokenpo);
        }

        [TestMethod]
        public void SeTesouraETesouraResultadoEEmpate()
        {
            String resultado = jokenpo.Jogar("tesoura", "tesoura");
            Assert.AreEqual("empate", resultado);
        }

        [TestMethod]
        public void SeTesouraEPedraResultadoEPedra()
        {
            String resultado = jokenpo.Jogar("tesoura", "pedra");
            Assert.AreEqual("pedra", resultado);
        }

        [TestMethod]
        public void SeTesouraEPapelResultadoETesoura()
        {
            String resultado = jokenpo.Jogar("tesoura", "papel");
            Assert.AreEqual("tesoura", resultado);
        }

        [TestMethod]
        public void SePedraEPapelResultadoEPapel()
        {
            String resultado = jokenpo.Jogar("pedra", "papel");
            Assert.AreEqual("papel", resultado);
        }

        [TestMethod]
        public void SePapelEPedraResultadoEPapel()
        {
            String resultado = jokenpo.Jogar("papel", "pedra");
            Assert.AreEqual("papel", resultado);
        }
    }
}
