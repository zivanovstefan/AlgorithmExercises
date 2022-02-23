using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;

namespace LetterOccurenceCounter_DuplicateFilter_Test
{
    [TestClass]
    public class LetterOccurrenceCounterTest
    {
        [TestMethod]
        public void Count_LetterOccurenceCount_ReturnLetter()
        {
            //Arrange
            var userString = "aaaaa";
            var expectedResult = new LetterOccurrenceCounter().Count(userString);
            //Act
            var actualResult = new LetterOccurrenceCounter().Count(userString);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}