using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskOne;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const bool CheckTrue = true; 
        private const bool CheckFalse = false;
        private СheckNumber t = new СheckNumber();
        [TestMethod]
        public void RepLettersAndNumbersUpReg()
        {
            //arrange
            string test = "00XX00XX-00X";
            //act
            bool actual = t.Check(test);
            //assert
            Assert.AreEqual(CheckTrue, actual);
        }
        [TestMethod]
        public void RepLettersAndNumbersDownReg()
        {
            //arrange
            string test = "11aa11aa-11a";
            //act
            bool actual = t.Check(test);
            //assert
            Assert.AreEqual(CheckTrue, actual);
        }
        [TestMethod]
        public void AlternatingReg()
        {
            //arrange
            string test = "78AD44bv-12C";
            //act
            bool actual = t.Check(test);
            //assert
            Assert.AreEqual(CheckTrue, actual);
        }
        [TestMethod]
        public void DownReg()
        { 
            //arrange
            string test = "92fa12zs-99a";
            //act
            bool actual = t.Check(test);
            //assert
            Assert.AreEqual(CheckTrue, actual);
        }
        [TestMethod]
        public void UpReg()
        {
            //arrange
            string test = "53AS65MB-50T";
            //act
            bool actual = t.Check(test);
            //assert
            Assert.AreEqual(CheckTrue, actual);
        }
        [TestMethod]
        public void RepLettersUpReg()
        {
            //arrange
            string test = "02AA13AA-46A";
            //act
            bool actual = t.Check(test);
            //assert
            Assert.AreEqual(CheckTrue, actual);
        }
        [TestMethod]
        public void RepLettersDownReg()
        {
            //arrange
            string test = "41aa32aa-23a";
            //act
            bool actual = t.Check(test);
            //assert
            Assert.AreEqual(CheckTrue, actual);
        }
        [TestMethod]
        public void RepNumbersDownReg()
        {
            //arrange
            string test = "88as88bf-88a";
            //act
            bool actual = t.Check(test);
            //assert
            Assert.AreEqual(CheckTrue, actual);
        }
        [TestMethod]
        public void RepNumbersUpReg()
        {
            //arrange
            string test = "77DV77BD-77A";
            //act
            bool actual = t.Check(test);
            //assert
            Assert.AreEqual(CheckTrue, actual);
        }
        [TestMethod]
        public void RepAlternatingGroupLetters()
        {
            //arrange
            string test = "12xx34XX-56x";
            //act
            bool actual = t.Check(test);
            //assert
            Assert.AreEqual(CheckTrue, actual);
        }
        [TestMethod]
        public void RepGroupLettersAndNumbers()
        {
            //arrange
            string test = "32AB32AB-32A";
            //act
            bool actual = t.Check(test);
            //assert
            Assert.AreEqual(CheckTrue, actual);
        }
        //7 тестов с проверкой false
        [TestMethod]
        public void MissingLastLetter()
        {
            //arrange
            string test = "32AB32AB-32";
            //act
            bool actual = t.Check(test);
            //assert
            Assert.AreEqual(CheckFalse, actual);
        }
        [TestMethod]
        public void MissingFirstNumeral()
        {
            //arrange
            string test = "2AB32AB-32A";
            //act
            bool actual = t.Check(test);
            //assert
            Assert.AreEqual(CheckFalse, actual);
        }

        [TestMethod]
        public void MissingFirstLetter()
        {
            //arrange
            string test = "32B32AB-32A";
            //act
            bool actual = t.Check(test);
            //assert
            Assert.AreEqual(CheckFalse, actual);
        }
        [TestMethod]
        public void MissingAverageNumeral()
        { 
            //arrange
            string test = "32AB3AB-32A";
            //act
            bool actual = t.Check(test);
            //assert
            Assert.AreEqual(CheckFalse, actual);
        }
        [TestMethod]
        public void MissingLastNumeral()
        {
            //arrange
            string test = "32AB32AB-3A";
            //act
            bool actual = t.Check(test);
            //assert
            Assert.AreEqual(CheckFalse, actual);
        }
        [TestMethod]
        public void MissingSign()
        {
            //arrange
            string test = "32AB32AB32A";
            //act
            bool actual = t.Check(test);
            //assert
            Assert.AreEqual(CheckFalse, actual);
        }
        [TestMethod]
        public void SwapGroupsNumbersAndLetters()
        {
            //arrange
            string test = "AB32AB32-AB2";
            //act
            bool actual = t.Check(test);
            //assert
            Assert.AreEqual(CheckFalse, actual);
        }
    }
}
