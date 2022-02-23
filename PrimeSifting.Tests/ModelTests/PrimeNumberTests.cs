using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifting;

namespace PrimeSifting.Tests 
{
  [TestClass]
  public class PrimeNumberTests
  {
    [TestMethod]
    public void CreateList_IsListThere_True()
    {
      PrimeNumber number = new PrimeNumber();
      Assert.AreEqual(List, number.CreateList(6));
    }
  }
}