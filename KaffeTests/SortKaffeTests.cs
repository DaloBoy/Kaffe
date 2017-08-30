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
    public class SortKaffeTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void prisTestformegetrabat20Kr()
        {
            //arrange
            var sortKaffe = new SortKaffe(20);

            //act
            int pris = sortKaffe.pris();
            //assert
            Assert.AreEqual(0,pris);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void prisTestformegetrabat21Kr()
        {
            //arrange
            var sortKaffe = new SortKaffe(21);

            //act
            int pris = sortKaffe.pris();

            //assert
            Assert.AreEqual(-1,pris);
        }
    }
}