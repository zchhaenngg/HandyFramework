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
        public void Test()
        {
            var a = Convert.ChangeType("5", typeof(short));
            var b = Convert.ChangeType(UTCTime.Now, typeof(DateTime));
            var c = Convert.ChangeType(UTCTime.Now, typeof(string));

            var a132 = Convert.ChangeType("132", typeof(int));
        }
    }
}
