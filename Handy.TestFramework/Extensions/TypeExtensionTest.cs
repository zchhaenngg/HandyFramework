using System;
using Handy.Framework.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Handy.TestFramework.Extensions
{
    [TestClass]
    public class TypeExtensionTest
    {
        [TestMethod]
        public void IsString()
        {
            var trueS = "dd";
            var falseB = false;
            Assert.IsTrue(trueS.GetType().IsString());
            Assert.IsFalse(falseB.GetType().IsString());
        }
    }
}
