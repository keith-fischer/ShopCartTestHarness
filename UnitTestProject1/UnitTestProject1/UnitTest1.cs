using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using GreatCall.ShoppingCart.Contracts.Services;
//using GreatCall.ShoppingCart.Contracts;
using Test.ShopCart;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Test.ShopCart.ShopCart SH = new Test.ShopCart.ShopCart();
            SH.QuickTest();
        }
    }
}
