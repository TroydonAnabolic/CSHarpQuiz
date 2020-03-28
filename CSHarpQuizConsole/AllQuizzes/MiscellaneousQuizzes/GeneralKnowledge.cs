using System.Collections.Generic;

namespace CSHarpQuizConsole.AllQuizzes.MiscellaneousQuizzes
{
    public class GeneralKnowledge
    {
        public List<string> questionsList = new List<string>()
        {
            "What country is sushi from?",
            "According to the Old Testament, how many days did it take God to create the world?",
            "Which is the world's most populous country?",
            "About what percentage of the earth's surface is water?",
            "Is Washington, D.C. a state?",
            "When should you take antibiotics?",
            "Is is true that the shape of a pregnant belly can help parents predict the sex of their baby?",
            "Is Africa a country?",
            "Why are French, Spanish and Italian called Romance languages?",
            "How many moons does the earth have?",
            "About how many countries are there in the world?",
        };

        public List<string> answerListCorrect = new List<string>()
        {
            "Japan",
            "6",
            "China",
            "70%",
            "No",
            "For bacterial infections",
            "No",
            "No",
            "They have roots in Latin, which was spoken by Romans.",
            "1",
            "200",
        };

        // make this list the list that remains when hint is activated
        public List<string> answerListIncorrect1 = new List<string>()
        {
            "Thailand",
            "7",
            "America",
            "90%",
            "Yes",
            "For viruses",
            "Yes",
            "Yes",
            "They sound romantic",
            "0",
            "50",
        };
        public List<string> answerListIncorrect2 = new List<string>()
        {
            "India",
            "6",
            "Brazil",
            "10%",
            string.Empty,
            "Whenever you feel sick",
            string.Empty,
            string.Empty,
            "They are only spoken by Romani",
            "5",
        };
        public List<string> answerListIncorrect3 = new List<string>()
        {
            "France",
            "1",
            "India",
            "50%",
            string.Empty,
            "Never!, it is highly toxic, and can cause grevious damage to human tissue",
            string.Empty,
            string.Empty,
            "They were spread by those who roam",
            "2",
        };
    }
}
