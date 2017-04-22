﻿using System;
using Handy.Framework.System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Handy.TestFramework.System
{
    [TestClass]
    public class HandyConvertTest
    {
        [TestMethod]
        public void TestConvertTo()
        {
            {
                try
                {
                    HandyConvert.ConvertTo<int>(null);
                    Assert.IsFalse(true);
                }
                catch (InvalidCastException)
                {

                }
            }
            {
                HandyConvert.ConvertTo<int>("32");
                HandyConvert.ConvertTo<int>(32.5);
                HandyConvert.ConvertTo<int?>(32.5);
                Assert.IsTrue(HandyConvert.ConvertTo<bool>(123));
                Assert.IsTrue(HandyConvert.ConvertTo<bool>(-123));
                Assert.IsFalse(HandyConvert.ConvertTo<bool>(0));
            }
            {
                try
                {
                    HandyConvert.ConvertTo<bool>("1");
                    Assert.IsFalse(true);
                }
                catch (FormatException)
                {

                }
            }
        }

        [TestMethod]
        public void TestToList()
        {
            Assert.IsNull(HandyConvert.ToList<string>(null));
            Assert.IsTrue(HandyConvert.ToList<string>(new string[] { "", "dd" }).Count == 2);
            Assert.IsTrue(HandyConvert.ToList<int>(new string[] { "456", "123" }).Count == 2);
        }
    }
}
