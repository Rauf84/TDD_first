using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDFirst;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDDFirst.Tests
{
    [TestClass()]
    public class UserdataTests
    {
        Userdata userdata = new Userdata();

        [TestMethod()]
        public void IsPasswordOkTest()
        {
            bool actual = userdata.IsPasswordOk("rauf");
            //var expected = true;
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsPasswordOkTest2()
        {
            bool actual = userdata.IsPasswordOk("Rauf%12");
            //var expected = true;
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsPasswordOkTest3()
        {
            bool actual = userdata.IsPasswordOk("Rauf%12jskruhflsdfhjlserlkajsdflkbviiuadlkjasdkljasdhf");
            //var expected = true;
            Assert.IsTrue(actual);
        }
    }
}