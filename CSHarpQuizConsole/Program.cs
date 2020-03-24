using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHarpQuizConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CSharpQuestionAndAnswer cSharpQuestionAndAnswer = new CSharpQuestionAndAnswer();
            CalculationEngine calculation = new CalculationEngine();

            // apply calculations
            calculation.CalculateScore(cSharpQuestionAndAnswer.questionsList, cSharpQuestionAndAnswer.answerListCorrect,
                cSharpQuestionAndAnswer.answerListIncorrect1, cSharpQuestionAndAnswer.answerListIncorrect2, cSharpQuestionAndAnswer.answerListIncorrect3);

        }
    }
}
