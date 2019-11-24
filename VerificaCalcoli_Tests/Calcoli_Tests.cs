using Microsoft.VisualStudio.TestTools.UnitTesting;
using VerificaCalcoli;

namespace VerificaCalcoli_Tests
{
    [TestClass]
    public class Calcoli_Tests
    {
        public object VerificaCalcoli { get; private set; }

        [TestMethod]
       public void Calcolo1_Tests()
            {
                bool r = VerificaCalcoli.Calcolo1();
                Assert.AreEqual(true, r);
            }
            [TestMethod]
        public void Calcolo2Test()
        {
            bool r = VerificaCalcoli.Calcolo2();
            Assert.AreEqual(true, r);
        }
    }
}

