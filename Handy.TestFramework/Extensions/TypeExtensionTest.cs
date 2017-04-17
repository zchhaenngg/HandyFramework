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
            var t1 = DateTime.MinValue;
            var t = DateTime.MinValue.ToUniversalTime();
            var t2 = DateTime.Parse("2017-09-12");
             var t3 = t2.ToUniversalTime();
            Assert.AreEqual(t1, t);
        }
    }
}
