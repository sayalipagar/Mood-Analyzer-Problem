using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class AnaylserTest
    {
        [TestMethod]
        public void GivenIAmInSadMood_ShouldReturnSad()
        {
            string message = "I am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string actual = moodAnalyser.Analyser(message);
            Assert.AreEqual(actual, "SAD");
        }
        [TestMethod]
        public void GivenIAmInAnyMood_ShouldReturnHappy()
        {
            string message = "I am in Any Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string actual = moodAnalyser.Analyser(message);
            Assert.AreEqual(actual, "HAPPY");
        }
    }
}