using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    internal class MoodAnalyser
    {
        public void Analyser(string message)
        {
            if (message.Contains("Sad"))
                Console.WriteLine("SAD MOOD");
            else
                Console.WriteLine("HAPPY MOOD");
        }
    }
}
