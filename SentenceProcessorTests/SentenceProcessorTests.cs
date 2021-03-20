using CodingExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SentenceProcessorTests
{
    [TestClass]
    public class SentenceProcessorTests
    {
        SentenceProcessor sut = new SentenceProcessor();

        [TestMethod]
        public void ProcessSentence_BlankInput_ReturnsBlankString()
        {
            string input = "";
            string expectedOutput = "";

            var output = sut.ProcessSentence(input);
            Assert.AreEqual(expectedOutput, output);
        }
        [TestMethod]
        public void ProcessSentence_GoodInput_ReturnsCorrectString()
        {
            string input = "This is a test!";
            string expectedOutput = "T2s i0s a t2t!";

            var output = sut.ProcessSentence(input);
            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void ProcessSentence_NoWords_ReturnsGivenString()
        {
            string input = "143!@#%!23451@#5";
            string expectedOutput = "143!@#%!23451@#5";

            var output = sut.ProcessSentence(input);
            Assert.AreEqual(expectedOutput, output);
        }
    }
}
