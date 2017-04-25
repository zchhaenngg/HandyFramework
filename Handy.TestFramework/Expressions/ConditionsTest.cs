using System;
using System.Collections.Generic;
using Handy.Framework.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Handy.TestFramework.Expressions
{
    [TestClass]
    public class ConditionsTest
    {
        [TestMethod]
        public void TestIsEmpty()
        {
            {
                HashSet<Tuple<string, string>> set = null;
                Assert.IsTrue(Conditions.IsEmpty(set));

                set = new HashSet<Tuple<string,string>>();
                Assert.IsTrue(Conditions.IsEmpty(set));

                set.Add(new Tuple<string, string>("a", "aa"));
                Assert.IsTrue(Conditions.IsNotEmpty(set));

                string str = string.Empty;
                Assert.IsTrue(Conditions.IsEmpty(str));

                str = "aa";
                Assert.IsTrue(Conditions.IsNotEmpty(str));
            }
        }
    }
}
