using System;
using System.Collections.Generic;

namespace CSHarpQuizConsole
{
    public class CalculationEngine
    {


        public void CalculateScore(
            List<string> argQuestions, List<string> argAnswerListCorrect, List<string> argAnswerListIncorrect1,
            List<string> argAnswerListIncorrect2, List<string> argAnswerListIncorrect3)
        {
            try
            {
                Random rnd = new Random();
                int correctOption = 0, mySelectedOption = 0;
                decimal score = 0, percentage = 0;
                HashSet<string> grade = new HashSet<string> { "A-", "A", "A+", "B-", "B", "B+", "C-", "D-", "D", "D+" }; // TO DO: Implement grades based on percentage
                string face = string.Empty;
                // Ask the question
                // TODO: Shuffle all questions

                for (int i = 0; i < argQuestions.Count; i++)
                {
                    Console.WriteLine($"Question {i + 1}: {argQuestions[i]}");

                    // creates a list which will be possibly shuffled for each instance, so the answers location is constantly different so the user cannot pickup the pattern
                    List<string> possibleAnswers = new List<string>() { argAnswerListCorrect[i], argAnswerListIncorrect1[i], argAnswerListIncorrect2[i], argAnswerListIncorrect3[i] };

                    // Creates a list of 4 random numbers in each instance of the questions list
                    List<int> randomList = new List<int>();
                    // after we have a random list of numbers 1-4, we use it to apply a random index between 1 and 4 to the list of possible answers 
                    GenerateRandomNumberList(randomList);
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
                        score++;
                        Console.WriteLine($"{Constants.horizontalRule}Good work! Your current Score is: {score} out of {argQuestions.Count}{Constants.horizontalRule}");
                    }
                    else Console.WriteLine($"{Constants.horizontalRule}Sorry that is incorrect, your current score is: {score} out of {argQuestions.Count}{Constants.horizontalRule}");
                    // if a user selects
                }
                percentage = score / argQuestions.Count * 100;
                if (percentage > 90) face = ":))";
                else if (percentage > 50) face = ":)";
                else face = ":(";
                // Present the result (counter) to the user TODO: change int to double to avoid getting 0 error.
                Console.WriteLine($"{Constants.horizontalRule}{Constants.horizontalRule}" +
                    $"Game Over! Your final Score is: {score} out of {argQuestions.Count}! Your achieved a mark of {percentage}% {face}" +
                    $"{Constants.horizontalRule}{Constants.horizontalRule}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Create a list of 4 random numbers method
        public static List<int> GenerateRandomNumberList(List<int> argRandList)
        {
            Random a = new Random();
            int myNumber = 0;

            while (argRandList.Count < 5) // keep adding numbers to the list until we have 4 numbers in the list
            {

                myNumber = a.Next(0, 4);
                if (!argRandList.Contains(myNumber))
                    argRandList.Add(myNumber);
                if (argRandList.Count == 4) break;
            }
            return argRandList;
        }

        // Override Random number generator to shuffle the questions order based on number of questions
        public static List<int> GenerateRandomNumberList(List<int> argRandList, int argNumberOfQuestions)
        {
            try
            {
                Random a = new Random();
                int myNumber = 0;

                while (argRandList.Count < argNumberOfQuestions + 1) // keep adding numbers to the list until we have the total number of questions assigned random indexes
                {

                    myNumber = a.Next(0, argNumberOfQuestions);
                    if (!argRandList.Contains(myNumber))
                        argRandList.Add(myNumber);
                    if (argRandList.Count == argNumberOfQuestions) break;
                }
                return argRandList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        // fast custom method to convert a string to an integer
        public static int ConvertToInteger(string argStringToConvert)
        {
            try
            {
                var temp = 0;
                for (int i = 0; i < argStringToConvert.Length; i++)
                    temp = temp * 10 + (argStringToConvert[i] - '0');
                return temp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
