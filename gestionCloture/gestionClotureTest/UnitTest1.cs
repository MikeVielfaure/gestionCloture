using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gestionCloture;

namespace gestionClotureTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
          Assert.AreEqual(GestionDate.getMoisPrecedent(), "01");
        }

         [TestMethod]
        public void TestMethod2()
        {
          DateTime laDate = DateTime.Today;
          Assert.AreEqual(GestionDate.getMoisPrecedent(laDate), "01");
        }
  }
}
