using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyAlgorithms;

namespace MyAlgorithmsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var sut = new Reversed();

            //Act
            var expected = sut.ReversedWord("hello");
            var actual = "olleh";

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
