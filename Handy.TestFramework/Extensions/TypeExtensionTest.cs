using System;
using Handy.Framework.Extensions;
using Handy.Framework.System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Handy.TestFramework.Extensions
{
    [TestClass]
    public class TypeExtensionTest
    {
        [TestMethod]
        public void TestChangeType()
        {
            {
                Convert.ChangeType(UTCTime.Now, typeof(string));
                Convert.ChangeType(UTCTime.Now, typeof(DateTime));
            }
            {
                Convert.ChangeType("123", typeof(int));
                Convert.ChangeType(123.55, typeof(int));
            }
            try
            {
                Convert.ChangeType("123.55", typeof(int));
                Assert.IsFalse(true);
            }
            catch (FormatException)
            {

            }
            try
            {
                Convert.ChangeType(123, typeof(int?));
                Assert.IsFalse(true);
            }
            catch (InvalidCastException)
            {

            }
        }
    }
}
