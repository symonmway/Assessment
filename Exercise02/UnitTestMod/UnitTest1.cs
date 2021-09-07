using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise01;

namespace UnitTestMod
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInteger()
        {
            //Arrang
            string words;
            string number = "238663702";
            //Act
            words=Towords.NumWords(long.Parse(number));

            //Assert
                Assert.AreEqual(words,"two hundred and thirty eight million, six hundred and sixty three thousand seven hundred and two");
               
        }
    }
}
