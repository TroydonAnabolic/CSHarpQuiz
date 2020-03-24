using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHarpQuizConsole
{
    public class CSharpQuestionAndAnswer
    {
        public List<string> questionsList = new List<string>
        {
            "What is C#?",
            "What is type-safe?",
            "What is a managed language?",
        };

        public List<string> answerListCorrect = new List<string>
        {
            "C# is an object oriented, type safe, and managed language that is compiled by .NET framework to generate Microsoft Intermediate Language.",
            "Type-safe is when the compiler throws an error if you try to assign the wrong type to a variable e.g 'int x = 5; x = 'test';' this will faile because we are assigning a alphabetic string to type int",
            "A managed language, is when the CLR(Common Language Runtime) that manages execution of .NET programs, is managed by the GC(Garbage Collector). This includes error handling etc, " +
            "instead of being handled by the OS(Operation System)."
        };
        
        public List<string> answerListIncorrect1 = new List<string>
        {
            "C# is an procedural programming, type safe, and non-managed language that is compiled by .NET framework to generate Microsoft Intermediate Language.",
            "Type-safe is when the compiler throws an warning if you try to assign the wrong type to a variable e.g var x = 5; x = 10;' this will fail because we are assigning are assigning a numerical value without declaring as an  int",
        };

        public List<string> answerListIncorrect2 = new List<string>
        {
            "C# is an object oriented, type safe, and unmanaged language that is directly executed by OS, and is compiled by .NET framework to generate Microsoft Intermediate Language.",
            "Type-safe is when the OS throws an error if you try to assign the wrong type to a variable e.g 'int x = 5; x = 'test';' this will faile because we are assigning a alphabetic string to type int",
        };

        public List<string> answerListIncorrect3 = new List<string>
        {
            "C# is a markup, type safe, and managed language that is compiled by .NET framework to generate Microsoft Intermediate Language.",
            "test2"
        };

    }
}
