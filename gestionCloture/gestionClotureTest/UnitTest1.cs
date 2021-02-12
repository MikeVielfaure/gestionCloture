using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gestionCloture;

namespace gestionClotureTest
{
  [TestClass]
  public class UnitTest1
  {
    // test getMoisPrecedent()
    [TestMethod]
    public void TestMethod1()
    {
      Assert.AreEqual(GestionDate.getMoisPrecedent(), "01");
    }

    // test getMoisPrecedent(DateTime la date)
    [TestMethod]
    public void TestMethod2()
    {
      DateTime laDate = DateTime.Today;
      Assert.AreEqual(GestionDate.getMoisPrecedent(laDate), "01");
    }

    // test getMoisSuivant()
    [TestMethod]
    public void TestMethod3()
    {
      Assert.AreEqual(GestionDate.getMoisSuivant(), "03");
    }

    // test getMoisSuivant()
    [TestMethod]
    public void TestMethod4()
    {
      DateTime laDate = DateTime.Today;
      Assert.AreEqual(GestionDate.getMoisSuivant(laDate), "03");
    }

    // test entre(int jour1, int jour2)
    [TestMethod]
    public void TestMethod5()
    {
      Assert.IsTrue(GestionDate.entre(5, 15));
    }

    // test entre(int jour1, int jour2? DateTime laDate)
    [TestMethod]
    public void TestMethod6()
    {
      DateTime laDate = DateTime.Today;
      int leJour = laDate.Day;
      Assert.IsTrue(GestionDate.entre(5, 15));
    }
  }
}
