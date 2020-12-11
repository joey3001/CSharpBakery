using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadOrderTests
  {
    [TestMethod]
    public void BreadOrder_CreateInstanceOfBreadOrder_BreadOrder()
    {
      BreadOrder newBreadOrder = new BreadOrder(1);
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }

    [TestMethod]
    public void BreadOrder_ProvideInputForNumberOfLoafs_2()
    {
      BreadOrder newBreadOrder = new BreadOrder(2);
      Assert.AreEqual(2, newBreadOrder.NumberOfLoafs);
    }
  }
}