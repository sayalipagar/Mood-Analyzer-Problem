using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string msg)
        {
            this.message = msg;
        }
        public string Analyser()
        {
            if (message == string.Empty)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MOOD, "Message is Empty");
            }
            try
            {
                if (message.Contains("SAD"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (MoodAnalysisException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MOOD, "Message is Null");
            }
        }
    }
    }
