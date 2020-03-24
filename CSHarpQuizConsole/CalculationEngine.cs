using System;
using System.Collections.Generic;

namespace CSHarpQuizConsole
{
    public class CalculationEngine
    {


        public void CalculateScore(List<string> argQuestions, List<string> argAnswerListCorrect, List<string> argAnswerListIncorrect1, List<string> argAnswerListIncorrect2, List<string> argAnswerListIncorrect3)
        {
            Random rnd = new Random();
            int score = 0, correctOption = 0, mySelectedOption = 0;

            for (int i = 0; i < argQuestions.Count; i++)
            {
                // Ask the question
                Console.WriteLine(argQuestions[i]);

                // creates a list which will be possibly shuffled for each instance, so the answers location is constantly different so the user cannot pickup the pattern
                List<string> possibleAnswers = new List<string>() { argAnswerListCorrect[i], argAnswerListIncorrect1[i], argAnswerListIncorrect2[i], argAnswerListIncorrect3[i] };

                // Creates a list of 4 random numbers in each instance of the questions list
                List<int> randomList = new List<int>();
                // after we have a random list of numbers 1-4, we use it to apply a random index between 1 and 4 to the list of possible answers 
                NewNumber(randomList);
                // we randomize the index for each of the elements in possible answers
                for (int k = 0; k < randomList.Count; k++)
                {
                    // depending on the instance random value of k, we assign that random instance as the index of possible answers, and write that as a possible answer
                    switch (k)
                    {
                        case 0:
                            // print out proposed answer
                            Console.WriteLine($"\nOption 1: {possibleAnswers[randomList[0]]}\n");
                            // if this instance is the correct answer then assign it correctOption with the corresponding value
                            if (possibleAnswers[randomList[0]].Equals(argAnswerListCorrect[i])) correctOption = 1;
                            break;
                        case 1:
                            Console.WriteLine($"Option 2: {possibleAnswers[randomList[1]]}\n");
                            if (possibleAnswers[randomList[1]].Equals(argAnswerListCorrect[i])) correctOption = 2;
                            break;
                        case 2:
                            Console.WriteLine($"Option 3: {possibleAnswers[randomList[2]]}\n");
                            if (possibleAnswers[randomList[2]].Equals(argAnswerListCorrect[i])) correctOption = 3;
                            break;
                        case 3:
                            Console.WriteLine($"Option 4: {possibleAnswers[randomList[3]]}\n");
                            if (possibleAnswers[randomList[3]].Equals(argAnswerListCorrect[i])) correctOption = 4;
                            break;
                    }
                }

                Console.WriteLine("\nWhich Option is correct?");

                // if possible answer is the correct one then we will increase the score
                mySelectedOption = ConvertToInteger(Console.ReadLine());
                // each time i select the correct option I am increasing the score
                if (mySelectedOption == correctOption)
                {
                    Console.WriteLine($"\nGood work! Your current Score is: {score}");
                    score++;
                }
                else Console.WriteLine($"\nSorry that is incorrect, your current score is: {score}");
                // if a user selects
            }
            // Present the result (counter) to the user
            Console.WriteLine($"\nGame Over! Your current Score is: {score}!"); 
            // TODO: Implement more quizzes for C# SQL ASP.NET JavaScript HTML and CSS, and use interpolation to show which quiz was completed
        }

        // Create a list of 4 random numbers method
        public static List<int> NewNumber(List<int> argRandList)
        {
            Random a = new Random();
            int MyNumber = 0;

            while (argRandList.Count < 5) // keep adding numbers to the list until we have 4 numbers in the list
            {

                MyNumber = a.Next(0, 4);
                if (!argRandList.Contains(MyNumber))
                    argRandList.Add(MyNumber);
                if (argRandList.Count == 4) break;
            }
            return argRandList;
        }

        // fast custom method to convert a string to an integer
        public static int ConvertToInteger(string argStringToConvert)
        {
            var temp = 0;
            for (int i = 0; i < argStringToConvert.Length; i++)
                temp = temp * 10 + (argStringToConvert[i] - '0');

            return temp;
        }
    }
}
