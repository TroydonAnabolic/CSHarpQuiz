using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHarpQuizConsole
{
    public class QuestionAndAnswers
    {
        List<string> questionsList = new List<string>
        { 
            "What is C#?",
            "test2"
        };

        List<string> answesListCorrect = new List<string>
        {
            "C# is an object oriented, type sage, and managed language that is compiled ",
            "test2"
        };

        List<string> answesListIncorrect1 = new List<string>
        {
            "C# is an obje",
            "test2"
        };

        List<string> answesListIncorrect2 = new List<string>
        {
            "C# is an obje",
            "test2"
        };

        List<string> answesListIncorrect3 = new List<string>
        {
            "C# is an obje",
            "test2"
        };


        public void CalculateScore(List<string> argQuestions)
        {
            string myAnswer = string.Empty;

            for (int i = 0; i < argQuestions.Count; i++)
            {
                Console.WriteLine(argQuestions[i]);

                Console.ReadLine();
            }
            // Present the result (counter) to the user
        }

    }
}
