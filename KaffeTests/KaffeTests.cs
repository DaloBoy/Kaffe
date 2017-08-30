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
    public class KaffeTests
    {
        [TestMethod()]
        public void prisTestKaffe()
        {
            //arrange
            var kaffe = new SortKaffe();            
            //act
            int pris = kaffe.pris();
            //assert
            Assert.AreEqual(20, pris);
        }

        [TestMethod()]
        public void styrkeTestKaffe()
        {
            //arrange
            var kaffe = new SortKaffe();
            //act
            string styrke = kaffe.styrke();
            //assert
            Assert.AreEqual("Stærk", styrke);
        }
    }
}