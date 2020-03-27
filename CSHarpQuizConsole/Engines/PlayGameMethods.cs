﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHarpQuizConsole.Engines
{
    public class PlayGameMethods
    {
        public void PlayGame(CSharpQuestionAndAnswer cSharpQuestionAndAnswer, CalculationEngine calculation)
        {
            var selectGame = string.Empty;
            List<string> gameList = new List<string>() { "HTML", "CSS", "JAVASCRIPT", "C#", "ASP.NET", "SQL", "NETWORKING", "EXIT" };
            bool exitToMenu = false;
            do
            {
                Console.WriteLine($"Select the game you wish to play: " +
                    $"{gameList[0]} {gameList[1]} {gameList[2]} {gameList[3]} {gameList[4]} {gameList[5]} {gameList[6]}. Type {gameList[7]} to return to main menu");
                selectGame = Console.ReadLine() ?? string.Empty;

                switch (selectGame.ToUpper())
                {
                    case "HTML":
                        Console.WriteLine($"Welcome to the {gameList[0]} Game!");
                        break;
                    case "CSS":
                        Console.WriteLine($"Welcome to the {gameList[1]} Game!");
                        break;
                    case "JAVASCRIPT":
                        Console.WriteLine($"Welcome to the {gameList[2]} Game!");
                        break;
                    case "C#":
                        Console.WriteLine($"Welcome to the {gameList[3]} Game!");
                        PlayCsharpGame(cSharpQuestionAndAnswer, calculation);
                        break;
                    case "ASP.NET":
                        Console.WriteLine($"Welcome to the {gameList[4]} Game!");
                        break;
                    case "SQL":
                        Console.WriteLine($"Welcome to the {gameList[5]} Game!");
                        break;
                    case "NETWORKING":
                        Console.WriteLine($"Welcome to the {gameList[6]} Game!");
                        break;
                    case "EXIT":
                        Console.WriteLine($"Exited Game!");
                        exitToMenu = true;
                        break;
                    default:
                        Console.WriteLine("Cannot find game with that name, please check it is on the list, and is spelt correctly");
                        break;
                }

            } while (!exitToMenu);
        }

        public static void PlayCsharpGame(CSharpQuestionAndAnswer cSharpQuestionAndAnswer, CalculationEngine calculation)
        {
            // apply C# calculations
            calculation.CalculateScore(cSharpQuestionAndAnswer.questionsList, cSharpQuestionAndAnswer.answerListCorrect,
                cSharpQuestionAndAnswer.answerListIncorrect1, cSharpQuestionAndAnswer.answerListIncorrect2, cSharpQuestionAndAnswer.answerListIncorrect3);
        }
    }
}