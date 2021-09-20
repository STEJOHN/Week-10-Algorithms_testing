
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAlgorithms;

namespace MyAlgorithmsTests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var sut = new VerifyDouble();
            int[] vs  = { 25, 1, 7, 11 };

            //Act
            var expected = false;
            var actual = sut.VerifyIfDouble(vs);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}