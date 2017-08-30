using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffe.Tests
{
    [TestClass()]
    public class LatteTests
    {
        [TestMethod()]
        public void prisTest()
        {
            //arrange
            var latte = new Latte();

            //act
            int pris = latte.pris();

            //assert
            Assert.AreEqual(30, pris);
        }
    }
}