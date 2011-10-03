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
        public void SeTesesouraETesouraResultadoEEmpate()
        {
            String resultado = jokenpo.Jogar("tesoura", "tesoura");
            Assert.AreEqual("empate", resultado);
        }
    }
}
