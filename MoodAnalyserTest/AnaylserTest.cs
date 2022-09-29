using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class AnaylserTest
    {
        [TestMethod]
        public void GivenIAmInSadMoodUsingConstructor_ShouldReturnSad()
        {
            string message = "I am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string actual = moodAnalyser.Analyser(message);
            Assert.AreEqual(actual, "SAD");
        }
        [TestMethod]
        public void GivenIAmInHappyMoodUsingConstructor_ShouldReturnHappy()
        {
            string message = "I am in Happy Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string actual = moodAnalyser.Analyser(message);
            Assert.AreEqual(actual, "HAPPY");
        }
    }
}