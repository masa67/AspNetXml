﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VWxml;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Test test = new Test();

            test.generateXml();
        }
    }
}
