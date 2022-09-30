using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string msg)
        {
            this.message = msg;
        }
        public string Analyser()
        {
            try
            {
                if (this.message.Contains("Sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException ex)
            {
                return "Happy";
            }
        }
    }
    }
