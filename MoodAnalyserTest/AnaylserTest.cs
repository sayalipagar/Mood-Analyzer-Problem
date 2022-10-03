using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class MoodAnalyserTest
    {
        [TestMethod]
        public void GivenIAmInSadMessageInConstructor_ShouldReturnSad()
        {
            string message = "I am in Sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.Analyser();
            Assert.AreEqual(actual, "SAD");
        }
        [TestMethod]
        public void GivenIAmInHappyMessageInConstructor_ShouldReturnHappy()
        {
            string message = "I am in Happy Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.Analyser();
            Assert.AreEqual(actual, "HAPPY");
        }
        [TestMethod]
        public void GivenNullMessage_ShouldReturnHappy()
        {
            string message = "null";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string actual = moodAnalyser.Analyser();
            Assert.AreEqual(actual, "HAPPY");
        }
        [TestMethod]
        public void GivenNullMessage_WhenAnalyde_ShouldReturnHappy()
        {
            string message = "null";
            MoodAnalyser mood = new MoodAnalyser(message);
            try
            {
                string actual = mood.Analyser();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Null");
            }
        }
        [TestMethod]
        public void GivenEmptylMessage_WhenAnalyde_ShouldReturnHappy()
        {
            string message = "Empty";
            MoodAnalyser mood = new MoodAnalyser(message);
            try
            {
                string actual = mood.Analyser();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Empty");
            }
        }
        //TC 4.1- Given MoodAnalyser Class Name Should Return MoodAnalyser Object 

        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object actual = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblemStatement.MoodAnalyser", "MoodAnalyser");
            actual.Equals(obj);
        }
        //TC 4.2- Given Class Name When Improper Should Throw MoodAnalysisException

        [TestMethod]
        public void GivenImproperClassName_ShouldThrowMoodAnalysisException()
        {
            string actual = "Class Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblemStatement.MoodAnalyser", "MoodAnalyser");

            }
            catch (MoodAnalysisException exception)
            {
                Assert.AreEqual(actual, exception.Message);
            }
        }

        //TC 4.3  Given Improper Constructor should throw MoodAnalysisException

        [TestMethod]
        public void GivenImproperConstructor_ShouldThrowMoodAnalysisException()
        {
            string actual = "Class Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblemStatement.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalysisException exception)
            {
                Assert.AreEqual(actual, exception.Message);
            }
        }
    }
}
        

    
