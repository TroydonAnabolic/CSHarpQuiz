using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSHarpQuizConsole
{
    public class CalculationEngine
    {


        public void CalculateScore(List<string> argQuestions, List<string> argAnswerListCorrect, List<string> argAnswerListIncorrect1, List<string> argAnswerListIncorrect2, List<string> argAnswerListIncorrect3)
        {
            Random rnd = new Random();
            string myAnswer = string.Empty;

            for (int i = 0; i < argQuestions.Count; i++)
            {
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
                            Console.WriteLine(possibleAnswers[randomList[0]]);
                            break;
                        case 1:
                            Console.WriteLine(possibleAnswers[randomList[1]]);
                            break;
                        case 2:
                            Console.WriteLine(possibleAnswers[randomList[2]]);
                            break;
                        case 3:
                            Console.WriteLine(possibleAnswers[randomList[3]]);
                            break;

                    }
                    //Console.WriteLine(possibleAnswers[randomList[k]], possibleAnswers[randomList[1]], possibleAnswers[randomList[2]], possibleAnswers[randomList[3]]);
                }

                //Console.WriteLine($"{argAnswerListCorrect[i]}, {argAnswerListIncorrect2[i]}, {argAnswerListIncorrect1[i]}, {argAnswerListIncorrect3[i]}");
                // Console.WriteLine("{0} ", argAnswerListCorrect[i], argAnswerListIncorrect1[i], argAnswerListIncorrect2[i], argAnswerListIncorrect3[i]);
                Console.ReadLine();

            }
            // Present the result (counter) to the user
        }

        public static void RandomizePosition(string argCorrect, string argIncorr1, string argIncorr2, string argIncorr3)
        {
          


        }

        // Create a list of 4 random numbers
        public static List<int> NewNumber(List<int> argRandList)
        {
            Random a = new Random();
            int MyNumber = 0;

            while(argRandList.Count  < 5) // keep adding numbers to the list until we have 4 numbers in the list
            {

            MyNumber = a.Next(0, 4);
            if (!argRandList.Contains(MyNumber))
                argRandList.Add(MyNumber);
                if (argRandList.Count == 4) break;
            }
            return argRandList;

        }
    }

    public static class ThreadSafeRandom
    {
        [ThreadStatic] private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }

    static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            // get the number of items in the list
            int n = list.Count;

            // while the number of elements is more than 1 we can shuffle
            while (n > 1)
            {
                // decrement until we have only one element
                n--;

                // get a threadsafe random, which is the number before the decrement
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);

                // swap the first number with a random number
                // depending on the type used, assign the type and its value with the next element
                T value = list[k];
                // get the instance value of this next value and assign swap with the decremented value
                list[k] = list[n];

                list[n] = value;
            }
        }

    }
}
